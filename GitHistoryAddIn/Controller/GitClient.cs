using GitHistoryAddIn.Model;
using GitHistoryAddIn.View;
using GitHubSharp;
using GitHubSharp.Controllers;
using GitHubSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHistoryAddIn.Controller
{
    public class GitClient
    {
        public async void GetCommits(GitProjectBinding binding, string gitFilePath, GitHistory.ProcessCommits onReturned)
        {
            GitHubSharp.Client client = GitHubSharp.Client.Basic(binding.GitUsername, binding.GitPassword);

            RepositoryController repoController = new RepositoryController(client, binding.ProjectAuthor, binding.ProjectName);

            CommitsController commitsCtr = new CommitsController(client, repoController);
            commitsCtr.FilePath = gitFilePath;
            GitHubRequest<List<CommitModel>> commits = commitsCtr.GetAll();
            
            GitHubResponse<List<CommitModel>> response = await client.ExecuteAsync(commits);

            onReturned(response.Data);
        }
    }
}
