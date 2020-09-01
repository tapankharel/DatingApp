using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Models
{
    public class Values
    {
        [Key]
        public int Id { get; set; }
        public string ValueName { get; set; }
    }
}