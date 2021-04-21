using System;
using System.Collections.Generic;
using System.Text;

namespace Pair_Programming
{
    class Student
    {
        private string _name;
        private int _grade;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public Student()
        {

        }
        public Student(string name, int grade)
        {
            this._name = Name;
            this._grade = Grade;
        }
    }
}
