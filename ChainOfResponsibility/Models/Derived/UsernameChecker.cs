namespace ChainOfResponsibility.Models.Derived;

public class UsernameChecker : BaseChecker
{
    public override bool Check(object request)
    {
        if(request is Human human)
        if(!string.IsNullOrWhiteSpace(human.Username))
                return Next.Check(request);
        return false;
    }

}
