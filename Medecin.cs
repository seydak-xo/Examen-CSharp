using System;

namespace ProjetC
{

    public class Medecin : PersonnelMedical
    {
        private string specialite;

    
        public Medecin(string nom, int age, string matriculeProfessionnel, string specialite) 
            : base(nom, age, matriculeProfessionnel)
        {
            this.specialite = specialite;
        }

        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public override void AfficherInfos()
        {
            Console.WriteLine($" MÉDECIN ");
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Âge: {Age} ans");
            Console.WriteLine($"Matricule professionnel: {MatriculeProfessionnel}");
            Console.WriteLine($"Spécialité: {specialite}");
            Console.WriteLine();
        }
    }
}
