using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace learnDotnet
{
    class TestDbControllers
    {
        TestDbContext context = new TestDbContext();
        TestDbView view = new TestDbView();

        public void showStudents()
        {
            var list = context.Students
                .ToList();

            view.renderAllStudent(list);
        }

        public void addStudent(string name)
        {
            var newStudent = new Student { name = name };
            context.Students.Add(newStudent);
            context.SaveChanges();

            view.renderStudent(newStudent);
        }
    }
}
