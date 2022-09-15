using System;
using System.Collections.Generic;
using static Assignment_15_9_22.Building;

namespace Assignment_15_9_22
{
    internal class Constructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Questions (select any one):\n1) Person Class\n2) Building Class\n3) Shape Class\n\n");
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    {
                        DateTime p1dt = new DateTime(2000,02,29);
                        Person p1 = new Person("preethi","k.s","kjwdniw@gmail.com",p1dt);
                        DateTime p2dt = new DateTime(2017, 12, 17);
                        Person p2 = new Person("Veena","V",p2dt);
                        Person p3 = new Person("Kaviya","sri","frick_@gmail.com");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("Enter Type (Flat/Villa): ");
                        string type = Console.ReadLine();

                        Console.WriteLine("Enter Capacity (2BHK/3BHK/4BHK): ");
                        string capacity = Console.ReadLine();

                        string dimention;

                        if (type == "Flat")
                        {
                            Console.WriteLine("Enter Dimention (Floor Number): ");                          
                             dimention = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Enter Dimention (20X30,60X40,30X40): ");
                            dimention = Console.ReadLine();
                        }

                        Console.WriteLine("Enter Date of Completion: ");
                        string d = Console.ReadLine();

                        Building b = new Building(type, capacity,dimention,d);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Find the area of : \nSquare\nRectangle\nTriangle\nCircle");
                        string shape = Console.ReadLine();
                        Shape s = new Shape();

                        switch (shape)
                        {
                            case "Square":
                                {
                                    Console.Write("Enter the Int value : ");
                                    int x = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x) + "sq");
                                    break;
                                }

                            case "Rectangle":
                                {
                                    Console.Write("Enter the two values in int : ");
                                    int x = int.Parse(Console.ReadLine());
                                    int y = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x, y) + "sq");
                                    break;
                                }

                            case "Triangle":
                                {
                                    Console.Write("Enter the two values in double : ");
                                    double x = double.Parse(Console.ReadLine());
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x, y) + "sq");
                                    break;
                                }

                            case "Circle":
                                {
                                    Console.Write("Enter the Radius values in double : ");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x) + "sq");
                                    break;
                                }
                        }
                        break;
                    }
            }

            
        }
    }

    public class Person
    {
        public string FirstName = "Null";
        public string LastName = "Null";
        public string EmailId = "xyz @gmail.comxyz@gmail.com";
        public  DateTime Dob = new DateTime();

        
        public Person(string firstName, string lastName, string emailId, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailId = emailId;
            Dob = dob;
            Show();
        }

        public Person(string firstName, string lastName, string emailId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailId = emailId;
            Show();
        }

        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("First Name: "+ FirstName+ "\tLast Name: "+ LastName+ "\tEmail Id: "+ EmailId+ "\tDate of Birth: \n"+ Dob);
        }
    }

    public class Building
    {
        public string Type; 
        public string Capacity; 
        public string Dimension;
        public string Dateofcompletion;

        public Building(string type, string capacity, string dimention, string dateofcompletion)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimention;
            Dateofcompletion = dateofcompletion;
            ShowData();
        }

        public void ShowData()
        {
            Console.WriteLine("\n\nType: " + Type + "\tCapacity: " + Capacity + "\tDimention: " + Dimension + "\tDate of Completion: " + Dateofcompletion);
        }


        public class Shape
        {
            public int AreaOfShape(int x)
            {
                return x * x;
            }
            public int AreaOfShape(int x, int y)
            {
                return x * y;
            }

            public double AreaOfShape(double x)
            {
                return 3.14 * x * x;
            }

            public double AreaOfShape(double x, double y)
            {
                return (x * y) / 2;
            }

        }

    }
}