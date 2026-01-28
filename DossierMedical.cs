using System;

namespace ProjetC
{
    public class DossierMedical
    {
        private string diagnostic;
        private string traitement;

        
        public DossierMedical(string diagnostic, string traitement)
        {
            this.diagnostic = diagnostic;
            this.traitement = traitement;
        }

        public string Diagnostic
        {
            get { return diagnostic; }
            set { diagnostic = value; }
        }

        public string Traitement
        {
            get { return traitement; }
            set { traitement = value; }
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Diagnostic: {diagnostic}");
            Console.WriteLine($"Traitement: {traitement}");
        }
    }
}
