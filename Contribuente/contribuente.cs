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
        public string Sesso { get; set; }

        public bool IsMale { get; set; }
        public string ComuneResidenza { get; set; } 
        public decimal RedditoAnnuale { get; set; }
        public string Titolo = "Signor";
        public string ConfermaInformazioni { get; set; }    
        public decimal ImpostoDaVersare { get; set; }
        public string tryAgain { get; set; }



        public Contribuente() { }
        public Contribuente(string Nome, String Cognome, DateTime DataNascita, string CodiceFiscale, string Sesso, string ComuneResidenza, decimal RedditoAnnuale)
        {
            this.IsMale= true;  
            
        }

       public void StartMenu()
        {
            try
            {
                Console.WriteLine("===============Gestione Contribuente==============");
                Console.WriteLine("Benvenuti nella nuova area riservata dell'Agenzia delle Entrate");
                Console.WriteLine("inserisci informazioni richiesti per calcolare imposta dovuta da pagare");
                Console.WriteLine("per continuale premi ENTER");
                Console.ReadLine(); 
                Console.WriteLine("nome:");
                Nome = Console.ReadLine();
                Console.WriteLine("inserisci Cognome:");
                Cognome = Console.ReadLine();
                Console.WriteLine("inserisci data di nascita (esempio 26/07/1999):");
                try { 
                    DataNascita = DateTime.Parse(Console.ReadLine());
                }catch(Exception) {
                    Console.WriteLine("errore! inserisci data di nascita in questo formato: dd/mm/yyyy");
                    DataNascita = DateTime.Parse(Console.ReadLine());
                }
                
                Console.WriteLine("Codice Fiscale:");
                CodiceFiscale = Console.ReadLine();
                Console.WriteLine("sesso ( m/f):");
                Sesso = Console.ReadLine();
                if (Sesso == "f" || Sesso == "F" || Sesso == "femmina" || Sesso == "donna") {

                    this.IsMale = false;
                    this.Titolo = "Signora";
                    
                }
                Console.WriteLine("Comune di residenza :");
                ComuneResidenza = Console.ReadLine();
                Console.WriteLine("Reddito Annuale :");
                RedditoAnnuale = Convert.ToDecimal(Console.ReadLine());  
                Console.WriteLine("=======================================");
                Console.WriteLine("premi ENTER per visualizzare informazioni inseriti");
                Console.WriteLine("=======================================");
                Console.ReadLine();
                Console.WriteLine($"{Titolo} {Nome} {Cognome} ");
                Console.WriteLine($"Nato il {DataNascita.ToString("dd/MM/yyyy")} residente a {ComuneResidenza}");
                Console.WriteLine($"Codice Fiscale:   {CodiceFiscale}");
                Console.WriteLine($"Reddito Annuale pari a {RedditoAnnuale} euro");
                Console.WriteLine("=======================================");
                Console.WriteLine("confermi? (y/n)");
                ConfermaInformazioni= Console.ReadLine();
                if (ConfermaInformazioni == "y")
                {
                    CalcolaImposto();


                } else if(ConfermaInformazioni == "n")
                {
                    Console.WriteLine("riprova!");
                    Console.WriteLine("*******");
                    StartMenu();
                }
                else
                {
                    Console.WriteLine("Risposta sbagliata! rispondi con 'y' o 'n'");
                    Console.WriteLine("confermi? (y/n)");
                    ConfermaInformazioni = Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore:{ex}");
                StartMenu();

            }

        }
        
        public void CalcolaImposto()
        {
            if (RedditoAnnuale <= 15000)
            {
                ImpostoDaVersare = RedditoAnnuale * 23 / 100;          
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                ImpostoDaVersare = ((RedditoAnnuale-15000) * 27 / 100) + 3450;
               
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                ImpostoDaVersare = ((RedditoAnnuale - 28000) * 38 / 100) + 6960;
               
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                ImpostoDaVersare = ((RedditoAnnuale - 55000) * 41 / 100) + 17220;
                
            }
            else if (RedditoAnnuale > 75000)
            {
                ImpostoDaVersare = ((RedditoAnnuale - 75000 )* 43 / 100) + 25420;

            }


            StampaRisultato();
            Console.Read();

        }

        public void StampaRisultato()
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"Contribuente:{Titolo} {Nome} {Cognome},");
            Console.WriteLine($"Nato il {DataNascita} ({Sesso})");
            Console.WriteLine($"Residente in {ComuneResidenza}");
            Console.WriteLine($"Codice fiscale: {CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {RedditoAnnuale}");
            Console.WriteLine($"Imposta da Versare: {ImpostoDaVersare} euro!  ");
            Console.WriteLine("========== Mi dispiace!!! =========");
            Console.WriteLine("per riprovare premi r , per uscire dal programma premi x ");
            tryAgain= Console.ReadLine();
            if (tryAgain == "r") 
            {
                StartMenu();
            }else if(tryAgain == "x")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("per riprovare premi r , per uscire dal programma premi x ");
                tryAgain = Console.ReadLine();
            }



        }
    }

   
}
