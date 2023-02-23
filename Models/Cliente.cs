using pawcare.Models.Base;

namespace pawcare.Models
{
    public class Cliente: Model
    {   
        public string? clientName{get;set;}
        public string? clientLastName{get;set;}
        public string? numberPhone{get;set;}
         public virtual IList<dog> idDog { get; set; } = default!;
        public DateTime age{get;set;}

        
    }
}