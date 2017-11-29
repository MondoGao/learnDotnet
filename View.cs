using System;
using System.Collections.Generic;

namespace learnDotnet
{
    class TestDbView
    {
        public void renderStudent(Student s)
        {
            Console.WriteLine("Student: {0} - {1}", s.id, s.name);
        }

        public void renderAllStudent(IEnumerable<Student> list)
        {
            foreach (var item in list)
            {
                renderStudent(item);
            }
        }
    }
}