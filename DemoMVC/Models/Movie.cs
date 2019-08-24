using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Title { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [RegularExpression("^(1|2)[0-9]{3}$", ErrorMessage ="Please provide a valid Year")]
        public string Year { get; set; }
        [Display(Name ="Poster Link")]
        [RegularExpression(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$",
            ErrorMessage ="Please provide an image from an URL, eg: https://via.placeholder.com/img.png")]
        public string Poster { get; set; }
    }
}
