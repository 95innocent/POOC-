using System;
namespace ExercicePoo.src
{
    /*class Cercle: Forme
    {
        public double Rayon{get;set;}
        public Cercle(string getCouleur,double getRayon):base(getCouleur)
        {
            Rayon=getRayon;
        }
          public override string tostring()
         {
         return $"C'est une cercle de couleur {Couleur} et de Rayon {Rayon}";
         }
          }*/
        //  //abstraction
        class Cercle: Forme
    {
        public double Rayon{get;set;}
        public Cercle(string getCouleur,double getRayon):base(getCouleur)
        {
            Rayon=getRayon;
        }
          public override string Tostring()
         {
         return $"C'est une cercle de couleur {Couleur} et de Rayon {Rayon}";
         }
         public override double surface()
         {
           return Math.Pow(Rayon,2)=Math.PI
         }
    }
}
