using System;
using GestionPharmacie.Models;


public class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu de sélection");
            Console.WriteLine("1. Ajouter un produit");
            Console.WriteLine("2. Editer un produit");
            Console.WriteLine("3. Supprimer un produit");
            Console.WriteLine("4. Afficher le stock de produit");
            Console.WriteLine("5. Remplir une facture");
            Console.WriteLine("6. Imprimer une facture");
            Console.WriteLine("7. Validation paiement");
            Console.WriteLine("8. Quitter");

            Console.Write("Veuillez choisir une option : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ajouter un produit");
                    break;
                case "2":
                    Console.WriteLine("Editer un produit");
                    break;
                case "3":
                    Console.WriteLine("Supprimer un produit");
                    break;
                case "4":
                    Console.WriteLine("Afficher le stock de produit");
                    break;
                case "5":
                    Console.WriteLine("Remplir une facture");
                    break;
                case "6":
                    Console.WriteLine("Imprimer une facture");
                    break;
                case "7":
                    Console.WriteLine("Validation paiement");
                    break;
                case "8":
                    exit = true;
                    Console.WriteLine("Au revoir !");
                    break;
                default:
                    Console.WriteLine("Option invalide");
                    break;
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

