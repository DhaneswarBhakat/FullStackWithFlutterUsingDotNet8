using System.ComponentModel.DataAnnotations;

namespace FullStackWithFlutterUsingDotNet8.Model
{
    public class users
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public String name { get; set; } = "";

        [Required]
        public String address { get; set; } = "";

    }
}
