using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        ///  Liste contenant les éléments de la Pile
        /// </summary>
        private List<T> elements;

        public Pile()
        {
            this.elements = new List<T>();
        }

        public bool PileVide()
        {
            return this.elements.Count <= 0;
        }

        public void Empiler(T valeur)
        {
            this.elements.Add(valeur);
        }

        public T Depiler()
        {
            if (PileVide())
            {
                throw new Exception("Impossible de dépiler, pile vide");
            }
            T valeur = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);
            return valeur;
        }

        public int Count { get => this.elements.Count; }
    }
}
