﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
    public class Seyahat:IUlasim,IKonaklama
    {
         public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int TC_No { set; get; }
        public DateTime dogumtarihi { get; set; }
        public DateTime gidisTarihi { get; set; }
        public DateTime donusTarihi { get; set; }
        public string firmaAdi { get; set; }
        public decimal fiyat { get; set; }
        
      
    
    }
}
