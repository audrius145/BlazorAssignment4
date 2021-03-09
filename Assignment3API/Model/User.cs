using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment3API.Model
{
    public class User
    {
        [JsonPropertyName("username"), Key]
        public string UserName { get; set; }
        [JsonPropertyName("role"), Required]
        public string Role { get; set; } 
        [JsonPropertyName("password"), Required]
        public string Password { get; set; }
    }
}