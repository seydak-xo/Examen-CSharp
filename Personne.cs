using System;

namespace ProjetC
{
   
    public abstract class Personne
    {
     
        protected string nom;
        protected int age;

           public Personne(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

*        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public abstract void AfficherInfos();
    }
}
