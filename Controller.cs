using System;
using System.Collections.Generic;

namespace Properties
{
    public class Controller
    {
        public Controller()
        {
        }

        // Run method gets the Numbers list from the Model class
        // then runs Printing method from View class with the list
        public void Run()
        {
            Model model = new Model();

            List<Numbers> theNumbers = model.Run();

            View v = new View();
            v.Printing(theNumbers);

        }
    }
}
