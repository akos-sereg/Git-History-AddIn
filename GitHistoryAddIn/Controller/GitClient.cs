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

        public async void GetCommits(string gitFilePath, GitHistory.ProcessCommits onReturned)
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHistoryAddIn"));
            github.Credentials = new Credentials(this.binding.GitUsername, this.binding.GitPassword);
            IReadOnlyList<GitHubCommit> commits = await github.Repository.Commits.GetAll(binding.ProjectAuthor, binding.ProjectName, new CommitRequest { Path = gitFilePath });
            
            onReturned(commits);
        }
    }
}
