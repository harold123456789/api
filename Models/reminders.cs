using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pawcare.Models.Base;

namespace pawcare.Models
{
    public class reminders : Model
    {
        public medic_Dates id_medicDates{get;set;} = default!;
        public estetic_Dates id_esteticDates{get;set;}=default!;
        public dog idDog {get;set;}=default!;
        
        
    }
}