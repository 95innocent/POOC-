using System;
using ExercicePoo.src;
namespace ExercicePoo
{
    class Program
    {
        //1public string nom="Christa";
        static void Main(string[] args)
        {
            //1Program p=new Program();
           //1 Console.WriteLine(p.nom);
           /*1.2 Forme f1=new Forme();
            Console.WriteLine(f1.couleur);*/
            //2 les constructeur
            /*Forme f1=new Forme("blue");
            Console.WriteLine(f1.getCouleur());
             Console.WriteLine("---Changement--");
             f1.setCouleur("Rouge");
              Console.WriteLine(f1.getCouleur());*/
             //3 Forme f1=new Forme("blue");
              //Forme f2=new Forme();
             //3 Forme r1=new Rectangle("violet",30,20);
             //3Console.WriteLine("Forme:{0}",f1.tostring());
            //3 Console.WriteLine("Rectangle:{0}",r1.tostring());
            //  Console.WriteLine("Couleur f2:{0}",f2.Couleur);
            //  Console.WriteLine("---Changement--");
            //  f1.Couleur("Rouge");
            //   Console.WriteLine(f1.Couleur);
            //abstraite
            Forme r1=new Rectangle("violet",30,20);
            Cercle c1=new Cercle ("noir",10);

        }
    }
}
