using AutoMapper.Execution;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile.Models
{

    public class YourNewStyle
    {
        [Index(0)]
        public string Id { get; set; }
        [Index(1)]
        public string Code { get; set; }
        [Index(2)]
        public string Producer_Code { get; set; }
        [Index(3)]
        public string Producer { get; set; }
        [Index(4)]
        public string Price_netto { get; set; }
        [Index(5)]
        public string Price_brutto { get; set; }
       

    }



}
