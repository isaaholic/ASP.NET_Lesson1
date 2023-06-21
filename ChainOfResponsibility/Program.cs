using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Derived;

Human human = new User("Emin", "supermanemin", "emin@emin.com");

CheckerDirector director = new();

var validUser = director.MakeHumanChecker(human);

Console.WriteLine(validUser?"Valid User":"Invalid User");