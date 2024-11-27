# Projet API et Frontend React

## Description

Ce projet est une application de liste de jeux, composée d'une API backend construite avec .NET et Entity Framework Core, et d'un frontend construit avec React. Le backend gère le stockage des données des jeux dans une base de données PostgreSQL, tandis que le frontend fournit une interface interactive pour visualiser et filtrer les détails des jeux.

---

## Fonctionnalités

- **API RESTful** utilisant .NET et Entity Framework Core.
- **Base de données PostgreSQL** pour le stockage.
- **Frontend React** avec Material React Table pour afficher les jeux de manière interactive.
- **Politique CORS** pour une communication sécurisée entre le backend et le frontend.

---

## Prérequis

- **.NET SDK 9**
- **Node.js et npm**
- **PostgreSQL**
- **Visual Studio Code** ou votre IDE préféré

---

## Installation et Configuration

### Installation Backend
1. Clonez le dépôt :

```bash
git clone <url>
cd GameBoard
```
2. Installez les dépendances .NET nécessaires :

```bash
dotnet restore
```

3. Configurez la chaîne de connexion à la base de données :
- Mettez à jour `appsettings.json` avec vos identifiants PostgreSQL :

```json
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=game_db;Username=your_username;Password=your_password"
  }
```

4. Créez la base de données et appliquez les migrations :

```bash
dotnet ef database update
```

5. Lancez l'API :
```bash
dotnet run
```
L'API devrait maintenant être disponible à http://localhost:5151.

### Installation Frontend
1. Naviguez vers le répertoire du frontend :

```bash
cd game-list
```
2. Installez les dépendances :

```bash
npm install
```
3. Lancez le frontend :

```bash
npm start
```
L'application React devrait maintenant être disponible à http://localhost:3000.
