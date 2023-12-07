using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class EmployeeDelegate
    {
        public delegate bool CheckSalary(List<Person> person);
        public void ShowPersons(List<Person> persons, Predicate<Person> predicate)
        {
            foreach (Person person in persons)
            {
                if (predicate(person))
                {
                    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Address}");
                }
            }
        }

        public void Result()
        {
            List<Person> people = new List<Person>()
            {
            new Person() { Name = "Mariam", Surname = "Aliyeva", Salary = 2000, Address = "London" },
            new Person() { Name = "Tofiq", Surname = "Nasibli", Salary = 2500, Address = "Canada" },
            new Person() { Name = "Haciaga", Surname = "Ahmedov", Salary = 900, Address = "Newyork" },
            new Person() { Name = "Arzu", Surname = "Karimli", Salary = 800, Address = "Baku" },

            };

            ShowPersons(people, people => people.Salary > 1000);
        }
    }
}
