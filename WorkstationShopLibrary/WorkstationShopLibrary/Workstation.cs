using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationShopLibrary
{
    //Parent Class
    public class Workstation
    {
        //properties, everything has a price and model

        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string Company { get; set; }

    }

    //child class
    public class Chair : Workstation
    {
        //default constructor
        public Chair()
        {
            this.Type = "Chair";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Chair(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company=company;
        }
    }
    public class Desk : Workstation
    {
        //default constructor
        public Desk()
        {
            this.Type = "Desk";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Desk(string type, decimal price, string model, string company)
        {
            this.Type=type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }

    public class CodeMonitor : Workstation //Monitor is ambigious in C#
    {
        //default constructor
        public CodeMonitor()
        {
            this.Type = "monitor";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public CodeMonitor(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }
    public class Keyboard : Workstation
    {
        //default constructor
        public Keyboard()
        {
            this.Type = "keyboard";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Keyboard(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }
    public class Mouse : Workstation
    {
        //default constructor
        public Mouse()
        {
            this.Type = "Mouse";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Mouse(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }
    public class Deskpad : Workstation
    {
        //default constructor
        public Deskpad()
        {
            this.Type = "Deskpad";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Deskpad(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }

    //abstract child class
    public abstract class Accessory : Workstation
    {
       

    }
    public class DeskLamp : Accessory
    {
        //default constructor
        public DeskLamp()
        {
            this.Type = "Desk Lamp";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
            
        }
        //Parametric constructor
        public DeskLamp(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }

    public class WaterBottle : Accessory
    {
        //default constructor
        public WaterBottle()
        {
            this.Type = "Water Bottle";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public WaterBottle(string type, decimal price, string model, string company)
        {
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }
    public class Headphones : Accessory
    {
        //default constructor
        public Headphones()
        {
            this.Type = "Headphones";
            this.Price = 0.00M; //M is for the dollar sign
            this.Model = "No Version";
            this.Company = "Fill";
        }
        //Parametric constructor
        public Headphones(string type, decimal price, string model, string company)
        {
            this.Type = type ;
            this.Price = price;
            this.Model = model;
            this.Company = company;
        }
    }
}
