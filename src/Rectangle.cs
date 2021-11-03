using System;
namespace ExercicePoo.src
{ 
    /*class Rectangle : Forme 
    {
    public override string Couleur{get;set;}
    public double Longueur{get;set;}
    public double Largeur{get;set;}
    public Rectangle(string getCouleur1,double getLongueur,double getLargeur):
    base(getCouleur1)
    {
        Longueur=getLongueur;
        Largeur=getLargeur;
       // Couleur="Couleur file";
    }
    public override string tostring()
    {
        return $"C'est une forme de couleur {Couleur},de longueur {Longueur},de largeur {Largeur}";
    }
        
    }*/
    class Rectangle : Forme 
    {
    public override string Couleur{get;set;}
    public double Longueur{get;set;}
    public double Largeur{get;set;}
    public Rectangle(string getCouleur1,double getLongueur,double getLargeur):
    base(getCouleur1)
    {
        Longueur=getLongueur;
        Largeur=getLargeur;
       // Couleur="Couleur file";
    }
    public override string tostring()
    {
        return $"C'est une rectangle de couleur {Couleur} et de rayon {Longueur},de largeur {Largeur}";
    }
        
    }
    
   
}