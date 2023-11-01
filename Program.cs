using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MiniProject3
{
    public static void Main(string[] args)
    {
        BankAccount ba = new BankAccount();

        ba.TotalBalance = 10256.42;

        Console.WriteLine("If you want to deposit money, click 1, if you want to withdraw money, click 2, if you want to display your balance, click 3.");
        string choice = Console.ReadLine();
        
            if (choice == "1")
                ba.Deposit();
            else if (choice == "2")
                ba.Withdrawal();
            else if (choice == "3")
                ba.DisplayBalance();
            else
                Console.WriteLine("Invalid input!");
    }
}
    public class BankAccount
    {
        public double TotalBalance;

        public void Deposit()
        {
            Console.WriteLine("How much do you want to deposit?");
            int deposit = Convert.ToInt32(Console.ReadLine());

            if (deposit % 10 == 0)
            {
                TotalBalance = TotalBalance + deposit;
                Console.WriteLine("The deposit has been added to your total balance.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only deposit a sum that is divisible by 10!");
                Console.ResetColor();
            }
        }
        public void Withdrawal()
        {
            Console.WriteLine("How much do you want to withdraw?");
            int withdrawal = Convert.ToInt32(Console.ReadLine());

            if (withdrawal % 10 == 0)
            {
                TotalBalance = TotalBalance - withdrawal;
                Console.WriteLine("The withdrawal has been subtracted of your total balance.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only withdraw a sum that is divisible by 10!");
                Console.ResetColor();
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Your total balance is: " + TotalBalance);
        }
    }
    interface GeoShapes
    {
    double Area();
    double Perimeter();
    }

    class Square : GeoShapes
    {
    public double side = 2;

    public double Area()
    {
        return side * side;
    }
    public double Perimeter()
    {
        return side * 4;
    }
    }

    class Triangle : GeoShapes
    {
    public double side = 3;
    public double height = 5;

    public double Area()
    {
        return side * height * 1/2; 
    }
    public double Perimeter()
    {
        return side * 3;
    }
    }

    class Circle
    {
    public double radius = 7;

    public double Area()
    {
        return radius * radius * Math.PI; 
    }
    public double Perimeter()
    {
        return radius * 2 * Math.PI;
    }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        private bool isEngineRunning;

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            isEngineRunning = false;
        }

        public void StartEngine()
        {
            if (!isEngineRunning)
            {
                Console.WriteLine($"Starting the engine of {Year} {Model}.");
                isEngineRunning = true;
            }
            else
            {
                Console.WriteLine($"{Year} {Model}'s engine is already running.");
            }
        }

        public void StopEngine()
        {
            if (isEngineRunning)
            {
                Console.WriteLine($"Stopping the engine of {Year} {Model}.");
                isEngineRunning = false;
            }
            else
            {
                Console.WriteLine($"{Year} {Model}'s engine is already off.");
            }
        }
    }