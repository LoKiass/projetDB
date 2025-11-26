# ProjetDB – Exploration de Npgsql et PostgreSQL

**ProjetDB** est un projet réalisé dans le cadre d'un apprentissage approfondi de la **connexion à une base de données PostgreSQL** avec **.NET** et la bibliothèque **Npgsql**. L'objectif est de comprendre les mécanismes de base pour interagir avec une base de données relationnelle, gérer les connexions, et manipuler les données de manière sécurisée.

Ce projet a été développé par un étudiant pour **approfondir ses connaissances** en développement d'applications utilisant des bases de données.

---

## 🔧 Fonctionnalités
- **Connexion à PostgreSQL** : Utilisation de `NpgsqlDataSource` pour établir une connexion stable.
- **Gestion des erreurs** : Capture des exceptions spécifiques (`NpgsqlException`) et des erreurs applicatives.
- **Interface Windows Forms** : Affichage simple pour visualiser les interactions avec la base de données.
- **Libération des ressources** : Utilisation de `Dispose()` pour fermer proprement les connexions.

---

## 🛠 Technologies Utilisées
- **.NET (C#)**
- **Npgsql** (pour la connexion à PostgreSQL)
- **Windows Forms** (pour l'interface utilisateur)
- **System.Text.Json** (pour la gestion des données JSON, si applicable)

---

## 📂 Structure du Projet
- **`Program.cs`** : Point d'entrée de l'application. Initialise la connexion et lance l'interface principale.
- **`connection.cs`** : Classe dédiée à la configuration et à l'ouverture de la connexion.
- **`PagePrincipale.cs`** : Interface graphique principale (Windows Forms).

---

## 🚀 Prérequis
- **.NET SDK** (version compatible avec le projet)
- **PostgreSQL** (version 12 ou supérieure)
- **Npgsql** (à installer via NuGet : `dotnet add package Npgsql`)

---

## 📥 Installation
1. Clonez le dépôt :
   ```bash
   git clone https://github.com/votre-utilisateur/ProjetDB.git


Installez les dépendances :
bash
Copier

dotnet restore


Configurez la chaîne de connexion PostgreSQL dans connection.cs.
Lancez l'application :
bash
Copier

dotnet run


