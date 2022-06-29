using System;
using WorkstationShopLibrary;

namespace WorkStationShopConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the store
            Store s = new Store();

            //some settings to change the console
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Workstation Store";
            Console.Clear();

            //intro text to the store
            Console.WriteLine("Welcome to the workstation store. First you must create some items inventory. Then you may add items to your shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            string action = chooseAction();

            while (action != "q")
            {
                Console.WriteLine("You chose " + action);
                switch(action)
                {

                    //add item to inventory
                    case "a":
                        Console.WriteLine("You choose to add a new item to the inventory");
                        string item = "";
                        string itemCompany = "";
                        string itemModel = "";
                        decimal itemPrice = 0;

                        Console.WriteLine("What is the item? desk(de),chair(c),monitor(mo),keyboard(k), mouse(ms),deskpad(dp),desklamp(dl),water bottle(wb), or headphones(h)?");
                        item = Console.ReadLine();
                        while (item != "de" & item != "c" & item != "mo" & item != "k" & item != "ms" & item != "dp" & item != "dl" & item != "wb" & item != "h")
                        {
                            Console.WriteLine("Please enter a valid input");
                            item = Console.ReadLine();
                            
                        }
                        //a swtich to create an instance based off the user choice
                        switch (item)
                        {
                            case "de":
                                item = "Desk";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Desk newDesk = new Desk(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newDesk);
                                break;
                            case "c":
                                item = "Chair";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Chair newChair = new Chair(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newChair);
                                break;
                            case "mo":
                                item = "Monitor"; Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                CodeMonitor newMonitor = new CodeMonitor(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newMonitor);
                                break;
                            case "k":
                                item = "Keyboard";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Keyboard newKeyboard = new Keyboard(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newKeyboard);
                                break;
                            case "ms":
                                item = "Mouse";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Mouse newMouse = new Mouse(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newMouse);
                                break;
                            case "dp":
                                item = "Deskpad";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Deskpad newDeskpad = new Deskpad(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newDeskpad);
                                break;
                            case "dl":
                                item = "Desk Lamp";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                DeskLamp newLamp = new DeskLamp(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newLamp);
                                break;
                            case "wb":
                                item = "Water Bottle";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                WaterBottle newBottle = new WaterBottle(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newBottle);
                                break;
                            case "h":
                                item = "Headphones";
                                Console.WriteLine($"What is the {item} company?");
                                itemCompany = Console.ReadLine();

                                Console.WriteLine($"What is the {item} model?");
                                itemModel = Console.ReadLine();

                                Console.WriteLine($"What is the {item} price?");
                                itemPrice = Convert.ToDecimal(Console.ReadLine());
                                Headphones newHeadphones = new Headphones(item, itemPrice, itemModel, itemCompany);
                                s.ItemList.Add(newHeadphones);
                                break;

                        }

                        printInventory(s);
                        break;

                    
                    case "sc":

                        Console.WriteLine("You choose to add an item to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy?");
                        int itemChosen = int.Parse(Console.ReadLine()) - 1;
                        s.ShoppingList.Add(s.ItemList[itemChosen]);
                        printShoppingCart(s);
                        break;

                    case "co":
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());
                        break;
                    default:
                        break;
                }


                action = chooseAction();
            }
        }
        private static void printInventory(Store s)
        {
            int i = 1;
            Console.WriteLine();
            Console.WriteLine("Item number-Item-Company-Model-Price");
            foreach (Workstation item in s.ItemList)
            {
                Console.WriteLine(i + " " + item.Type + ", " + item.Company + ", " + item.Model + ", $" + item.Price);
                i++;
            }
        }

        //implement try-catch
        public static string chooseAction()
        {
            Console.WriteLine("Choose an action (q) to quit (a) to add a new item to inventory (sc) add item to the shopping cart (co) to checkout");
            string choice = Console.ReadLine().ToLower();
            while (choice != "q" & choice != "a" & choice != "sc" & choice != "co")
            {
                Console.WriteLine("Please enter a valid input");
                choice = Console.ReadLine();
            }

            return choice;
        }
        private static void printShoppingCart(Store s)
        {
            Console.WriteLine();
            Console.WriteLine("Item you have choosen to buy");
            Console.WriteLine("Item number-Item-Company-Model-Price");
            foreach (Workstation item in s.ShoppingList)
            {
                Console.WriteLine(item.Type + ", " + item.Company + ", " + item.Model + ", $" + item.Price);
            }
        }
    }
}