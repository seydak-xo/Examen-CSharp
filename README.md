# Projet C# - Gestion d'un Centre de Santé

## Description

Application console en C# permettant de gérer des informations médicales dans un centre de santé. Ce projet met en pratique les concepts fondamentaux de la Programmation Orientée Objet (POO) :
- Abstraction
- Héritage
- Polymorphisme
- Encapsulation
- Collaboration entre classes

## Structure du Projet

Le projet est organisé en plusieurs classes :

- **Personne.cs** : Classe abstraite de base représentant une personne
- **Patient.cs** : Classe représentant un patient (hérite de Personne)
- **PersonnelMedical.cs** : Classe représentant le personnel médical (hérite de Personne)
- **Medecin.cs** : Classe représentant un médecin (hérite de PersonnelMedical)
- **Infirmier.cs** : Classe représentant un infirmier (hérite de PersonnelMedical)
- **DossierMedical.cs** : Classe représentant un dossier médical
- **Consultation.cs** : Classe représentant une consultation médicale
- **Program.cs** : Programme principal avec menu interactif

## Prérequis

- .NET SDK 6.0 ou supérieur
- Un environnement de développement C# (Visual Studio, Visual Studio Code avec extension C# Dev Kit, ou éditeur de texte avec terminal)

## Compilation

### Avec Visual Studio
1. Ouvrez le fichier `ProjetC.csproj` dans Visual Studio
2. Appuyez sur `F5` pour compiler et exécuter, ou `Ctrl+Shift+B` pour compiler uniquement

### Avec Visual Studio Code
1. Ouvrez le dossier du projet dans VS Code
2. Ouvrez le terminal intégré (Ctrl+`)
3. Exécutez la commande :
```bash
dotnet build
```

### Avec le terminal (ligne de commande)
1. Ouvrez un terminal dans le dossier du projet
2. Exécutez la commande :
```bash
dotnet build
```

## Exécution

### Avec Visual Studio
Appuyez sur `F5` ou cliquez sur le bouton "Exécuter"

### Avec Visual Studio Code
Dans le terminal intégré, exécutez :
```bash
dotnet run
```

### Avec le terminal (ligne de commande)
Dans le dossier du projet, exécutez :
```bash
dotnet run
```

## Utilisation du Menu

Au lancement, le programme affiche un menu interactif avec les options suivantes :

### 1. Ajouter un patient
Permet d'ajouter un nouveau patient au système. Vous devrez fournir :
- Le nom du patient
- L'âge du patient
- Le numéro de dossier médical

### 2. Ajouter un médecin ou un infirmier
Permet d'ajouter un membre du personnel médical. Vous devrez :
- Choisir entre médecin ou infirmier
- Fournir le nom, l'âge et le matricule professionnel
- Pour un médecin : indiquer la spécialité
- Pour un infirmier : indiquer le service

### 3. Créer un dossier médical
Permet de créer un nouveau dossier médical avec :
- Le diagnostic
- Le traitement prescrit

### 4. Créer une consultation
Permet de créer une consultation en associant :
- Un patient (parmi ceux disponibles)
- Un médecin (parmi ceux disponibles)
- Un dossier médical (parmi ceux disponibles)
- Une date de consultation (ou la date actuelle par défaut)

### 5. Afficher la liste des personnes
Affiche toutes les personnes enregistrées (patients, médecins, infirmiers) en utilisant le polymorphisme. Chaque type de personne affiche ses informations spécifiques.

### 6. Afficher les consultations
Affiche toutes les consultations créées avec leurs détails complets.

### 7. Quitter le programme
Termine l'application.

## Données d'Exemple

Le programme est initialisé avec quelques données d'exemple pour faciliter la démonstration :
- 2 patients
- 1 médecin et 1 infirmier
- 2 dossiers médicaux
- 1 consultation

## Concepts POO Utilisés

### Abstraction
- La classe `Personne` est abstraite et ne peut pas être instanciée directement
- Méthode abstraite `AfficherInfos()` qui doit être implémentée par les classes dérivées

### Héritage
- `Patient` hérite de `Personne`
- `PersonnelMedical` hérite de `Personne`
- `Medecin` et `Infirmier` héritent de `PersonnelMedical`

### Polymorphisme
- Utilisation de `List<Personne>` pour stocker différents types de personnes
- Appel de `AfficherInfos()` sur chaque objet, chaque classe affichant ses informations spécifiques

### Encapsulation
- Tous les attributs sont privés (`private`)
- Accès aux données uniquement via des propriétés (getters/setters)
- Aucun accès direct aux attributs privés depuis l'extérieur des classes

### Collaboration entre classes
- La classe `Consultation` utilise des objets `Patient`, `Medecin` et `DossierMedical`
- Les classes collaborent pour former un système cohérent

## Notes Techniques

- Le projet utilise C# 9+ avec .NET 6.0
- Toutes les classes respectent les principes de la POO
- Le code est commenté pour faciliter la compréhension
- Aucune variable globale n'est utilisée (les listes sont dans la méthode Main)
- Le menu fonctionne dans une boucle jusqu'à ce que l'utilisateur choisisse de quitter

## Auteur

Projet réalisé dans le cadre d'un cours de Programmation Orientée Objet en C#.
