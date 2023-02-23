using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pawcare.Models.Base;

namespace pawcare.Models
{
  public class dog : Model
    {
        public string? dogName{get;set;}
        public DateTime birthday{get;set;}
        public int _weight {get;set;}
        public string? race {get;set;}
        public Cliente idClient{get;set;}=default!;
        public string? photo{get;set;}
        public medic_Dates idmedicDates{get;set;}= default!;
        public estetic_Dates idestetic_Dates{get;set;}= default!;
        public medicalRecords id_records{get;set;}= default!;
        public deworming id_deworming{get;set;}= default!;

    }
}