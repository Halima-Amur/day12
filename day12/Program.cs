namespace day12
{
    class program
    {
        public static void print<T>(T val)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(val);
        }
        static void Main()
        {
            print(3);
            print("Halima");
            print(true);
            print (3.4);

            Emplyee[] emp = new Emplyee[]
      {
                new Emplyee{ID=1 , Name="Halima" , Gender = 'F' , TotalSales=70000m},
                new Emplyee{ID=2 , Name="Amur" , Gender = 'M' , TotalSales=60000m},
                new Emplyee{ID=3 , Name="Rashid" , Gender = 'M' , TotalSales=50000m},
                new Emplyee{ID=4 , Name="Saif" , Gender = 'M' , TotalSales=80000m},

      };

            Report reports = new Report();

            reports.processEmployee(emp, "total sales more than 60k", greater60);

            reports.processEmployee(emp, "total sales between 30k to 60k", inBetween3060);

            reports.processEmployee(emp, "total sales less than 30k", lessthan30);

            bool greater60(Emplyee emp) => emp.TotalSales >= 60000m;
            bool inBetween3060(Emplyee emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m;
            bool lessthan30(Emplyee emp) => emp.TotalSales < 30000m;


        }
    }
}

