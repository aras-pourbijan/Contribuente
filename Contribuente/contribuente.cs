using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuente
{
      
    internal class Contribuente
    {
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public DateTime DataNascita { get; set; } 
        public string CodiceFiscale { get; set; }   
        public bool IsMale { get; set; }
        public string ComuneResidenza { get; set; } 
        public decimal RedditoAnnuale { get; set; } 

        public Contribuente() { }
        public Contribuente(string Nome, String Cognome, DateTime DataNascita, string CodiceFiscale, bool IsMale, string ComuneResidenza, decimal RedditoAnnuale)
        { 
           
        }
    }
}
