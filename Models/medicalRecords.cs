using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pawcare.Models.Base;

namespace pawcare.Models
{
    public class medicalRecords : Model
    {
        
        public string? vaccines {get;set;}
        public string? deworming{get;set;}
        public string? medicines {get;set;}

        
    }
}