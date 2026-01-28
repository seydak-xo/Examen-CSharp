using System;

namespace ProjetC
{
   
    public class Consultation
    {
        private Patient patient;
        private Medecin medecin;
        private DossierMedical dossierMedical;
        private DateTime dateConsultation;

        public Consultation(Patient patient, Medecin medecin, DossierMedical dossierMedical, DateTime dateConsultation)
        {
            this.patient = patient;
            this.medecin = medecin;
            this.dossierMedical = dossierMedical;
            this.dateConsultation = dateConsultation;
        }

        public Patient Patient
        {
            get { return patient; }
            set { patient = value; }
        }

        public Medecin Medecin
        {
            get { return medecin; }
            set { medecin = value; }
        }

        public DossierMedical DossierMedical
        {
            get { return dossierMedical; }
            set { dossierMedical = value; }
        }

        public DateTime DateConsultation
        {
            get { return dateConsultation; }
            set { dateConsultation = value; }
        }

        public void AfficherInfos()
        {
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine("                    CONSULTATION MÉDICALE");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine($"Date: {dateConsultation:dd/MM/yyyy HH:mm}");
            Console.WriteLine();
            Console.WriteLine(" Patient ");
            patient.AfficherInfos();
            Console.WriteLine(" Médecin");
            medecin.AfficherInfos();
            Console.WriteLine(" Dossier Médical");
            dossierMedical.AfficherInfos();
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine();
        }
    }
}
