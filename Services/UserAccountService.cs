using Microsoft.EntityFrameworkCore;
using OtelUygulamasi.Data;
using OtelUygulamasi.Models;

namespace OtelUygulamasi.Services;

public class UserAccountService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;

    public UserAccountService(IDbContextFactory<ApplicationDbContext> dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<ApplicationUser?> ValidateCredentialsAsync(string emailOrUserName, string password)
    {
        using var context = _dbFactory.CreateDbContext();
        var normalized = emailOrUserName.Trim().ToLowerInvariant();
        var user = await context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == normalized || u.UserName.ToLower() == normalized);
        if (user == null)
            return null;

        return VerifyPassword(password, user.PasswordHash) ? user : null;
    }

    public async Task<(bool Success, string? Error)> CreateUserAsync(string userName, string email, string password)
    {
        using var context = _dbFactory.CreateDbContext();
        var userNameLow = userName.Trim().ToLowerInvariant();
        var emailLow = email.Trim().ToLowerInvariant();

        if (await context.Users.AnyAsync(u => u.UserName.ToLower() == userNameLow))
            return (false, "UsernameAlreadyExists");

        if (await context.Users.AnyAsync(u => u.Email.ToLower() == emailLow))
            return (false, "EmailAlreadyExists");

        var user = new ApplicationUser
        {
            UserName = userName.Trim(),
            Email = email.Trim(),
            PasswordHash = HashPassword(password),
            Role = "Customer"
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();
        return (true, null);
    }

    private static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    private static bool VerifyPassword(string password, string storedHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, storedHash);
    }
}
