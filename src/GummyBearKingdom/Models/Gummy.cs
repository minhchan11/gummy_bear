using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBearKingdom.Models
{
    [Table("Gummies")]
    public class Gummy
    {
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public string origin { get; set; }
    }
}
