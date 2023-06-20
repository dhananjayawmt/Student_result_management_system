using System.ComponentModel.DataAnnotations;

namespace Login_Screen
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}