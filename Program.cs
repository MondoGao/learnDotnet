using System;

namespace learnDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new TestDbControllers();
            controller.addStudent("江高华");
            controller.showStudents();
        }
    }
}
