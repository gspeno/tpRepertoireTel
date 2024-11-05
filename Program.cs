using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace repertoireTelephonique
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string [] nomCarnet = new string[10];  // nom
            string [] telCarnet = new string[10];   //telephone
	        int nb_corresp;			// nombre correspondants présents dans le carnet
	        char choix_menu='?';	// choix dans le menu
	        string nom;				// nom qu'on cherchera
	        string numtel;			// numéro de téléphone qu'on cherchera
	        int rang;				// rang du correspondant dans le tableau

	        // initialisation du carnet : fonction qui insère quelques noms dans le carnet
            nb_corresp = initialise(nomCarnet, telCarnet);

	        // affichage du menu et aiguillage
	        while (choix_menu != 'f' && choix_menu != 'F') // f pour fin
	        {
		        Console.WriteLine("*** Carnet d'adresses ***");
		        Console.WriteLine("(A)fficher tout le carnet");
		        Console.WriteLine("(S)aisir un correspondant");
		        Console.WriteLine("(R)echercher un correspondant par nom");
		        Console.WriteLine("(T)rouver un numero");
		        Console.WriteLine("(F)in du programme");

		        Console.WriteLine("\nTapez l'initiale de votre choix : ");
		        choix_menu=Convert.ToChar(Console.ReadLine());

		        switch(choix_menu)
		        {
		        case 'A': 
		        case 'a':	{	
						        //Code pour afficher tout le carnet
                                
					        } 
					        break;

		        case 'S': 
		        case 's':	{
								//Code pour saisir un contact dans le carnet

					        }
					        break;

		        case 'R': // recherche un nom, renvoie le numéro de composante
		        case 'r': {
					        
				          }
				          break;

		        case 'T': // recherche un numéro de téléphone à 10 chiffres
		        case 't': {
					        
				          }
				          break;
		        default:{
					        // rien de spécial à faire : sortira par f ou F
				        }
                          break;
		        }//fin switch

	        }// fin tant que choix_menu



        }
    }
}
