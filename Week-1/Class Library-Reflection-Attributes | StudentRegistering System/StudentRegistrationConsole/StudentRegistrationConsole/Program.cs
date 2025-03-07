using System;
using RequiredFieldControl;

namespace StudentRegistrationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var quitFlag = true;

            while(quitFlag)
            {
                // Type your name and press enter
                Console.WriteLine("\nFirst name:");

                string fname = Console.ReadLine();

                // Type your surname and press enter
                Console.WriteLine("Last name:");

                string lName = Console.ReadLine();

                // Type your major and press enter
                Console.WriteLine("Major:");

                string major = Console.ReadLine();

                var student = new Student();

                student.name = fname;
                student.surname = lName;
                student.major = major;

                var result = RequiredField.Verify(student);

                if (result)
                {
                    Console.WriteLine($"{student.name} {student.surname} succesfully registered to {student.major}");
                }
                else
                {
                    Console.WriteLine("Please fill all the fields");
                }


                string quitAnswer;
                do
                {
                    Console.WriteLine("\nDo you want to terminate console? (y/n)");
                    quitAnswer = Console.ReadLine().Trim().ToLower();
                } while (quitAnswer != "y" && quitAnswer != "n");

                quitFlag = quitAnswer == "y" ? false : true;
            }
        }
    }
}
