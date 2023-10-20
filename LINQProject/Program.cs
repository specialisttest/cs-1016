namespace LINQProject
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> people = new List<Person>(){
                new Person() { Name = "Sergey", Age = 40},
                new Person() { Name = "Vasiliy", Age = 35},
                new Person() { Name = "Kosty", Age = 12},
                new Person() { Name = "Alex", Age = 10}
            };

            var result =
                from p in people
                where p.Age >= 18
                orderby p.Name
                select new { Name = p.Name, Age = p.Age };

            people[2].Age = 18;

            foreach(var p in result)
                Console.WriteLine("{0} {1}", p.Name, p.Age);


        }
    }
}
