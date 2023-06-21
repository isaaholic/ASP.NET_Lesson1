namespace ChainOfResponsibility.Models.Derived;

public class EmailChecker : BaseChecker
{
    public override bool Check(object request)
    {
        if (request is Human human)
            return !string.IsNullOrWhiteSpace(human.Email) && human.Email.Contains('@');
        return false;
    }
}
