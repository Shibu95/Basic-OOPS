using System;
namespace BankAccountOpening;

    public class CustomerDetails
    {

        private static int s_customerID=1000;

        public string CustomerID {get;}
        public string CustomerName {get;set;}
        public int Balance {get;set;}
        public Gender CustomerGender {get;set;}
        public long PhoneNumber {get;set;}
        public string MailID {get;set;}
        public DateTime DateOfBirth {get;set;}

        public CustomerDetails()
        {
            CustomerGender=Gender.select;
        }

        public CustomerDetails(string customerName,int balance,Gender gender,long phoneNumber,string mailID,DateTime dateOFBirth)
        {
            s_customerID++;
            CustomerID="HDFC"+s_customerID;
            CustomerName=customerName;
            Balance=balance;
            CustomerGender=gender;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DateOfBirth=dateOFBirth;
        }

        public int deposit(int balance,int amount)
        {
            balance+=amount;
            return balance;
        }
        public int withdraw(int balance,int amount)
        {
            balance=balance-amount;
            return balance;
        }

        
    }
