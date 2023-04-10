using Microsoft.AspNetCore.Identity;

namespace RandomPasswordGeneratorApp.Models
{
    public class RandomPasswordModels
    {
        public int Length { get; set; }
        public bool UpperCase { get; set; }
        public bool SpecialCharacter { get; set; }
        public string Password { get; set; } ="GeneratedPassword";
    }
}
