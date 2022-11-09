using ConsoleTableExt;
using CsvHelper;
using CsvHelper.Configuration;
using ReadWriteFile.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Path = @"C:\Users\tomas\Downloads\yournewstyle.csv";

            //ConvertCsvToObject convert = new ConvertCsvToObject(Path);
            //List<YourNewStyle> list = convert.Convert<YourNewStyle>();
            //SaveFileAsCsv<YourNewStyle> save = new SaveFileAsCsv<YourNewStyle>(@"C:\Users\tomas\Downloads\yournewstyle2.csv", list);
            //save.Save();

            //Mapper_YourNewStyleDB map = new Mapper_YourNewStyleDB();
            //List<YourNewStyleDB> listDb = new List<YourNewStyleDB>();
            //foreach (var x in list)
            //{
            //YourNewStyleDB x2 = map.MapMet(x);
            //    listDb.Add(x2);
            //}       

            string path = @"C:\Users\tomas\Downloads\Test.json";
            
            FileOperationJson operation = new FileOperationJson(path);
            operation.Read();



            Console.ReadLine();

        }
    }
}
