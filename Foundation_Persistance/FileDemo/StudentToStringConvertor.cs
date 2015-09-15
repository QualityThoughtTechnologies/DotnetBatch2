using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class StudentToStringConvertor : IConvertor<Student, String>
    {
        public String ConvertTo(Student t)
        {
            return string.Join(";", t.Id, t.Name, t.PhoneNumber);
        }

        public Student ConvertFrom(String v)
        {
            string[] items = v.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            if(items.Length!=3)
            {
                throw new InvalidCastException("String is not in proper format");
            }
            Student s = new Student();
            s.Id = int.Parse(items[0]);
            s.Name = items[1];
            s.PhoneNumber = items[2];
            return s;
        }
    }
}
