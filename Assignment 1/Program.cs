using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question4 q = new Question4();
            q.fun();
        }
    }

    class Question1
    {
        public void fun()
        {
            // Q1.Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices. Include a 10% discount if the total price exceeds Rs. 3000.
            int[] shoppingCart = { 1000, 2000, 3000, 4000, 5000 };
            double totalPrice = 0;
            for (int i = 0; i < shoppingCart.Length; i++) {
                if (shoppingCart[i] > 3000)
                {
                    totalPrice += (shoppingCart[i] * 0.1);
                } else
                {
                    totalPrice += shoppingCart[i];
                }
            }
            Console.WriteLine(totalPrice);
        }
    }

    class Question2
    {
        public void fun()
        {
            // Q2.Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit. If the input temperature is below 0°C, display a warning message about freezing temperatures.
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
            if (celsius < 0)
            {
                Console.WriteLine("Warning: The temperature is below freezing point!");
            }
        }
    }

    class Question3
    {
        public void fun()
        {
            // Q3.Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money, and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal.
            double balance = 1000.00;
            while (true)
            {
                Console.WriteLine("Simple ATM Menu");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: ${balance}");
                        break;

                    case 2:
                        Console.Write("Enter the amount to deposit: $");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Deposited ${depositAmount}. New balance: ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the amount to withdraw: $");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Withdrew ${withdrawAmount}. New balance: ${balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds. Withdrawal denied.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting ATM. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select 1-4.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }

    class Question4
    {
        public void fun()
        {
            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter the marks for subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = CalculateAverage(marks);
            char grade = DetermineGrade(average);

            Console.WriteLine($"\nYour average marks are: {average}");
            Console.WriteLine($"Your grade is: {grade}");
        }

        static double CalculateAverage(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return (double)total / marks.Length;
        }

        static char DetermineGrade(double average)
        {
            if (average >= 90)
            {
                return 'A';
            }
            else if (average >= 80)
            {
                return 'B';
            }
            else if (average >= 70)
            {
                return 'C';
            }
            else if (average >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}