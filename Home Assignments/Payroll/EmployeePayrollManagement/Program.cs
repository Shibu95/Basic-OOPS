using System;
using System.Collections.Generic;

namespace EmployeePayrollManagement;



class Program 
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();

        string choice1="";

        do
        {

        System.Console.WriteLine("SYNCFUSION - 1.Registration 2.LogIn 3.Exit");
        int option = int.Parse(Console.ReadLine());

        if(option==1)
        {
        System.Console.WriteLine("-----Registration Page-----");
        System.Console.WriteLine("Enter your Name ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter your Role");
        string role = Console.ReadLine();
        System.Console.WriteLine("Enter your work location");
        Location location = Enum.Parse<Location>(Console.ReadLine());
        System.Console.WriteLine("Enter your team name");
        string team = Console.ReadLine();
        System.Console.WriteLine("Date Of Joining - dd/MM/yyyy");
        DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Number of working days in current month");
        int workingDays = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Number of Leaves in current month");
        int leaveDays = int.Parse(Console.ReadLine());
        System.Console.WriteLine("select your Gender");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine());

        EmployeeDetails employee = new EmployeeDetails(name,role,location,team,dateOfJoining,workingDays,leaveDays,gender);
        employeeList.Add(employee);
        System.Console.WriteLine("Employee ID : "+employee.EmployeeID);

        
        
        }
        else if(option==2)
        {
            System.Console.WriteLine("Enter your login ID");
            string loginID=Console.ReadLine();
            
            foreach(EmployeeDetails employee in employeeList)
            {
                if(loginID.ToUpper()!=employee.EmployeeID)
                {
                    System.Console.WriteLine("Invalid user ID");
                }
                else if(loginID.ToUpper()==employee.EmployeeID)
                {
                    System.Console.WriteLine("1.Calculate Salary 2.Display details 3.Exit");
                    int choice = int.Parse(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                        {
                            int monthSalary=employee.calculateSalary(employee.NumberOfWorkingDays,employee.DaysOfLeave);
                            System.Console.WriteLine("Total salary is "+monthSalary);
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("---Employee Details---");
                            foreach(EmployeeDetails employee1 in employeeList )
                            {
                                System.Console.WriteLine("Employee Name :"+employee1.EmployeeName);
                                System.Console.WriteLine("Employee Role :"+employee1.EmployeeRole);
                                System.Console.WriteLine("Work Location :"+employee1.WorkLocation);
                                System.Console.WriteLine("Employee Team :"+employee1.TeamName);
                                System.Console.WriteLine("Date Of Joining :"+employee1.DateOfJoining);
                                System.Console.WriteLine("Current Month Working days :"+employee1.NumberOfWorkingDays);
                                System.Console.WriteLine("Number of days Leave :"+employee1.DaysOfLeave);
                                System.Console.WriteLine("Gender :"+employee1.EmployeeGender);
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
        choice1 =Console.ReadLine().ToUpper();
        
        }
        while(choice1=="YES");


    }
}