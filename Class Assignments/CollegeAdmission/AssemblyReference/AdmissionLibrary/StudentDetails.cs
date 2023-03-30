using System;
namespace AdmissionLibrary;
    public enum Gender{Select,Male,Female,Others}


    public class StudentDetails
    {
        //fields
        /*private string _studentName;

        //property
        public string StudentName{get{return _studentName;} set{_studentName=value;}} */

        private static int s_studentID=1000;
        
        //Auto property
        public string StudentId { get; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }

        public Gender StudentGender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public long  PhoneNumber { get; set; }

        public float Physics { get; set; }

        public float Chemistry { get; set; }

        public float Maths { get; set; }

        // Constructors

        // Default Constructor(Method)
        public StudentDetails()
        {
            StudentName="Enter Your Name : ";
            FatherName="Enter Your Father Name : ";
            StudentGender=Gender.Select;
            
        }

        // parameterized constructor
        public StudentDetails(string studentName,string fatherName,Gender gender,DateTime dateofbirth,long phone, float physics, float chemistry,float maths)
        {
            s_studentID++;
            StudentId="SF"+s_studentID;
            StudentName=studentName;
            FatherName=fatherName;
            StudentGender=StudentGender;
            DateOfBirth=dateofbirth;
            PhoneNumber=phone;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
        public bool EligibilityOrNot(double cutoff)
        {
            float total = Physics+Chemistry+Maths;
            float average = total/3;
            bool check= false;
            if(average>=75)
            {
                check=true;
            }
            return check;


        }

    }
