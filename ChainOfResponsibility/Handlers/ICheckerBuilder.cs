using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public interface ICheckerBuilder
{
    public BaseChecker EmailChecker { get; set; }
    public BaseChecker UsernameChecker { get; set; }
    public BaseChecker PasswordChecker { get; set; }
}
