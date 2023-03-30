using System;
using System.Collections.Generic;
using UserLibrary;

namespace EbBillCalculation;
class Program
{
    public static void Main(string[] args)
    {
        List<UserDetails> userList = new List<UserDetails>();

        string choice = "";
        int option;

        do
        {
            System.Console.WriteLine("1.Registration 2.Login 3.Exit");
            option=int.Parse(Console.ReadLine());

            if(option==1)
            {
            int unit = 0;
            System.Console.WriteLine("Enter your Name :");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number :");
            long number = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Mail Id :");
            string mailID = Console.ReadLine();

            UserDetails user = new UserDetails(name, number, mailID, unit);

            userList.Add(user);
            System.Console.WriteLine("Meter ID : " + user.MeterId);
            }

            else if(option==2)
            {
            System.Console.WriteLine("Enter your Meter ID");
            string meterID=Console.ReadLine();
            
            foreach(UserDetails user in userList)
            {
                if(meterID.ToUpper()!=user.MeterId)
                {
                    System.Console.WriteLine("Invalid user ID");
                }
                else if(meterID.ToUpper()==user.MeterId)
                {
                    System.Console.WriteLine("1.Calculate Amount 2.Display user details 3.Exit");
                    int choice1 = int.Parse(Console.ReadLine());

                    switch(choice1)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("Enter the unit used :");
                            double unit=double.Parse(Console.ReadLine());

                            double ebAmount = user.ebAmount(unit);
                            System.Console.WriteLine("Total amount is :"+ebAmount);
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("---User Details---");
                            foreach(UserDetails user1 in userList )
                            {
                                System.Console.WriteLine("Meter ID :"+user1.MeterId);
                                System.Console.WriteLine("User Name :"+user1.UserName);
                                System.Console.WriteLine("Phone Number :"+user1.PhoneNumber);
                                System.Console.WriteLine("Mail Id :"+user1.MailID);
                               
                            }
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("THANK YOU");
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

        System.Console.WriteLine("Do you want to continue - yes/no");
        choice =Console.ReadLine().ToUpper();
        
        }
        while(choice=="YES");

    }
}