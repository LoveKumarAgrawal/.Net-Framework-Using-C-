/*using System;

class Student
{


   public string Name;
   public int RollNo;
   public int[] Marks = new int[5];
   public int TotalMarks;
   public double Percentage;

   // Static data member
   public static string University_Name = "Gla University";

   // Default Constructor
   public Student()
   {
       Name = "Unknown";
       RollNo = 0;
       TotalMarks = 0;
       Percentage = 0.0;
   }

   // Parameterized Constructor
   public Student(string name, int rollNo, int[] marks)
   {
       Name = name;
       RollNo = rollNo;
       Marks = marks;
       Calculate_result();
   }

   // Static Constructor
   static Student()
   {
       University_Name = "Gla  University";
       Console.WriteLine("University Name is set to: " + University_Name);
   }

   // Read_data() function to input data for the student
   public void Read_data()
   {
       Console.WriteLine("Enter Student Name: ");
       Name = Console.ReadLine();
       Console.WriteLine("Enter Roll Number: ");
       RollNo = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter Marks for 5 subjects: ");
       for (int i = 0; i < 5; i++)
       {
           Console.Write($"Enter marks for subject {i + 1}: ");
           Marks[i] = Convert.ToInt32(Console.ReadLine());
       }
       Calculate_result();
   }

   // Calculate_result() function to calculate total marks and percentage
   public void Calculate_result()
   {
       TotalMarks = 0;
       for (int i = 0; i < 5; i++)
       {
           TotalMarks += Marks[i];
       }
       Percentage = (TotalMarks / 5.0);
   }

   // Display() function to display student data
   public void Display()
   {
       Console.WriteLine("\nStudent Information:");
       Console.WriteLine($"Name: {Name}");
       Console.WriteLine($"Roll Number: {RollNo}");
       Console.WriteLine("Marks in 5 subjects: ");
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine($"Subject {i + 1}: {Marks[i]}");
       }
       Console.WriteLine($"Total Marks: {TotalMarks}");
       Console.WriteLine($"Percentage: {Percentage}%");
       Console.WriteLine($"University Name: {University_Name}");
   }

   // Main method for testing
   static void Main()
   {
       // Creating an instance using the default constructor
       Student student1 = new Student();
       student1.Read_data();
       student1.Display();

       // Creating an instance using the parameterized constructor
       int[] marks = { 85, 90, 78, 88, 92 };
       Student student2 = new Student("John Doe", 101, marks);
       student2.Display();
   }
}
*/

// Question 2 Create the classes and interfaces with following details:
//Interface Name : Account
//Member Functions :
// Open_Account()
// Close_Account()

using System;

interface Account
{
    void Open_Account();
    void Close_Account();
}


interface Customer
{
    void Display_Customer_Detail();
}
class SavingAccount : Account, Customer
{

    public string CustomerName;
    public string AccountNumber;
    public double Balance;

    public static string BankName = "XYZ Bank";

    public SavingAccount()
    {
        CustomerName = "Unknown";
        AccountNumber = "000000";
        Balance = 0.0;
    }


    public SavingAccount(string customerName, string accountNumber, double balance)
    {
        CustomerName = customerName;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    static SavingAccount()
    {
        BankName = "XYZ Bank";
        Console.WriteLine("Bank Name is set to: " + BankName);
    }


    public void Open_Account()
    {
        Console.WriteLine("Account opened for customer: " + CustomerName);
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Initial Balance: " + Balance);
    }

    public void Close_Account()
    {
        Console.WriteLine("Account closed for customer: " + CustomerName);
        Console.WriteLine("Account Number: " + AccountNumber);
        Balance = 0;
    }

    public void Display_Customer_Detail()
    {
        Console.WriteLine("\nCustomer Information:");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Bank Name: {BankName}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance to withdraw.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"{amount} withdrawn successfully.");
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount} deposited successfully.");
    }

    public void Check_And_Display_Balance()
    {
        Console.WriteLine($"Account Balance: {Balance}");
    }

    static void Main()
    {
        SavingAccount account1 = new SavingAccount("Love", "H5454", 10000.0);

        account1.Display_Customer_Detail();

        account1.Open_Account();

        account1.Deposit(2000);

        account1.Withdraw(1500);

        account1.Check_And_Display_Balance();

        account1.Close_Account();

        account1.Check_And_Display_Balance();
    }
}