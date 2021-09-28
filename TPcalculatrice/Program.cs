using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPcalculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            double valeur1 = 0, valeur2 = 0;


            //Affichage du menu
            Console.WriteLine("*******Calculatrice console***********");
            Console.WriteLine("Choisir une opération");
            Console.WriteLine("Addition tapez a");
            Console.WriteLine("Soustraction tapez b");
            Console.WriteLine("Multiplication tapez c");
            Console.WriteLine("Division tapez d");

            //Récupérer le choix de l'uutilisateur -si le choix n'est pas valide- on l'invite
            //à faire un autre choix


            do
            {
                Console.WriteLine("Faite votre choix");
                choix = Console.ReadLine();
            }

            while (!(choix == "a" || choix == "b" || choix == "c" || choix == "d"));





            //Demander la saisie de la valeur 1

            Console.WriteLine("Donner valeur:");
            valeur1 = Convert.ToDouble(Console.ReadLine());

            //Demander la saisie de la valeur 2

            Console.WriteLine("Donner valeur:");
            valeur2 = Convert.ToDouble(Console.ReadLine());


            //Afficher à la console le résultat

            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+"+ valeur2 + "=" + (valeur1 + valeur2));
                    break;


                case "b":
                    Console.WriteLine(valeur1 + "-"+ valeur2 + "=" + (valeur1 - valeur2));
                    break;

                case "c":
                    Console.WriteLine(valeur1 + "*"+ valeur2 + "=" + (valeur1 * valeur2));
                    break;

                case "d":
                    Console.WriteLine(valeur1 + "/"+ valeur2 + "=" + (valeur1 / valeur2));
                    break;



            }

            Console.ReadLine();
        }
    }
}


