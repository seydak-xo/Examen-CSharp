using System;

namespace ProjetC
{
    
    public class Patient : Personne
    {
        private string numeroDossierMedical;

        public Patient(string nom, int age, string numeroDossierMedical) 
            : base(nom, age)
        {
            this.numeroDossierMedical = numeroDossierMedical;
        }

       
        public string NumeroDossierMedical
        {
            get { return numeroDossierMedical; }
            set { numeroDossierMedical = value; }
        }

        public override void AfficherInfos()
        {
            Console.WriteLine($" PATIENT ");
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Âge: {age} ans");
            Console.WriteLine($"Numéro de dossier médical: {numeroDossierMedical}");
            Console.WriteLine();
        }
    }
}
