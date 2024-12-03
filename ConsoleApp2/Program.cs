
using Bogus;
using BogusTest;

Faker<User> faker = new Faker<User>().
    RuleFor(x => x.Name, f => f.Person.FirstName).
    RuleFor(x => x.Surname, f => f.Person.FirstName).
    RuleFor(x => x.Email, f => f.Person.Email).
    RuleFor(x => x.Age, f => f.Random.Int(12, 34));


var fakeUsers = faker.Generate(10);

foreach (var user in fakeUsers)
{
    Console.WriteLine($"Name : {user.Name}, " +
                      $"Surname : {user.Surname}, " +
                      $"Age : {user.Age}, " +
                      $"Email : {user.Email} ");
}



namespace BogusTest
{
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}