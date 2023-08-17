using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account_Task.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Server_DateTime { get; set; }
        [Required]
        public DateTime DateTime_UTC { get; set; }
        [Required]
        public DateTime Update_DateTime_UTC { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public int Date_Of_Birth { get; set; }
        [ForeignKey("Account")]
        public int Account_ID { get; set; }
        public Account Account { get; set; }

    }
}

