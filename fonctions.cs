using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace repertoireTelephonique
{
    partial class Program
    {
        static void affichetoutlecarnet(string []nomCarnet, string []telCarnet, int nb_lignes)
        {
		        // affichage
	        Console.WriteLine("\n\n__________________________________________________");
	        Console.WriteLine("Numero\tNom\tTelephone");
	        for(int numligne=0;numligne<nb_lignes;numligne=numligne+1)
	        {
		        Console.WriteLine( (numligne+1)+"\t" +nomCarnet[numligne]+"\t"+telCarnet[numligne]);
	        }
	        Console.WriteLine("_________________________________________________\n\n");
        }
        //_______________________________________________________________
        static void afficheuncorrespondant(int numligne, string[] nomCarnet, string[] telCarnet)
        {
	        // affichage
	        Console.WriteLine("\n\n_________________________________________________");
	        Console.WriteLine("Numero\tNom\tTelephone");
	        Console.WriteLine( (numligne+1)+"\t" +nomCarnet[numligne]+"\t"+telCarnet[numligne]);
	        Console.WriteLine("_________________________________________________\n\n");
	
        }
        //_______________________________________________________________
        static int initialise(string[] nomCarnet, string[] telCarnet)  // crée des valeurs et renvoie le nombre de correspondants
        {
	        // ici on "colle" quelques noms et téléphones pour démarrer les tests
	        nomCarnet[0]="Dupont";
            telCarnet[0] = "06 90 41 41 41";
	        nomCarnet[1]="Duplis";
	        telCarnet[1]= "06 90 42 42 42";
	        nomCarnet[2]="Alling";
	        telCarnet[2]= "06 90 43 43 43";
	        nomCarnet[3]="Herbert";
	        telCarnet[3]= "06 90 44 44 44";
	        return 4; // nombre de correspondants créés
        }// fin initialise
        //_______________________________________________________________

        static int isubstr(string ch1, string ch2) // fonction de recherche de sous-chaine
        {
            int index = -1;         // valeur "non trouvée" par défaut
            if (ch1.Length != 0 && ch2.Length != 0)
            {
                index = ch1.CompareTo(ch2);
            }
           
            return index;       // renvoie le résultat si trouvé, sinon -1
        }// fin isubstr
        //_______________________________________________________________
        static void saisir(string[] nomCarnet, string[] telCarnet, string nomSaisi, string telSaisi, ref int nb_corresp)
        {
	        if(nb_corresp < 10)
            {
                nomCarnet[nb_corresp] = nomSaisi;
                telCarnet[nb_corresp] = telSaisi;
                nb_corresp++;
            }
            else
            {
                Console.WriteLine("Aucune place disponible dans le répertoire");
            }
        }// fin saisir
        //_______________________________________________________________
        static int chercheNom(string nom, string[] nomCarnet, int nb_corresp)
        {
	        int rang=-1, i=0;
            while (i < nb_corresp && rang != -1)
            {
                if (nom == nomCarnet[i])
                {
                    rang = i;
                }
                i++;
            }
	        
	        return rang;
        }
        static int chercheNumTel(string numtel, string[] telCarnet, int nb_corresp)
        {
            int rang = -1, i = 0;
            while (i < nb_corresp && rang != -1)
            {
                if (numtel == telCarnet[i])
                {
                    rang = i;
                }
                i++;
            }

            return rang;
        }
        static void chercheindicatif(string indicatif, string[] nomCarnet, int nb_corresp, string[] telCarnet, int[] tabRang, ref int nbtrouve)
        {
            /* la liste des rangs sera stocké dans le tableau tabRang*/
            int rang = -1, i = 0,j=0;
            while (i < nb_corresp && rang != -1)
            {
                if (indicatif.Equals(telCarnet[i].Substring(0, 5)))
                {
                    tabRang[j]= i;
                    j++;
                }
                i++;
            }

    }
}
