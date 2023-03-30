using System;
namespace PayrollLibrary;

public enum Gender {select,Male,Female,Others}
public enum Location {TamilNadu,OtherState}


    public class EmployeeDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID {get;}
        public string EmployeeName {get;set;}
        public string EmployeeRole {get;set;}
        public Location WorkLocation {get;set;}
        public string TeamName {get;set;}
        public DateTime DateOfJoining {get;set;}
        public int NumberOfWorkingDays {get;set;}
        public int DaysOfLeave {get;set;}
        public Gender EmployeeGender {get;set;}
        

        public EmployeeDetails()
        {
            EmployeeGender=Gender.select;
        }

        public EmployeeDetails(string employeeName,string employeeRole,Location workLocation,string teamName,DateTime dateOfJoining,int numberOfWorkingDays,int daysOfLeave,Gender employeeGender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            EmployeeName=employeeName;
            EmployeeRole=employeeRole;
            WorkLocation=workLocation;
            TeamName=teamName;
            NumberOfWorkingDays=numberOfWorkingDays;
            DaysOfLeave=daysOfLeave;
            EmployeeGender=employeeGender;
        }

        public int calculateSalary(int numberOfWorkingDays,int daysOfLeave)
        {
            int monthSalary=(numberOfWorkingDays-daysOfLeave)*500;
            System.Console.WriteLine("Current month Salary is : "+monthSalary);
            return monthSalary;
        }
    }
