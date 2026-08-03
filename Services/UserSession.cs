namespace OtelUygulamasi.Services;

public class UserSession
{
    public bool IsAuthenticated { get; private set; }
    public string UserName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Role { get; private set; } = "Guest";

    public bool IsAdmin => Role == "Admin";

    public void Login(string userName, string email, string role)
    {
        IsAuthenticated = true;
        UserName = userName;
        Email = email;
        Role = role;
    }

    public void Logout()
    {
        IsAuthenticated = false;
        UserName = string.Empty;
        Email = string.Empty;
        Role = "Guest";
    }
}
