public record FullName(string FirstName, string LastName);
public record Email(string Address);

public class User
{
    public required FullName Name { get; set; }
    public required Email Email { get; set; }

}