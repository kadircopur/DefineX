using System;
using RequiredFieldControl;

namespace StudentRegistrationConsole
{
    public class Student
    {
        [RequiredField]
        public string name;

        [RequiredField]
        public string surname;

        [RequiredField]
        public string major;
    }
}
