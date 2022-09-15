using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15_9_22
{
    internal class Inheritance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Furniture you want to Buy [Chair / Cot] ");
            string furniture_type = Console.ReadLine();

            Console.WriteLine("Enter the Number of "+ furniture_type + " you want to Buy: ");
            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Mode of Payment [Credit / Debit ] : ");
            string payment_mode = Console.ReadLine();



            if (furniture_type == "Chair")
            {
                Console.WriteLine("Select the Type you want to Buy [Wood / Steel / Plastic] ");
                string chair_type = Console.ReadLine();

                Console.WriteLine("For what Purpose you are buying [Home / Office] ");
                string purpose = Console.ReadLine();

                if(chair_type == "Wood")
                {
                    Console.WriteLine("Select the Type you want to Buy [Teak Wood / Rose Wood] ");
                    string wood_type = Console.ReadLine();

                    Chair c = new Chair();
                    c.GetData(furniture_type, qty, payment_mode, chair_type, purpose,wood_type);
                    c.ShowData();
                }
                else if(chair_type == "Steel")
                {
                    Console.WriteLine("Select the Type you want to Buy [Gray Steel / Green Steel / Brown Steel] ");
                    string steel_type = Console.ReadLine();
                    Chair c = new Chair();
                    c.GetData(furniture_type, qty, payment_mode, chair_type, purpose,steel_type);
                    c.ShowData();
                }
                else if (chair_type == "Plastic")
                {
                    Console.WriteLine("Select the Color: [Green / Red / Blue / White] ");
                    string plastic_color = Console.ReadLine();
                    Chair c = new Chair();
                    c.GetData(furniture_type, qty, payment_mode, chair_type, purpose,plastic_color);
                    c.ShowData();
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }

                

            }

            else if(furniture_type == "Cot")
            {
                Console.WriteLine("Select the Type you want to Buy [Wood / Steel ] ");
                string cot_type = Console.ReadLine();

                Console.WriteLine("Select the Capacity you prefer [Single / Double] ");
                string capacity = Console.ReadLine();

                if (cot_type == "Wood")
                {
                    Console.WriteLine("Select the Type you want to Buy [Teak Wood / Rose Wood] ");
                    string wood_type = Console.ReadLine();

                    Cot c = new Cot();
                    c.GetData(furniture_type, qty, payment_mode, cot_type, capacity, wood_type);
                    c.ShowData();
                }
                else if (cot_type == "Steel")
                {
                    Console.WriteLine("Select the Type you want to Buy [Gray Steel / Green Steel / Brown Steel] ");
                    string steel_type = Console.ReadLine();

                    Cot c = new Cot();
                    c.GetData(furniture_type, qty, payment_mode, cot_type, capacity, steel_type);
                    c.ShowData();
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }
            }

            else
            {
                Console.WriteLine("Invalid Product");
            }
        }
    }


    public class Furniture
    {
        public int OrderId;
        public DateTime OrderDate ;
        public string FurnitureType;   //  Chair/Cot
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;   // (credit/debit card)

        public void GetData(string furniture_type, int qty, string payment_mode)
        {
            OrderId = 1597;
            OrderDate = DateTime.Now;
            FurnitureType = furniture_type;
            Qty = qty;
            TotalAmt = 0;
            PaymentMode = payment_mode;
        }

        public void ShowData()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n\n\t\tOrder Id = " + OrderId+"\t\t\t");
            Console.WriteLine("Date Of Order = " + OrderDate);
            Console.WriteLine("\n\tFurniture Type = "+ FurnitureType);
            Console.WriteLine("\tNumber of "+FurnitureType+" = "+Qty);
            
            
        }

    }

    public class Chair:Furniture
    {
        public string ChairType;   // – Wood/Steel/Plastic
        public string Purpose;  // – Home/office
        public string WoodType;  //  Teak Wood/Rose Wood
        public string SteelType;   // Gray Steel/Green Steel/Brown Steel
        public string PlasticColor; // Green/Red/Blue/White
        public double Rate;
        public string temp;

        public void GetData(string furniture_type, int qty, string payment_mode, string chair_type, string purpose, string spl)
        {
            base.GetData(furniture_type, qty, payment_mode);
            ChairType = chair_type;
            Purpose = purpose;
            if(ChairType == "Wood")
            {
                WoodType = spl;
                if(WoodType == "Teak Wood")
                {
                    Rate = 1000.00;
                    temp = WoodType;
                }
                else if(WoodType == "Rose Wood")
                {
                    Rate = 7500.00;
                    temp = WoodType;
                }
            }
            else if (ChairType == "Steel")
            {
                SteelType = spl;
                if (SteelType == "Gray Steel")
                {
                    Rate = 1100.50;
                    temp = SteelType;
                }
                else if (SteelType == "Green Steel")
                {
                    Rate = 9200.75;
                    temp = SteelType;
                }
                else if (SteelType == "Brown Steel")
                {
                    Rate = 5000.25;
                    temp = SteelType;
                }
            }
            else if (ChairType == "Plastic")
            {
                PlasticColor = spl;
                if (PlasticColor == "Red")
                {
                    Rate = 350.50;
                    temp = PlasticColor;
                }
                else if (PlasticColor == "Green")
                {
                    Rate = 400.32;
                    temp = PlasticColor;
                }
                else if (PlasticColor == "Blue")
                {
                    Rate = 600.25;
                    temp = PlasticColor;
                }
                else if (PlasticColor == "White")
                {
                    Rate = 500.00;
                    temp = PlasticColor;
                }
            }

        }

        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("\tChair Type = "+ChairType);
            Console.WriteLine("\t" +ChairType+ " Type/Color = "+temp);
            Console.WriteLine("\tPurpose = " + Purpose);
            Console.WriteLine("\t\t\t\t\t\tRate per "+FurnitureType+" = \t\t\t\t" + Rate+" Rs");
            
            
            TotalAmt += Rate * Qty;
            Console.WriteLine("\t\t\t\t\t\tTotal Amount = \t\t\t\t\t" + TotalAmt + " Rs\n");
            if (Purpose == "Home")
            {
                TotalAmt = TotalAmt - (TotalAmt * 0.1);
                Console.WriteLine("\t\t\t\t\t\tFor " + Purpose+ " Purpose 10% Discount ");
            }
            else if(Purpose == "Office")
            {
                TotalAmt = TotalAmt - (TotalAmt * 0.25);
                Console.WriteLine("\t\t\t\t\t\tFor " + Purpose + " Purpose 25% Discount ");
            }

            if (PaymentMode == "Credit")
            {
                TotalAmt += 25.05;
                Console.WriteLine("\t\t\t\t\t\t" + PaymentMode + " Payment will charge 25.05rs extra ");
            }
            else if (PaymentMode == "Debit")
            {
                TotalAmt += 13.25;
                Console.WriteLine("\t\t\t\t\t\t" + PaymentMode + " Payment will charge 13.25rs extra ");
            }

            Console.WriteLine("\n\n\t\t\t\t\t\tFinal Total Amount =\t\t\t\t" + TotalAmt + " Rs");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }

    }

    public class Cot:Furniture  //, IEquatable<Chair>
    {
        public string CotType;   //  Wood / Steel
        public string WoodType;  //  Teak Wood/Rose Wood
        public string SteelType;   // Gray Steel/Green Steel/Brown Steel
        public string Capacity;  //  Single/Double
        public double Rate;
        public string temp;

        public void GetData(string furniture_type, int qty, string payment_mode, string cot_type, string capacity, string spl)
        {
            base.GetData(furniture_type, qty, payment_mode);
            CotType = cot_type;
            Capacity = capacity;

            if(Capacity == "Single")
            {
                if (CotType == "Wood")
                {
                    WoodType = spl;
                    if (WoodType == "Teak Wood")
                    {
                        Rate = 40000.00;
                        temp = WoodType;
                    }
                    else if (WoodType == "Rose Wood")
                    {
                        Rate = 37000.00;
                        temp = WoodType;
                    }
                }
                else if (CotType == "Steel")
                {
                    SteelType = spl;
                    if (SteelType == "Gray Steel")
                    {
                        Rate = 27000.13;
                        temp = SteelType;
                    }
                    else if (SteelType == "Green Steel")
                    {
                        Rate = 25000.00;
                        temp = SteelType;
                    }
                    else if (SteelType == "Brown Steel")
                    {
                        Rate = 25000.50;
                        temp = SteelType;
                    }
                }
            }
            else if(Capacity == "Double")
            {
                if (CotType == "Wood")
                {
                    WoodType = spl;
                    if (WoodType == "Teak Wood")
                    {
                        Rate = 70000.00;
                        temp = WoodType;
                    }
                    else if (WoodType == "Rose Wood")
                    {
                        Rate = 67000.50;
                        temp = WoodType;
                    }
                }
                else if (CotType == "Steel")
                {
                    SteelType = spl;
                    if (SteelType == "Gray Steel")
                    {
                        Rate = 52000.25;
                        temp = SteelType;
                    }
                    else if (SteelType == "Green Steel")
                    {
                        Rate = 48000.75;
                        temp = SteelType;
                    }
                    else if (SteelType == "Brown Steel")
                    {
                        Rate = 32000.25;
                        temp = SteelType;
                    }
                }
            }

            
            

        }

        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("\tCot Type = " + CotType);
            Console.WriteLine("\t" + CotType + " Type = " + temp);
            Console.WriteLine("\tCapacity = " + Capacity);
            Console.WriteLine("\t\t\t\t\t\tRate per " + FurnitureType + " = \t\t\t\t" + Rate + " Rs");


            TotalAmt += Rate * Qty;
            Console.WriteLine("\t\t\t\t\t\tTotal Amount = \t\t\t\t" + TotalAmt + " Rs\n");


            if (PaymentMode == "Credit")
            {
                TotalAmt += 25.05;
                Console.WriteLine("\t\t\t\t\t\t" + PaymentMode + " Payment will charge 25.05rs extra ");
            }
            else if (PaymentMode == "Debit")
            {
                TotalAmt += 13.25;
                Console.WriteLine("\t\t\t\t\t\t" + PaymentMode + " Payment will charge 13.25rs extra ");
            }

            Console.WriteLine("\n\n\t\t\t\t\t\tFinal Total Amount =\t\t\t\t" + TotalAmt + " Rs");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }

    }

}



