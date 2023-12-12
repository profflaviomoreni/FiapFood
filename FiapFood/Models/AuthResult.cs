namespace FiapFood.Models
{
    public class AuthResult
    {
        public string Rule { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expired { get; set; }

    }
}
