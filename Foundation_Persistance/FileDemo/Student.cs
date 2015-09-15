using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileDemo
{
    class Student
    {
        IConvertor<Student, String> convertor = new StudentToStringConvertor();
        public string Name { get; set; }

        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return convertor.ConvertTo(this);
        }
    }
}
