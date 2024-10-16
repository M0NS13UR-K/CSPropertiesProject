using System;

namespace Program
{
    class Person
    {
        private string name;
        private int age;

        public string Name{
            get {return name;}
            set {name = value;}
        }
        public int Age{
            get {return age;}
            set
            {
                if (value>=0) 
                {
                    age =value;
                }
                else 
                {
                    Console.WriteLine("invalid age");
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"name : {Name}, Age : {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to getters and setters tutorial mini console application.");
            Person one = new Person();

            one.Name = "Akash";

            one.Age = 14;
            one.DisplayInfo();

            one.Age = -5;
            one.DisplayInfo();
            
        }
    }
}