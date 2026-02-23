using System.ComponentModel.DataAnnotations;

namespace VideoGameApi.Data.Entities
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
