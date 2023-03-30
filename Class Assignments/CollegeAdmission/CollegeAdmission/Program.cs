using System;
using System.Collections.Generic;

namespace CollegeAdmission;
class Program
{
    public static void Main(string[] args)
    {
        //Creating file for storing objects
        CustomList<StudentDetails> studentList = new CustomList<StudentDetails>();

        string option = "";
        do
        {

            System.Console.WriteLine("******Registration Form******");

            //Creating copy of student for student 
            //StudentDetails student1= new StudentDetails();

            System.Console.WriteLine("Enter Your Name : ");
            string name1 = Console.ReadLine();
            System.Console.WriteLine("Enter Your Father Name : ");
            string fatherName1 = Console.ReadLine();
            System.Console.WriteLine("Gender : ");
            Gender gender1  =Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Date Of Birth - dd/MM/yyyy : ");
            DateTime dateOfBirth1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter Your Phone number : ");
            long phoneNumber1 = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Marks in Physics : ");
            float physicsMark1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Marks in Chemistry : ");
            float chemistryMark1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Marks in Maths : ");
            float mathsMark1 = float.Parse(Console.ReadLine());



            StudentDetails student = new StudentDetails(name1, fatherName1, gender1, dateOfBirth1, phoneNumber1, physicsMark1, chemistryMark1, mathsMark1);

            studentList.Add(student);
            System.Console.WriteLine("Student ID  : " + student.StudentId);



            System.Console.WriteLine("Do you want to continue - yes / no");
            option = Console.ReadLine().ToLower();

        }
        while (option == "yes");

        System.Console.WriteLine("Enter Your Login ID");
        string loginID = Console.ReadLine();
        bool flag = true;


        foreach (StudentDetails student in studentList)
        {
            if (loginID.ToUpper() == student.StudentId)
            {
                flag = false;

                System.Console.WriteLine("STUDENT DETAILS :-");
                System.Console.WriteLine("Student ID     : " + student.StudentId);
                System.Console.WriteLine("Student Name   : " + student.StudentName);
                System.Console.WriteLine("Father Name    : " + student.FatherName);
                System.Console.WriteLine("Gender         : " + student.StudentGender);
                System.Console.WriteLine("Date Of Birth  : " + student.DateOfBirth);
                System.Console.WriteLine("Phone Number   : " + student.PhoneNumber);
                System.Console.WriteLine("Physics Mark   : " + student.Physics);
                System.Console.WriteLine("Chemistry Mark : " + student.Chemistry);
                System.Console.WriteLine("Maths Mark     : " + student.Maths);

                bool check = student.EligibilityOrNot(75.0);
                if (check)
                {
                    System.Console.WriteLine("You are eligible for admission");
                }
                else
                {
                    System.Console.WriteLine("You are not eligible for admission");
                }
                break;

            }
        }
        if (flag)
        {
            System.Console.WriteLine("Invalid user ID");
        }


    }
}
