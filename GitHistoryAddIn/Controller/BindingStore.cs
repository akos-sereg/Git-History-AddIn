using GitHistoryAddIn.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GitHistoryAddIn.Controller
{
    public class BindingStore
    {
        public string _bindingStoreFile;

        public BindingStore()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            _bindingStoreFile = string.Format("{0}/ProjectBindings.xml", path.Remove(0, "file:\\\\".Length - 1));
        }

        public void Store(GitProjectBinding projectBinding, bool force = false)
        {
            List<GitProjectBinding> bindings = GetBindings();

            GitProjectBinding existingBinding = bindings.FirstOrDefault(x => x.Solution == projectBinding.Solution);
            if (existingBinding == null || force)
            {
                bindings.RemoveAll(x => x.Solution == projectBinding.Solution); // Remove previously saved binding(s)
                bindings.Add(projectBinding);

                this.Save(bindings);
            }
        }

        public void Remove(GitProjectBinding binding)
        {
            List<GitProjectBinding> bindings = GetBindings();
            bindings.RemoveAll(x => x.Solution == binding.Solution);
            
            this.Save(bindings);
        }

        public List<GitProjectBinding> GetBindings()
        {
            try
            {
                List<GitProjectBinding> obj = null;
                XmlSerializer x = new XmlSerializer(new List<GitProjectBinding>().GetType());

                using (TextReader reader = File.OpenText(this._bindingStoreFile))
                {
                    obj = (List<GitProjectBinding>)x.Deserialize(reader);
                    reader.Close();
                }

                return obj;
            }
            catch (Exception err)
            {
                return new List<GitProjectBinding>();
            }
        }

        private void Save(List<GitProjectBinding> bindings)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(bindings.GetType());

                using (TextWriter writer = File.CreateText(this._bindingStoreFile))
                {
                    x.Serialize(writer, bindings);
                    writer.Close();
                }
            }
            catch (Exception err) 
            {
                Debug.WriteLine(err.Message);
            }
        }
    }
}
