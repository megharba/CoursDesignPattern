# Design Pattern C# :

## Création projet .NET console

dotnet new console -o consoleApp

## Lancer l'application consoleApp

dotnet run 

Design Pattern Théorie : 

DP --> rôle optimiser les solutions et répondre à des besoins spé 
   --> Bonne pratique utiliser 

MVC <-> Model Vue Controller 
Singleton <-> Angular one instance

![Alt-text](image.png)

## Description des Patterns

-name
-desc
-exemple de code sous forme de diagramme UML
-la structure standard (abstraite)
-exemple de code 

## Cas concret d'etudes pour ce cours 

Nous allons prendre en exemple le cas d'une societe qui vend des vehicules en ligne

## Première grande famille de Design Pattern : les patterns de construction 


-la façon de crée des obj/classe normalisé des classe par le bias d'interface pour interagir "avec un seul instance par exempleavec singleton"  


### Le pattern Abstract Factory :

 -objectif fournir une interface pour créer des familles d'objets liés sans spécifier leurs classes concrètes.

 - exemple :  Catalogue -- une instance qui va implémenté une instance de Fabrique vehicule (Famille d'objet) -1-> FabriqueVehicule <- (scooter,..)

 ![Alt-text](image2.png)

 ### Le pattern Builder :

 -Il permet de construire des objets complexes étape par étape, en séparant la construction/implémentation de l'objet final de sa représentation.

 ![Alt-text](image3.png)

 ### Le pattern Factory Method :

 Le pattern Factory Method est un pattern qui permet de déléguer la création d'objets à des sous-classes. Il définit une interface commune pour créer des objets, mais laisse les sous-classes décider quelles classes concrètes instancier.

 -exemple : gestion ligne de fabrication 

 ![Alt-text](image4.png)

  ### Le pattern Singleton :

  2 choses pour mettre en place le pattern singleton :
       - une classe ne doit possédé qu'une seul instance 
       - il faut créer une methode de classe qui permet de fournir cette unique instance 
à noté : ce pattern est applicable à d'autre pattern  

  ### Le pattern Prototype  :
  
Le pattern prototype est un modèle de conception qui permet de créer de nouvelles instances d'un objet en copiant un objet existant, plutôt qu'en le recréant à partir de zéro. Cela permet d'économiser du temps et des ressources en évitant de recréer manuellement chaque aspect de l'objet.