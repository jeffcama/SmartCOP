using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCOP
{
    static class Program
    {

        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public abstract class Drink
    {
        //Holds the Name of the drink
        public string Name { get; set; }
        //A bool representing if the drink is Carbonated
        public bool Carbonated { get; set; }

        //Used to calculate and return the whole drink description
        public abstract string Description { get;}
    }

    public class Beer : Drink
    {
        //Holds the Beer's ABV
        public string Abv { get; set; }

        public override string Description
        {
            //When getting the Description combine the Name, whether it's Carbonated, and the ABV with a '%' character
            get => $"{Name}{(Carbonated == true ? ", Carbonated" : ", Not Carbonated") }" +
                   $", {Abv}{(Abv.Contains("%") ? "." : "%.") }";
        }
    }

    public class Juice : Drink
    {
        //Holds the Fruit the Juice is made with
        public string Fruit { get; set; }

        public override string Description
        {
            //When getting the Description combine the Name, whether it's Carbonated, and the Fruit it's made with
            get => $"{Name}{(Carbonated == true ? ", Carbonated" : ", Not Carbonated") }" +
                   $", Made from {Fruit}{(Fruit.Last() != 's' ? "s." : ".")}";
        }
    }

    public class Soda : Drink
    {
        public override string Description
        {
            //When getting the Description combine the Name and whether it's Carbonated
            get => $"{Name}{(Carbonated == true ? ", Carbonated." : ", Not Carbonated.") }";
        }
    }
}
