using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile.Models
{
    public class SaveFileAsCsv<T>:SaveFile
    {
        public SaveFileAsCsv(string Path,List<T> list):base(Path)
        {
                this.list= list;    
        }

        List<T> list;

        public override bool Save()
        {
            try
            {
                using (var writer = new StreamWriter(Path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(list);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

    }

}
