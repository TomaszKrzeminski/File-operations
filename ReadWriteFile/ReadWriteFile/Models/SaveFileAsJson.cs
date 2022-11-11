using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadWriteFile.Models
{

    public class TestClass
    {
        public TestClass()
        {
            list = new List<InnerClass>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<InnerClass> list;
    }

    public class InnerClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }



    public class SaveFileAsJson : SaveFile
    {
        TestClass test { get; set; }
        public SaveFileAsJson(string Path,TestClass test) : base(Path)
        {
            this.test = test;
        }
        
        public string Convert()
        {
             return  JsonConvert.SerializeObject(test);
        }


        public override bool Save()
        {
            try
            {
                //File.WriteAllText(Path, Convert());
                base.Save(Convert());
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

    }

}
