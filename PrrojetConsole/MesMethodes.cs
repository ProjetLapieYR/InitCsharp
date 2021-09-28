using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrrojetConsole
{
   public class MesMethodes
    {
        //Une classe peut contenir 2 types de méthoddes 
        //Méthodes de classe - méthode static accésubles via la classe directement 
        //Méthode d'instance : pas de mot static - accésibles via une instance de la classe(donc via un obet de la classe)


       /// <summary>
         /// calcule la somme
         /// </summary>
       /// <param name="x"></param>
        /// <param name="y"></param>
      /// <returns>est un entier. Somme de x et y </returns>
        public static int Somme(int x, int y)
        {

            return x + y;

        }



        public static void Afficher()
        {
            Console.WriteLine("Méthode void sans type de retour.");
        }

        //Surcharge(overload): le fait de pouvoir définir la même méhthode dans la classe avec uniquement la liste de paramètre qqui change


        public static double Somme(double x,double y)
        {
            return (x + y);

        }


        //Méthode pour lister le contenu d'un tableau

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

        }


        //Méthode qui renvoie la somme des éléments d'un tableaux d'entiers


        public static int Somme(int[] tab)
        {
            int som = 0;
            foreach (int item in tab)
            {
                som += item;
            }
           
                return som;
            
        }
        //Méthodes qui renvoie la moyenne des éléments d'un tableaux d'entiers

        public static double Moyenne(int[] tab)
        {


            double som = 0;
            foreach (var item in tab)
            {
                som += item;
            }
            return som / tab.Length;


           
        }

        //Méthodes qui renvoie l' éléments le plus petits d'un tableaux d'entiers

        public static int Minimum(int[] tab)
        {

            int min = tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if(tab[i]< min)
                {
                    min = tab[i];
                }
            }




            return min;
        }



        //Paramètres optionels d'une méthode
        //Se sont des params qui possèdent
        public static int SomeOptional(int x, int y, int z=10)
        {

            return x + y + z;
        }


        //Méthode qui permute 2 entiers
        //ref concerne que le types simple(types valeur)
       
        public static void Permuter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;



        }

        //Paramètre en sortie
        public static double Calculer(double x, double y, out double somme, out double moyenne)
        {
            moyenne = (x + y) / 2;
            somme = x + y;
            return x * y;
            
        }


        //Nombre variable de paramètre d'une méthode




        //public static int Produit(int x,int y)

        //{
        //    return x * y;
        //}
        //public static int Produit(int x, int y, int z)

        //{
        //    return x * y * z;
        //}

        //public static int Produit(int x, int y, int z, int a)

        //{
        //    return x * y * z*a;
        //}

        public static int Produit(params int[]tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod *= item;
            }
            return prod;

        }










    }
}
