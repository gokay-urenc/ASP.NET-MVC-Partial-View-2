using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_21_Partial_Views.Models
{
    public class Urun
    {
        public int id { get; set; }
        public string ad { get; set; }
        public decimal fiyat { get; set; }
        public string resimYolu { get; set; }
    }
}