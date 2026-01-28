using System;

namespace ProjetC
{
    public class Infirmier : PersonnelMedical
    {
        private string service;

        
        public Infirmier(string nom, int age, string matriculeProfessionnel, string service) 
            : base(nom, age, matriculeProfessionnel)
        {
            this.service = service;
        }

    
        public string Service
        {
            get { return service; }
            set { service = value; }
        }

    
        public override void AfficherInfos()
        {
            Console.WriteLine($"=== INFIRMIER ===");
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Âge: {Age} ans");
            Console.WriteLine($"Matricule professionnel: {MatriculeProfessionnel}");
            Console.WriteLine($"Service: {service}");
            Console.WriteLine();
        }
    }
}
