using GitHistoryAddIn.Model;
using GitHistoryAddIn.View;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHistoryAddIn.Controller
{
    public class GitClient
    {
        private GitProjectBinding binding;
        
        public GitClient(GitProjectBinding binding)
        {
            this.binding = binding;
        }

        public async void GetCommits(string gitFilePath, GitHistory.ProcessCommits onReturned, GitHistory.ProcessCommitsError onProcessCommitsError)
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHistoryAddIn"));
            github.Credentials = new Credentials(this.binding.GitUsername, this.binding.GitPassword);

            try
            {
                IReadOnlyList<GitHubCommit> commits = await github.Repository.Commits.GetAll(binding.ProjectAuthor, binding.ProjectName, new CommitRequest { Path = gitFilePath });
                onReturned(commits);
            }
            catch (Exception err)
            {
                onProcessCommitsError(err);
            }
        }

        public async void ValidateBinding(GitHistory.BindingValidationComplete onBindingValidationComplete, GitHistory.BindingValidationError onBindingValidationError)
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHistoryAddIn"));
            github.Credentials = new Credentials(this.binding.GitUsername, this.binding.GitPassword);

            string testFileInRepository = string.Format("{0}.sln", this.binding.Solution);

            IReadOnlyList<GitHubCommit> commits = null;
            try
            {
                commits = await github.Repository.Commits.GetAll(binding.ProjectAuthor,
                    binding.ProjectName,
                    new CommitRequest { Path = testFileInRepository });

                onBindingValidationComplete(commits != null ? commits.Count > 0 : false, testFileInRepository, binding);
            }
            catch (Exception err)
            {
                onBindingValidationError(err);
            }
        }
    }
}
