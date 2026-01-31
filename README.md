# Gestion d'un Centre de Santé

Projet C# - Application console pour gérer un centre de santé (patients, médecins, infirmiers, dossiers médicaux, consultations).

## Fichiers du projet

- **Personne.cs** - Classe abstraite de base (nom, âge)
- **Patient.cs** - Hérite de Personne, a un numéro de dossier
- **PersonnelMedical.cs** - Hérite de Personne, a un matricule
- **Medecin.cs** - Hérite de PersonnelMedical, a une spécialité
- **Infirmier.cs** - Hérite de PersonnelMedical, a un service
- **DossierMedical.cs** - Diagnostic et traitement
- **Consultation.cs** - Lie un patient, un médecin et un dossier avec une date
- **Program.cs** - Le main avec le menu

## Ce que fait le programme

Au démarrage il y a déjà des données d'exemple (2 patients, 1 médecin, 1 infirmier, 2 dossiers, 1 consultation).

Le menu permet de :
1. Ajouter des patients
2. Ajouter des médecins ou infirmiers
3. Créer des dossiers médicaux (en cherchant le patient par son numéro de dossier)
4. Créer des consultations (on choisit le patient, le médecin, le dossier et la date)
5. Afficher les personnes (avec un sous-menu pour voir patients, infirmiers ou médecins)
6. Afficher les consultations (on peut chercher par nom de patient ou par numéro de dossier)
7. Quitter

Après chaque ajout on peut choisir d'en ajouter un autre ou de revenir au menu.

## POO utilisé

- **Abstraction** : Personne est abstraite avec AfficherInfos() abstrait
- **Héritage** : Patient et PersonnelMedical héritent de Personne, Medecin et Infirmier héritent de PersonnelMedical
- **Polymorphisme** : Une `List<Personne>` pour stocker tout le monde, chaque classe a son AfficherInfos()
- **Encapsulation** : Attributs privés, propriétés pour y accéder
- **Collaboration** : Consultation utilise Patient, Medecin et DossierMedical

## Pour lancer

```bash
dotnet build
dotnet run
```

Ou ouvrir le .sln dans Visual Studio et F5.
