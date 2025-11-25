namespace Bookify.Api.Controllers.Users;

internal sealed record RegisterUserRequest(
    string Email,
    string FirstName,
    string LastName,
    string Password);
