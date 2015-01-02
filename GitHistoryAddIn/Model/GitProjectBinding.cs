using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHistoryAddIn.Model
{
    [Serializable()]
    public class GitProjectBinding
    {
        public string GitUsername { get; set; }

        public string GitPassword { get; set; }

        public string Solution { get; set; }

        public string ProjectName { get; set; }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(this.GitUsername) && !string.IsNullOrEmpty(this.GitPassword)
                    && !string.IsNullOrEmpty(this.ProjectName) && !string.IsNullOrEmpty(this.Solution);
            }
        }
    }
}
