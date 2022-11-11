using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile.Models
{
    public interface IFileOperation
    {
        string Path { get; set; }
        void Read();
    }
    internal class FileOperation:IFileOperation
    {
        public string Path { get; set; }
        public string Text { get; set; }

        public FileOperation(string Path)
        {
            this.Path = Path;
        }
        public virtual void Read()
        {
            Text = System.IO.File.ReadAllText(Path);
        }       


    }

}
