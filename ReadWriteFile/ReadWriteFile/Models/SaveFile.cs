using System;
using System.Collections.Generic;
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
        public virtual void Save()
        {

        }

    }
}
