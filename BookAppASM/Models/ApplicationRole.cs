using Microsoft.AspNetCore.Identity;

namespace BookAppASM.Models
{
    public class ApplicationRole:IdentityRole
    {
        public string? Descriptions;
    }
}
