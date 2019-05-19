using System;
using System.Collections.Generic;

namespace Properties
{
    public class Model
    {
        public List<Numbers> NumbersList { get; set; }


        // Model constructor creates list NumbersList
        public Model()
        {
            NumbersList = new List<Numbers>();

            List<string> languages = new List<string>() { "English", "One", "Two", "Three", "French", "Un", "Deux", "Trois",
                "Spanish", "Uno", "Dos", "Tres", "Italian", "Uno", "Duo", "Tre", "Japanese", "Ichi", "Ni", "San" };

            for (int i = 0; i < languages.Count; i += 4)
            {
                Numbers n = new Numbers();

                n.Language = languages[i];
                n.One = languages[i + 1];
                n.Two = languages[i + 2];
                n.Three = languages[i + 3];

                NumbersList.Add(n);
            }

        }

        // Run method returns the created NumbersList list to whichever other class asked for it
        public List<Numbers> Run()
        {
            return NumbersList;
        }

    }
}
