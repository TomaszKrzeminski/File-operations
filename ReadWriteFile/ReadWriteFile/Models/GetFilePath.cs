using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile.Models
{
    public class GetFilePath
    {

        public string GetPath(string FileName)
        {
            string Path = "";
            string x = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Path += AppDomain.CurrentDomain.BaseDirectory;
            return Path;
        }


    }
}
