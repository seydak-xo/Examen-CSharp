using System;

namespace ProjetC
{
   
    public class PersonnelMedical : Personne
    {
        private string matriculeProfessionnel;

        public PersonnelMedical(string nom, int age, string matriculeProfessionnel) 
            : base(nom, age)
        {
            this.matriculeProfessionnel = matriculeProfessionnel;
        }

        public string MatriculeProfessionnel
        {
            get { return matriculeProfessionnel; }
            set { matriculeProfessionnel = value; }
        }

        public override void AfficherInfos()
        {
            Console.WriteLine($"=== PERSONNEL MÉDICAL ===");
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Âge: {age} ans");
            Console.WriteLine($"Matricule professionnel: {matriculeProfessionnel}");
        }
    }
}
