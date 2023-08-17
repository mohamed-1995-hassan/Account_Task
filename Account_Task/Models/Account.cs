using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account_Task.Models
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        [Required]
        public DateTime Server_DateTime { get; set; }
        [Required]
        public DateTime DateTime_UTC { get; set; }
        [Required]
        public int Update_DateTime_UTC { get; set; }
        [Required]
        public string Account_Number { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public int Status { get; set; }
        public User User { get; set; }
    }
}
