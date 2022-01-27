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
        /// Nombre maximum d'élements de la Pile
        /// </summary>

        /// <summary>
        ///  Liste contenant les éléments de la Pile
        /// </summary>
        private List<int> elements;

        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }

        public bool PileVide()
        {
            return this.elements.Count <= 0;
        }

        public void Empiler(T val)
        {
            this.elements.Add(val);
        }

        public int Depiler()
        {

            if (PileVide())
            {
                throw new Exception("Impossible de dépiler, pile vide");
            }
            int val = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);
            return val;
        }

        public int Count { get=> this.elements.Count; }
    }
}
