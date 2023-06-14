using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Models
{
    public class GestionStock
    {
        private List<Produit> produits;
        public GestionStock()
        {
            produits = new List<Produit>();
        }

        // Ajouter un produit
        public void ajouterProduit(Produit produit)
        {
            produits.Add(produit);
        }

        // Supprimer un produit
        public void supprimerProduit(int idProduit)
        {
            Produit produit = produits.Find(p => p.id == idProduit);
            if (produit != null) 
            {
                produits.Remove(produit);
            }
        }

        // Editer un produit
        public void editerProduit(int idProduit, string nom, int quantite)
        {
            Produit produit = produits.Find(p => p.id == idProduit);
            if (produit != null) 
            {
                produit.nom = nom;
                produit.quantite = quantite;
            }

        }

        // Afficher le stock de produit
        public void afficherStock()
        {
            Console.WriteLine("Stock actuel");
            foreach(Produit produit in produits)
            {
                Console.WriteLine($"Id produit: {produit.id}, Nom: {produit.nom}, Quantité: {produit.quantite}");
            }
        }
    }
}
