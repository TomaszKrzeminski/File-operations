using ConsoleTableExt;
using CsvHelper;
using CsvHelper.Configuration;
using ReadWriteFile.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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
            //    YourNewStyleDB x2 = map.MapMet(x);
            //    listDb.Add(x2);
            //}

            GetFilePath getpath = new GetFilePath();
           string path= getpath.GetPath("test.json");
            
            //string path = @"C:\Users\tomas\Downloads\test.json";
            FileOperationJson operation = new FileOperationJson(path);
            operation.Read();
            Root root = new Root();

            InnerClass inner = new InnerClass();
            inner.Id = 1;
            inner.Name = "Inner 1";
            inner.Text = "Text 1";

            InnerClass inner2 = new InnerClass();
            inner.Id = 1;
            inner.Name = "Inner 2";
            inner.Text = "Text 2";

            TestClass test = new TestClass();
            test.Id = 10;
            test.Name = "Test name";
            test.list.Add(inner);
            test.list.Add(inner2);

            SaveFileAsJson saveJson = new SaveFileAsJson(@"C:\Users\tomas\OneDrive\Pulpit\JsonFile.json", test);
            saveJson.Save();

            ReadXmlToObject read = new ReadXmlToObject(@"C:\Users\tomas\OneDrive\Pulpit\testxmlfile.xml");
            read.Read();
            Customers obj = read.customers;

            SaveFileAsXml save = new SaveFileAsXml(@"C:\Users\tomas\OneDrive\Pulpit\testxmlfile2.xml", obj);
            save.Save();

            Console.ReadLine();

        }
    }
}
