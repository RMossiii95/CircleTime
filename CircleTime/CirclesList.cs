using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    class CirclesList
    {
        public List<Circle> CircleList = new List<Circle>();

        public void NewCircle(double radius)
        {
            CircleList.Add(new Circle(radius));
        }
        public string NewInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public void UserCircle()
        {
            Circle a;
            string response = NewInput("Please enter a radius: ");
            double radius = double.Parse(response);

            a = new Circle(radius);
            CircleList.Add(a);
            Console.WriteLine($"Circumference is: {a.CalculateCircumference(),2}");
            Console.WriteLine($"Area is: {a.CalculateArea(),2}");

            bool goOn = true;
            while (goOn == Continue())
            {
                bool tryAgain = true;
                while (tryAgain == true)
                {

                    try
                    {
                        radius = double.Parse(response);
                        if (radius >= 0)
                        {
                            tryAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("Number must be greater than 0.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please try again.");
                    }

                }
            }

            goOn = Continue();
        }
        public bool Continue()
        {
            while (true)
            {
                string response = NewInput("Would you like to continue? y/n");
                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That was not a valid response, please try again!");
                    continue;
                }
            }
        }
    }
}