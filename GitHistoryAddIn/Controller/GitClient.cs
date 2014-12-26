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
        public async void GetCommits(string gitUser, string gitPassword, string gitRepo, string gitFilePath, GitHistoryAddIn.View.GitHistory.ProcessCommits onReturned)
        {
            GitHubSharp.Client client = GitHubSharp.Client.Basic(gitUser, gitPassword);

            RepositoryController repoController = new RepositoryController(client, gitUser, gitRepo);

            CommitsController commitsCtr = new CommitsController(client, repoController);
            commitsCtr.FilePath = gitFilePath;
            GitHubRequest<List<CommitModel>> commits = commitsCtr.GetAll();
            
            GitHubResponse<List<CommitModel>> response = await client.ExecuteAsync(commits);

            onReturned(response.Data);
        }
    }
}
