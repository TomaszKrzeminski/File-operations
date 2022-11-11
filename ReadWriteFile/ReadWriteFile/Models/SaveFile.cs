using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile.Models
{
    public class SaveFile
    {
        public string Path { get; set; }
        
        public SaveFile(string Path)
        {
            this.Path = Path;
        }
        public virtual bool Save()
        {
            return false;
        }

        public  bool Save(string Text)
        {
            try
            {
                File.WriteAllText(Path, Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }

    }
}
