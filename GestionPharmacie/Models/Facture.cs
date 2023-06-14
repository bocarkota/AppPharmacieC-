using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Models
{
    public class Facture
    {
        public int idFacture { get; set; } 
        public string nomClient { get; set;}
        public decimal montantFacture { get; set;}
        public bool paiementEffectue { get; set; }

        public Facture(int id, string nom, decimal montant) 
        {
            idFacture = id;
            nomClient = nom;
            montantFacture = montant;
            paiementEffectue = false;
            
        }

        // Validation paiement
        public void facturePayee()
        {
            paiementEffectue = true;
        }

        // Impression facture
        public void imprimerFcture()
        {
            Console.WriteLine("Id facture: " + idFacture);
            Console.WriteLine("Nom client: " + nomClient);
            Console.WriteLine("Montant à payer: " + montantFacture);
            Console.WriteLine("status paiement:" + (paiementEffectue ? "Efféctue" : "Non effectué"));

        }
    }
}
