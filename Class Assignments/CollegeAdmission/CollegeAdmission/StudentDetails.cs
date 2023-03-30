using System;
namespace CollegeAdmission;

    /// <summary>
    /// Used to select a Students Gender information
    /// </summary>
    public enum Gender{Select,Male,Female,Others}

    /// <summary>
    /// Class <see cref="StudentDetails" /> used to collect student's details for the admission process
    /// </summary>
    public class StudentDetails
    {
        
        /// <summary>
        /// Static field used to auto increment and it uniquely identify an instance of
        /// </summary>
        private static int s_studentID=1000;
        
        //Auto property
        /// <summary>
        /// Property StudentId used to uniquely identify a <see cref="StudentDetails" />class's object
        /// </summary>
        public string StudentId { get; }
        /// <summary>
        /// Property Name used to provide name for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// Property father name used to provide father's name of a student
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// Property Student Gender used to get student's gender information
        /// </summary>
        public Gender StudentGender { get; set; }
        /// <summary>
        /// Property Date Of birth used to get student's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Property Phone Number used to get student's phone number
        /// </summary>
        public long  PhoneNumber { get; set; }
        /// <summary>
        /// Property Physics used to get student's physics mark
        /// </summary>
        public float Physics { get; set; }
        /// <summary>
        /// Property Chemistry used to get student's chemistry mark
        /// </summary>
        public float Chemistry { get; set; }
        /// <summary>
        /// Property Maths used to get student's maths mark
        /// </summary>
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
        /// <summary>
        /// Constructor of <see cref="StudentDetails" /> class used to initialize values to its properties
        /// </summary>
        /// <param name="studentName">Parameter student name used to initialize student's Name to Name property</param>
        /// <param name="fatherName">
        /// Parameter father name used to initialize student's father name to father</param>
        /// <param name="gender">
        /// Parameter gender used to initialize student's gender property</param>
        /// <param name="dateofbirth">
        /// Parameter dateOfBirth used to initialize student's date of birth property</param>
        /// <param name="phone">
        /// Parameter phone used to initialize student's phone number property</param>
        /// <param name="physics">
        /// Parameter physics used to initialize mark to student's physics mark property</param>
        /// <param name="chemistry">
        /// Parameter chemistry used to initialize mark to Student's chemistry mark property</param>
        /// <param name="maths">
        /// Parameter maths used to initialize mark to Student's maths mark property </param>
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
        /// <summary>
        /// Method ElidibilityOrNot get cutoff mark as a parameter and check eligibility of student
        /// If average of his mark is greater or equal to cutoff then he is eligible and return true else false
        /// </summary>
        /// <param name="cutoff">Used to provide cutoff value for eligibility checking</param>
        /// <returns>Return true if eligible else false</returns>
        
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
