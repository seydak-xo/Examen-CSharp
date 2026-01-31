using System;
using System.Collections.Generic;

namespace ProjetC
{
  
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> personnes = new List<Personne>();
            List<DossierMedical> dossiersMedicaux = new List<DossierMedical>();
            List<Consultation> consultations = new List<Consultation>();

            InitialiserDonneesExemple(personnes, dossiersMedicaux, consultations);

            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        bool continuerAjoutPatient = true;
                        while (continuerAjoutPatient)
                        {
                            AjouterPatient(personnes);
                            continuerAjoutPatient = DemanderContinuerAction("ajouter un autre patient");
                        }
                        break;
                    case "2":
                        bool continuerAjoutPersonnel = true;
                        while (continuerAjoutPersonnel)
                        {
                            AjouterPersonnelMedical(personnes);
                            continuerAjoutPersonnel = DemanderContinuerAction("ajouter un autre membre du personnel médical");
                        }
                        break;
                    case "3":
                        bool continuerDossier = true;
                        while (continuerDossier)
                        {
                            
                            CreerDossierMedical(personnes, dossiersMedicaux);
                            continuerDossier = DemanderContinuerAction("créer un autre dossier médical");
                        }
                        break;
                    case "4":
                        bool continuerConsultation = true;
                        while (continuerConsultation)
                        {
                            CreerConsultation(personnes, dossiersMedicaux, consultations);
                            continuerConsultation = DemanderContinuerAction("créer une autre consultation");
                        }
                        break;
                    case "5":
                        AfficherListePersonnes(personnes);
                        break;
                    case "6":
                        AfficherConsultations(consultations);
                        break;
                    case "7":
                        continuer = false;
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }

                if (continuer)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static bool DemanderContinuerAction(string action)
        {
            Console.WriteLine("\n═══════════════════════════════════════════════════════");
            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("1. Retourner au menu principal");
            Console.WriteLine($"2. {action.Substring(0, 1).ToUpper() + action.Substring(1)}");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.Write("Votre choix : ");
            
            string choix = Console.ReadLine();
            
            if (choix == "1")
            {
                return false;
            }
            else if (choix == "2")
            {
                Console.Clear();
                return true; 
            }
            else
            {
                Console.WriteLine("Choix invalide. Retour au menu principal.");
                return false;
            }
        }

      
        static void AfficherMenu()
        {
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine("        GESTION D'UN CENTRE DE SANTÉ");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine("1. Ajouter un patient");
            Console.WriteLine("2. Ajouter un médecin ou un infirmier");
            Console.WriteLine("3. Créer un dossier médical");
            Console.WriteLine("4. Créer une consultation");
            Console.WriteLine("5. Afficher la liste des personnes");
            Console.WriteLine("6. Afficher les consultations");
            Console.WriteLine("7. Quitter le programme");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.Write("Votre choix : ");
        }

        static void InitialiserDonneesExemple(List<Personne> personnes, List<DossierMedical> dossiers, List<Consultation> consultations)
        {
            Patient patient1 = new Patient("Ibliss Samba", 20, "DOS-001");
            Patient patient2 = new Patient("Aziz Diop", 19, "DOS-002");
            personnes.Add(patient1);
            personnes.Add(patient2);

            
            Medecin medecin1 = new Medecin("Dr.Seyda", 20, "MAT-MED-001", "Cardiologie");
            Infirmier infirmier1 = new Infirmier("Aissa", 28, "MAT-INF-001", "Urgences");
            personnes.Add(medecin1);
            personnes.Add(infirmier1);

            DossierMedical dossier1 = new DossierMedical("Hypertension artérielle", "Médicaments antihypertenseurs");
            DossierMedical dossier2 = new DossierMedical("Fracture du poignet", "Plâtre et repos");
            dossiers.Add(dossier1);
            dossiers.Add(dossier2);

            Consultation consultation1 = new Consultation(patient1, medecin1, dossier1, DateTime.Now.AddDays(-5));
            consultations.Add(consultation1);
        }

      
        static void AjouterPatient(List<Personne> personnes)
        {
            Console.WriteLine("\n Ajout d'un patient ");
            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Âge : ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.Write("Numéro de dossier médical : ");
                string numeroDossier = Console.ReadLine();

                Patient nouveauPatient = new Patient(nom, age, numeroDossier);
                personnes.Add(nouveauPatient);
                Console.WriteLine("\n Patient ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Erreur : L'âge doit être un nombre entier.");
            }
        }

     
        static void AjouterPersonnelMedical(List<Personne> personnes)
        {
            Console.WriteLine("\nAjout d'un membre du personnel médical");
            Console.WriteLine("1. Médecin");
            Console.WriteLine("2. Infirmier");
            Console.Write("Votre choix : ");
            string type = Console.ReadLine();

            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Âge : ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.Write("Matricule professionnel : ");
                string matricule = Console.ReadLine();

                if (type == "1")
                {
                    Console.Write("Spécialité : ");
                    string specialite = Console.ReadLine();
                    Medecin nouveauMedecin = new Medecin(nom, age, matricule, specialite);
                    personnes.Add(nouveauMedecin);
                    Console.WriteLine("\n Médecin ajouté avec succès !");
                }
                else if (type == "2")
                {
                    Console.Write("Service : ");
                    string service = Console.ReadLine();
                    Infirmier nouvelInfirmier = new Infirmier(nom, age, matricule, service);
                    personnes.Add(nouvelInfirmier);
                    Console.WriteLine("\n Infirmier ajouté avec succès !");
                }
                else
                {
                    Console.WriteLine("Erreur : Choix invalide.");
                }
            }
            else
            {
                Console.WriteLine("Erreur : L'âge doit être un nombre entier.");
            }
        }

        static void CreerDossierMedical(List<Personne> personnes, List<DossierMedical> dossiers)
        {
            Console.WriteLine("\n Création d'un dossier médical");
            Console.Write("Entrez le numéro de dossier du patient : ");
            string idCherche = Console.ReadLine();

            Patient patientTrouve = null;
            foreach (Personne p in personnes)
            {
                if (p is Patient pat && pat.NumeroDossierMedical == idCherche)
                {
                    patientTrouve = pat;
                    break;
                }
            }

            if (patientTrouve != null)
            {
                Console.WriteLine($"Patient trouvé : {patientTrouve.Nom}");
                Console.Write("Diagnostic : ");
                string diagnostic = Console.ReadLine();

                Console.Write("Traitement : ");
                string traitement = Console.ReadLine();

                DossierMedical nouveauDossier = new DossierMedical(diagnostic, traitement);
                dossiers.Add(nouveauDossier);
                Console.WriteLine($"\n Dossier médical créé avec succès pour {patientTrouve.Nom} !");
            }
            else
            {
                Console.WriteLine("Erreur : Aucun patient trouvé avec cet ID.");
            }
        }

       
        static void CreerConsultation(List<Personne> personnes, List<DossierMedical> dossiers, List<Consultation> consultations)
        {
            Console.WriteLine("\nCréation d'une consultation");

            List<Patient> patients = new List<Patient>();
            foreach (Personne p in personnes)
            {
                if (p is Patient patient)
                {
                    patients.Add(patient);
                }
            }

            if (patients.Count == 0)
            {
                Console.WriteLine("Erreur : Aucun patient disponible. Veuillez d'abord ajouter un patient.");
                return;
            }

            Console.WriteLine("\nPatients disponibles :");
            for (int i = 0; i < patients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {patients[i].Nom} (Dossier: {patients[i].NumeroDossierMedical})");
            }
            Console.Write("Choisissez un patient (numéro) : ");
            if (int.TryParse(Console.ReadLine(), out int indexPatient) && indexPatient > 0 && indexPatient <= patients.Count)
            {
                Patient patientSelectionne = patients[indexPatient - 1];

               
                List<Medecin> medecins = new List<Medecin>();
                foreach (Personne p in personnes)
                {
                    if (p is Medecin medecin)
                    {
                        medecins.Add(medecin);
                    }
                }

                if (medecins.Count == 0)
                {
                    Console.WriteLine("Erreur : Aucun médecin disponible. Veuillez d'abord ajouter un médecin.");
                    return;
                }

                Console.WriteLine("\nMédecins disponibles :");
                for (int i = 0; i < medecins.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {medecins[i].Nom} - {medecins[i].Specialite}");
                }
                Console.Write("Choisissez un médecin (numéro) : ");
                if (int.TryParse(Console.ReadLine(), out int indexMedecin) && indexMedecin > 0 && indexMedecin <= medecins.Count)
                {
                    Medecin medecinSelectionne = medecins[indexMedecin - 1];

                   
                    if (dossiers.Count == 0)
                    {
                        Console.WriteLine("Erreur : Aucun dossier médical disponible. Veuillez d'abord créer un dossier médical.");
                        return;
                    }

                    Console.WriteLine("\nDossiers médicaux disponibles :");
                    for (int i = 0; i < dossiers.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Diagnostic: {dossiers[i].Diagnostic}");
                    }
                    Console.Write("Choisissez un dossier médical (numéro) : ");
                    if (int.TryParse(Console.ReadLine(), out int indexDossier) && indexDossier > 0 && indexDossier <= dossiers.Count)
                    {
                        DossierMedical dossierSelectionne = dossiers[indexDossier - 1];

                        Console.Write("Date de consultation (format: jj/mm/aaaa) ou appuyez sur Entrée pour la date actuelle : ");
                        string dateInput = Console.ReadLine();
                        DateTime dateConsultation;

                        if (string.IsNullOrWhiteSpace(dateInput))
                        {
                            dateConsultation = DateTime.Now;
                        }
                        else if (DateTime.TryParse(dateInput, out dateConsultation))
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Format de date invalide. Utilisation de la date actuelle.");
                            dateConsultation = DateTime.Now;
                        }

                        Consultation nouvelleConsultation = new Consultation(
                            patientSelectionne,
                            medecinSelectionne,
                            dossierSelectionne,
                            dateConsultation
                        );

                        consultations.Add(nouvelleConsultation);
                        Console.WriteLine("\nConsultation créée avec succès !");
                    }
                    else
                    {
                        Console.WriteLine("Erreur : Numéro de dossier médical invalide.");
                    }
                }
                else
                {
                    Console.WriteLine("Erreur : Numéro de médecin invalide.");
                }
            }
            else
            {
                Console.WriteLine("Erreur : Numéro de patient invalide.");
            }
        }

            static void AfficherListePersonnes(List<Personne> personnes)
{
    if (personnes.Count == 0)
    {
        Console.WriteLine("\nAucune personne enregistrée.");
        return;
    }

    Console.WriteLine("\n═══════════════════════════════════════════════════════");
    Console.WriteLine("           OPTIONS D'AFFICHAGE DES PERSONNES");
    Console.WriteLine("═══════════════════════════════════════════════════════");
    Console.WriteLine("1. Afficher les patients");
    Console.WriteLine("2. Afficher les infirmiers");
    Console.WriteLine("3. Afficher les médecins");
    Console.WriteLine("4. Retour au menu principal");
    Console.WriteLine("═══════════════════════════════════════════════════════");
    Console.Write("Votre choix : ");

    string choix = Console.ReadLine();
    bool trouve = false;

    Console.Clear();

    switch (choix)
    {
        case "1":
            Console.WriteLine("--- LISTE DES PATIENTS ---");
            foreach (var p in personnes)
            {
                if (p is Patient) { p.AfficherInfos(); trouve = true; }
            }
            if (!trouve) Console.WriteLine("Aucun patient enregistré.");
            break;

        case "2":
            Console.WriteLine("--- LISTE DES INFIRMIERS ---");
            foreach (var p in personnes)
            {
                if (p is Infirmier) { p.AfficherInfos(); trouve = true; }
            }
            if (!trouve) Console.WriteLine("Aucun infirmier enregistré.");
            break;

        case "3":
            Console.WriteLine("--- LISTE DES MÉDECINS ---");
            foreach (var p in personnes)
            {
                if (p is Medecin) { p.AfficherInfos(); trouve = true; }
            }
            if (!trouve) Console.WriteLine("Aucun médecin enregistré.");
            break;

        case "4":
            return; 

        default:
            Console.WriteLine("Choix invalide.");
            break;
    }
}

      
        static void AfficherConsultations(List<Consultation> consultations)
        {
            if (consultations.Count == 0)
            {
                Console.WriteLine("\n Aucune consultation enregistrée.");
                return;
            }

            Console.WriteLine("\n═══════════════════════════════════════════════════════");
            Console.WriteLine("           OPTIONS D'AFFICHAGE DES CONSULTATIONS");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine("1. Rechercher par nom du patient");
            Console.WriteLine("2. Rechercher par numéro de dossier médical");
            Console.WriteLine("3. Afficher toutes les consultations");
            Console.WriteLine("4. Retour au menu principal");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.Write("Votre choix : ");
            
            string choixRecherche = Console.ReadLine();
            bool trouve = false;

            switch (choixRecherche)
            {
                case "1": 
                    Console.Write("\nEntrez le nom du patient : ");
                    string nomRecherche = Console.ReadLine().ToLower();
                    Console.WriteLine("\n--- Résultats de la recherche ---");
                    foreach (var c in consultations)
                    {
                        if (c.Patient.Nom.ToLower().Contains(nomRecherche))
                        {
                            c.AfficherInfos();
                            trouve = true;
                        }
                    }
                    if (!trouve) Console.WriteLine("Aucun patient trouvé avec ce nom.");
                    break;

                case "2": 
                    Console.Write("\nEntrez le numéro de dossier médical : ");
                    string numDossier = Console.ReadLine().ToLower();
                    Console.WriteLine("\n--- Résultats de la recherche ---");
                    foreach (var c in consultations)
                    {
                        if (c.Patient.NumeroDossierMedical.ToLower() == numDossier)
                        {
                            c.AfficherInfos();
                            trouve = true;
                        }
                    }
                    if (!trouve) Console.WriteLine("Aucun dossier correspondant trouvé.");
                    break;

                case "3": 
                    foreach (Consultation consultation in consultations)
                    {
                        consultation.AfficherInfos();
                    }
                    break;

                case "4": 
                    return;

                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }
    }
}