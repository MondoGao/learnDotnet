using System;

namespace learnDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello World!");
            using (var db = new TestDbContext())
            {
                db.Students.Add(new Student { name = "Mondo" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Students)
                {
                    Console.WriteLine(" - {0}", blog.name);
                }
            }

        }
    }
}
