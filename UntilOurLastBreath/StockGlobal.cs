using System;
using System.Collections.Generic;

namespace JeuSurviePOO
{
    public class StockGlobal
    {
        public List<string> FournituresDisponibles;
        public Dictionary<string, int> QuantitesRessources;

        public StockGlobal()
        {
            FournituresDisponibles = new List<string>();
            QuantitesRessources = new Dictionary<string, int>();
        }

        public void AjouterFourniture(string item)
        {
            if (!FournituresDisponibles.Contains(item))
            {
                FournituresDisponibles.Add(item);
                Console.WriteLine($"{item} ajouté à la liste des fournitures.");
            }
        }

        public void AjouterQuantite(string item, int quantite)
        {
            if (!FournituresDisponibles.Contains(item))
            {
                AjouterFourniture(item);
            }

            if (QuantitesRessources.ContainsKey(item))
            {
                QuantitesRessources[item] += quantite;
            }
            else
            {
                QuantitesRessources[item] = quantite;
            }

            Console.WriteLine($"{quantite} unités de {item} ajoutées au stock.");
        }

        public void UtiliserRessource(string item, int quantite)
        {
            if (QuantitesRessources.ContainsKey(item) && QuantitesRessources[item] >= quantite)
            {
                QuantitesRessources[item] -= quantite;
                Console.WriteLine($"{quantite} unités de {item} utilisées.");
            }
            else
            {
                Console.WriteLine($"Impossible d'utiliser {quantite} unités de {item} (stock insuffisant ou inexistant).");
            }
        }

        public void AfficherStock()
        {
            Console.WriteLine("\nStock actuel :");
            foreach (string item in FournituresDisponibles)
            {
                int quantite = QuantitesRessources.ContainsKey(item) ? QuantitesRessources[item] : 0;
                Console.WriteLine($"- {item} : {quantite} unité(s)");
            }
        }
    }
}
