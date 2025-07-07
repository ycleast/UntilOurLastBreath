using System;
using System.Collections.Generic;
using System.Threading;

// À compléter par chaque groupe dans des fichiers séparés

// Groupe A : Héritage

// Groupe B : Interfaces & Polymorphisme

// Groupe C : Structs

// Groupe D : Records

// Groupe E : Generics

// Groupe F : Temps & Événements

// Groupe G : Stock & Ressources

namespace JeuSurviePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le monde post-apocalyptique de Until Our Last Breath");
            Console.WriteLine("-----------------------------------------------------------------\n");

            // 🔹 Groupe D - Apparence personnalisée
            // ApparenceJoueur apparence = new ApparenceJoueur("Bruns", "Verts", "Armure lourde");

            // 🔹 Groupe A - Création des personnages
            // Personnage eron = new Soldat("Eron", 100, new Position(0, 0));
            // Personnage medecin = new Medecin("Clara", 80, new Position(1, 2));

            // 🔹 Groupe C - Déplacement
            // eron.Marcher(new Position(2, 3));
            // Console.WriteLine($"Eron se déplace vers {eron.Position}");

            // 🔹 Groupe B - Combat & Actions polymorphes
            // List<IActionsCombat> ennemis = new List<IActionsCombat> { new Sniper("Sniper1"), new Soldat("Soldat1") };
            // foreach (var ennemi in ennemis)
            // {
            //     ExecuterAction(ennemi); // Appelle Tirer() et Esquiver() via interface
            // }

            // 🔹 Groupe E - Inventaire générique
            // Inventaire<Objet> inventaire = new Inventaire<Objet>();
            // inventaire.AjouterObjet(new Arme("Fusil", 50));
            // inventaire.AjouterObjet(new TrousseDeSoins("Kit Médical", 30));
            // inventaire.AfficherContenu();

            // 🔹 Groupe G - Stock Global
            StockGlobal stock = new StockGlobal();
            stock.AjouterQuantite("Eau", 5);
            stock.AjouterQuantite("Munitions", 10);
            stock.UtiliserRessource("Eau", 2);
            stock.AfficherStock();

            // 🔹 Groupe F - Événements aléatoires et gestion du temps
            // EvenementAleatoire.Generate(); // Affiche un ennemi ou bonus aléatoire
            // Console.WriteLine("⏳ Temps de repos...");
            // Thread.Sleep(2000); // Simule l’attente d’une action

            Console.WriteLine("\n🎮 Fin de la simulation de test.");
        }

        // Groupe B - Exemple d’exécution polymorphe
        // static void ExecuterAction(IActionsCombat combattant)
        // {
        //     combattant.Tirer();
        //     combattant.Esquiver();
        // }
    }
}
