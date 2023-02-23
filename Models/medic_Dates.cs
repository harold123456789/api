using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pawcare.Models.Base;

namespace pawcare.Models
{
    public class medic_Dates: Model
    {
        public DateTime _date{get;set;}
        public string? notes{get;set;}

    }
}