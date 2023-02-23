using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pawcare.Models.Base;

namespace pawcare.Models
{
    public class deworming:Model
    {
        public DateTime _date{get;set;}
        public string? notes{get;set;}
        public string? frecuency{get;set;}

        
    }
}