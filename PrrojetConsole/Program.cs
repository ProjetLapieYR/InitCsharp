

using ProjetDLL;
using System;

namespace PrrojetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test de c#");
            tools.MaMethode();

            #region Variables

            //Variable: zone mémoire qui contient une valeur typée
            //Type simple(types valeur aussi):entier,réel,booléen,char
            //Type complexe( types références):tableau,string,dates,classes(objets)

            //entiers: byte(1 o),short(2o),int(4 o),long(8 o)
            //réels: floats(4 o),double(8 o),decimal(16 o)
            // declaration d"une variable: type nom_variable=valeur
            int myInt = 10;
            char myChar='b';
            bool myBool = true;
            string maChaine = "b";

            //Mot clé var: Inférence de type ---c'est le compilateur qui détermine le type de la variable
            //selon sa valeur

            //Type nullables: .net propose une syntaxe qui permet de définir des types simple null
            int? x = null;

            //avant utilisation de x, on doit vérifier qu"elle contient une valeur

            if(x.HasValue)
            {

                Console.WriteLine("x n'est pas null");

            }
            else
            {
                Console.WriteLine("x est null");
            }


                String str = null;

            int age = 0;
            Console.WriteLine("Quel est votre age:");
            age=Convert.ToInt32(Console.ReadLine());// si le user oublie de fournir l'âge en aura une erreur

            var maVariable = 10;

            Console.WriteLine("Contenu de ly int:" + myInt);//+: concaténation


            //Constante : variable contenant une valeur qu'on ne peut pas changer


            #endregion

            #region Opérateur


            //Opérateur mathématiques:+,-,",*,/,%(modulo: reste de la division entière)
            Console.WriteLine("reste de la division de 10 par 3" + (10 % 3));

            //Opérateur combiné+=,-=,"=,/=
            myInt += 5;// myint + 5

            //Opérateur d'incrémentation et de décrémentation

            int val = 0;
            Console.WriteLine("Pré incrémentation" + (++val));// Incrémente val ensuite utilise sa valeur
            Console.WriteLine("Post incrémentation" + (val++));// utilise val ensuite l'incrémnte de 1
            Console.WriteLine(++val + val++);//6
            Console.WriteLine(6 + "5" + 2);//652
            Console.WriteLine(6 + 2 + "5");//85
            Console.WriteLine("6" + 5 + 2);//652

            //Opérateur de comparaison:==(égalité),<,>,<=,>=,!=(différent)


            //Opérareur logiques: && (et logique), ||(ou logique),!(non logique),^(ou exclusif)

            int v1 = 10, v2 = 15;
            Console.WriteLine((v1>v2)  &&  (v1<v2));
            


            Console.ReadLine();



            #endregion

            #region Convertion de types


            //Convertion implicite :concerne le passage d'un type inférieur à un type supérieur
            byte myByte = 10;
            int myInt3 = myByte;

            //Convertion explicite:passage d'un type sup à un type inf - risque de perte de données
            //Pour les convertion edxplicites on peut utiliser:
            //CAST:(int),(byte),(double)...
            
            int myInt4 = 20;
            byte myByte2 = (byte)myInt4;
            byte myByte3 = Convert.ToByte(myInt4);

            string chaine = "25";
            int myInt5 =Convert.ToInt32( chaine);
            int myInt6 = int.Parse(chaine);






            #endregion


            #region Conditions

            //Exprimer un tesst conditionnel: if(condition == vraie){instructions};else(instructions);}


            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb postitif");
            }
            else
            {
                Console.WriteLine("nb négatif");
            }


            //Switch: est une variante de la condition IF

            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:

                    Console.WriteLine("admis");
                    break;





            }

            //Opératzur ternaire

            int maVar = (10 < 5) ? 10 : 5; // maVar=5

            #endregion


            #region Boucles

            //Boucles conditionnelles:while,do while
            //Boucleitératiaves: For ,Foreach

            //For
            for(int i = 0;i>10; i++)
            {

                //Passer à l'itération suivante si==3

                if(i==3)
                {
                    continue;//saute l'itération
                }
                Console.WriteLine("passage n:" + i);

                //Quitter la boucle for si i=6
                if (i == 6)
                {
                    break;
                }
            }
            //Foreach
            int[] tab = { 1, 2, 3, 4 };
            foreach(int item in tab)// pour chaque int contenu dans ke tableau tab
            {
                Console.WriteLine(item);

                //While
                int valeur = 1;
                while (valeur<5)
                {
                    Console.WriteLine("Passage n :" + valeur);
                    valeur++;


                    //Do  While
                    do
                    {
                        Console.WriteLine("Passage n:" + valeur);
                        valeur++;
                    } while(valeur<10);


                }
            }

            #endregion


            #region Tableaux

            //tableau: un ensemble d'éléments typés

            //1 dimension

            //Déclaration d'un tableau
            int[] tableau = new int[3];// tableau  de 3 cases
            tableau[0] = 10;
            tableau[1] = 20;
            tableau[3] = 30;
            Console.WriteLine("Taille du tableau"+tableau.Length);//taille du tableau = 3

            //Parcours du tableau avec la boucle foreach
            foreach (int item in tableau)

            {
                Console.WriteLine(item);
            }


            // Parccours du tableau avefc la boucle for
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }


            //2ème façon de declarer un tableau
            int[] tableau2 = { 10, 20, 30 };

            //2 dimensions

            int[   ,  ] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            int[,] matrice2 = { { 10, 15, 58 }, { 12, 25, 32 } }; // autre façon de déclarer un tableau à 2 dimensions

            Console.WriteLine("Nombre de lignes de la matrice 2:" + matrice2.GetLength(0));//2
            Console.WriteLine("Nombre de colonne de la matrice 2:" + matrice2.GetLength(1));//3
            Console.WriteLine("Nombre total d'éléments de la matrice 2:" + matrice2.Length);//6
            Console.WriteLine("Nombre de dimensions de la matrice 2:" + matrice2.Rank);//2








            #endregion

            #region Méthode

            //Méthode: ensemble d'instruction réutilisables
            //Dans la programmation objet on a 2 types de méthodes:
            //Procédures: méthode qui ne renvoie aucune valeur(void)
            //Fonction : méthode qui renvoie une valeur ou un résultat renvoyé
            //Déclaration d'une méthode:Visibilité [mot-clé static) type_retout Nom_Méthode(paramètre) {instructions;}

            //quand la méthode n'est pas static il faut instancier pour l'utiliser dans une autre classe

            //   MesMethodes mm = new MesMethodes();
            //    mm.Somme(10, 20);

           int resultat= MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            MesMethodes.Afficher();

            int[] monTableau = { 10, 0, 20, 15 };

            MesMethodes.Afficher(monTableau);
            Console.WriteLine("Somme des éléments du tableau"+MesMethodes.Somme(monTableau));
            Console.WriteLine("La moyenne des éléments du tableau" + MesMethodes.Moyenne(monTableau));
            Console.WriteLine("L'élément lle plus petit du  tableau"+MesMethodes.Minimum(monTableau));

            //Appel de la méthode avec des params optionnels

            MesMethodes.SomeOptional(10, 20);// valeur par defaut de z qui est prise en comptes
            MesMethodes.SomeOptional(10, 20,50);

            int val1 = 10, val2 = 20;

            //Concaténation
            Console.WriteLine("concaténation: "+MesMethodes.Somme(val1,val2));


            //Interpolation 
            Console.WriteLine($"Avant permutaation: val1 = {val1}- val2={val2}");


            MesMethodes.Permuter(ref val1, ref val2);


            Console.WriteLine($"Après permutation val1 = {val1} -val2 ={val2}");

            //Appel de méthode avec des paramètre en sortie

            double sum = 0, moyenne = 0;
            double produit = MesMethodes.Calculer(10, 20, out sum, out moyenne);
            Console.WriteLine($"Produit={produit}");
            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"moyenne={moyenne}");




            //Appel de méthode avec un nombre de variable en arguments
            MesMethodes.Produit(10, 20);
            MesMethodes.Produit(10, 20,30);
            MesMethodes.Produit(10, 20,30,40);







            #endregion



            // Maintenir la console Active
            Console.ReadLine();

        }

    }


}

