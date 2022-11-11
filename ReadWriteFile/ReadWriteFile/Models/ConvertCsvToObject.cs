using CsvHelper.Configuration;
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
    internal class ConvertCsvToObject
    {
        public string Path { get; set; }

        public string Text { get; set; }

        public ConvertCsvToObject(string path)
        {
            Path = path;
        }      

        public List<T> Convert<T>()
        {
            List<T> list = new List<T>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                BadDataFound = null,
                HasHeaderRecord = true,
                Delimiter = ";"


            };
            using (var reader = new StreamReader(Path))
            using (var csv = new CsvReader(reader, config))
            {
                var list1 = csv.GetRecords<T>();
                list = list1.ToList<T>();
            }
            return list;
        }

    }
}
