using System;
using System.Collections.Generic;

namespace Properties
{
    public class View
    {
        public View()
        {
        }

        // prints list created in Model class
        public void Printing(List<Numbers> theNumbers)
        {
            Console.Clear();
            for (int i = 0; i < theNumbers.Count; i++)
            {
                Console.WriteLine(theNumbers[i].Language);
                Console.WriteLine(theNumbers[i].One);
                Console.WriteLine(theNumbers[i].Two);
                Console.WriteLine(theNumbers[i].Three);
                Console.WriteLine();

            }

        }
    }

}
