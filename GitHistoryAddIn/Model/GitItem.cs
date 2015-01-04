using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHistoryAddIn.Model
{
    public class GitItem
    {
        public enum GitItemType
        {
            Folder,
            SourceCode,
            Project
        }

        public GitItemType Type { get; set; }

        public string Path { get; set; }
    }
}
