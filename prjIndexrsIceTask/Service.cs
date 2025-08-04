using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexrsIceTask
{
    public class Service
    {
        private int milage, yearModel;
        private string make, model;

        public Service()
        {
            milage = 20000;
            yearModel = 2020;
            make = "Toyota";
            model = "Camry";

            this[3] = "Hilux";               // model = "Hilux"
            this["milage"] = 30000;          // sets milage

            DisplayAllDetails();
        }

        public Service(int milage, int yearModel, string make, string model)
        {
            this.milage = milage;
            this.yearModel = yearModel;
            this.make = make;
            this.model = model;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.milage;
                else if (index == 1)
                    return this.yearModel;
                else if (index == 2)
                    return this.make;
                else if (index == 3)
                    return this.model;
                return null;
            }
            set
            {
                if (index == 0)
                    this.milage = (int)value;
                else if (index == 1)
                    this.yearModel = (int)value;
                else if (index == 2)
                    this.make = (string)value;
                else if (index == 3)
                    this.model = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("milage"))
                    return this.milage;
                else if (attrName.ToLower().Equals("yearModel"))
                    return this.yearModel;
                else if (attrName.ToLower().Equals("make"))
                    return this.make;
                else if (attrName.ToLower().Equals("model"))
                    return this.model;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("milage"))
                    this.milage = (int)value;
                else if (attrName.ToLower().Equals("yearModel"))
                    this.yearModel = (int)value;
                else if (attrName.ToLower().Equals("make"))
                    this.make = (string)value;
                else if (attrName.ToLower().Equals("model"))
                    this.model = (string)value;
            }
        }

        public void DisplayAllDetails()
        {
            Console.WriteLine("=== Car Details ===");
            Console.WriteLine($"Milage: {this[0]}");
            Console.WriteLine($"Year Model: {this[1]}");
            Console.WriteLine($"Make: {this[2]}");
            Console.WriteLine($"Model: {this[3]}");
        }
    }
}