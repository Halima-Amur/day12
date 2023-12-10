using System;
namespace day12
{
	public class Report
	{
        public delegate bool salesconditons(Emplyee e);

        public void processEmployee (Emplyee [] emp , string title , salesconditons cond)
        {
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------");
            foreach (Emplyee e in emp)
            {
                if (cond (e))
                {
                    Console.WriteLine($"{e.ID} | {e.Name} | {e.Gender} | {e.TotalSales}");

                }

            }
            Console.WriteLine("\n\n");
        }

        public Report()
		{
		}
	}
}

