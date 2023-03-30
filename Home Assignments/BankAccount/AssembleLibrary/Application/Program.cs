using System.Collections.Generic;
using System;
using AccountLibrary;

namespace Application;



class Program
{
    public static void Main(string[] args)
    {
        

        List<CustomerDetails> customerList = new List<CustomerDetails>();
 
        int option ;
        string choice="";

        do
        {
        System.Console.WriteLine("HDFC BANK - 1.Registration 2.LogIn 3.Exit");
        option = int.Parse(Console.ReadLine());
        if(option==1)
        {
        System.Console.WriteLine("-----Registration Page-----");
        System.Console.WriteLine("Enter your Name ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Balance Amount");
        int balance = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Select Gender");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter your Phone number");
        long phoneNumber = long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a Mail ID");
        string mailID = Console.ReadLine();
        System.Console.WriteLine("Date Of Birth - dd/MM/yyyy");
        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Customer Name : "+name+"\n ");

        CustomerDetails customer = new CustomerDetails(name,balance,gender,phoneNumber,mailID,dateOfBirth);
        customerList.Add(customer);


        System.Console.WriteLine("Customer Id : "+customer.CustomerID);

        }
        
        else if(option==2)
        {
            System.Console.WriteLine("Enter your login ID");
            string loginID=Console.ReadLine();
            
            foreach(CustomerDetails customer in customerList)
            {
                if(loginID.ToUpper()!=customer.CustomerID)
                {
                    System.Console.WriteLine("Invalid user ID");
                }
                else if(loginID.ToUpper()==customer.CustomerID)
                {
                    System.Console.WriteLine("1.Deposit 2.Withdraw 3.Balance 4.Exit");
                    int choice1 = int.Parse(Console.ReadLine());

                    switch(choice1)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("Deposit amount");
                            int depositAmount=int.Parse(Console.ReadLine());
                            int currentBalance=customer.deposit(customer.Balance,depositAmount);
                            System.Console.WriteLine("The current balance is : "+currentBalance);
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("Withdraw amount");
                            int withdrawAmount=int.Parse(Console.ReadLine());
                            int currentBalance=customer.withdraw(customer.Balance,withdrawAmount);
                            System.Console.WriteLine("The current balance is : "+currentBalance);
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("The current balance is : "+customer.Balance);
                            break;
                        }
                        case 4:
                        {
                            System.Console.WriteLine("Thank You");
                            break;
                        }
                    }


                }
            }
        }
        else if(option==3)
        {
            System.Console.WriteLine("Thank you");
        }

        System.Console.WriteLine("Do you want to continue - yes or no");
        choice =Console.ReadLine().ToLower();
        }
        while(choice=="yes");
        
       


    }
}