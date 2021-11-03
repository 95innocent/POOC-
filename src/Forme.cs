using System;
namespace ExercicePoo.src
{
    /*class Forme
    {
        //1 2 public string couleur="Rouge"
        //2 creation d'un constructeur en c#
       /* private string couleur;
       
        public Forme(string getCouleur)
        {          
           couleur=getCouleur;
        }
        public string getCouleur()
        {
            return couleur;
        }
         public void setCouleur(string value)
        {
            couleur=value;
        }*/
        //les constructeurs avecparametre
        // private string couleur;
        //3polmorphisme
       /* public virtual string Couleur{get;set;}
        
        public Forme(string getCouleur)
        {          
           Couleur=getCouleur;
        }
        public string getCouleur()
        {
            return Couleur;
        }
         public virtual string tostring()
        {
        return $"C'est une forme de couleur {Couleur}";
        }
       
    }*/
    abstract class Forme
    {
        
        
        public Forme(string getCouleur)
        {          
           Couleur=getCouleur;
        }
        public string getCouleur()
        {
            return Couleur;
        }
         public abstract string tostring()
         public abstract string surface()
        {
        return $"C'est une forme de couleur {Couleur}";
        }
    }
}