using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Relationships
        public List<Film> Films { get; set; }
    }
}
