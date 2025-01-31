
namespace Web.Api.Common.Dtos.Auth
{
    public class UserAuthDataDto()
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string? UserName { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; } = false;
        public string Token { get; set; }
        public string[] Roles { get; set; }

        // Constructor con parámetro License
        public UserAuthDataDto(string username, bool isAuthenticated) : this()
        {
            UserName = username; // Usa la licencia proporcionada
            IsAuthenticated = isAuthenticated;
        }
    }
}
