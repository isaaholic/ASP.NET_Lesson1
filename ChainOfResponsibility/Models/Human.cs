namespace ChainOfResponsibility.Models;

public class Human
{
    public Human(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }

    public Human()
    {
        Username = string.Empty;
        Password = string.Empty;
        Email = string.Empty;
    }

    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}
