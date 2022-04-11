Console.WriteLine("Hello, World! Today is: 2022-04-11");

namespace Asu
{
    class Test
    {
        public class Person
        {
            public Person()
            {
                this.Name = "John Doe";
            }

            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }
        }

        public class PersonProcesses
        {
            public static void Promote(ref Person p)
            {
                p.Salary += 1000;
            }

            public static void AgeUp(ref Person p)
            {
                p.Age += 1;
            }

            public void GetInfo(in Person p, out string firstLetter)
            {
                firstLetter = p.Name.Substring(0, 1);
                
                Console.WriteLine("First Letter: " + firstLetter);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Age: " + p.Age);
                Console.WriteLine("Salary: " + p.Salary);
            }
        }


        delegate void HappyBirthday(ref Person p);

        static void Main(string[] args)
        {
            HappyBirthday hb;

            HappyBirthday hbAge = new HappyBirthday(PersonProcesses.AgeUp);
            HappyBirthday hbPromote = new HappyBirthday(PersonProcesses.Promote);

            hb = hbAge;
            hb += hbPromote;

            Person p = new Person();
            p.Age = 18;
            p.Salary = 1500;


        }
    }




    
}