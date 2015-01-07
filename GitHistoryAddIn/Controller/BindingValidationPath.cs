using GitHistoryAddIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHistoryAddIn.Controller
{
    public class BindingValidationPath
    {
        private GitProjectBinding _binding;

        public BindingValidationPath(GitProjectBinding binding)
        {
            this._binding = binding;
        }

        public string TestUrl
        {
            get
            {
                return string.Format("http://github.com/{0}/{1}/{2}.sln", this._binding.ProjectAuthor, this._binding.ProjectName, this._binding.Solution);
            }
        }

        public string SolutionFilename
        {
            get
            {
                return string.Format("{0}.sln", this._binding.Solution);
            }
        }
    }
}
