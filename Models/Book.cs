using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.Models
{
   
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The Title is necessary")]
        [StringLength(50, ErrorMessage = "The sentence length should not exceed 50 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage ="You Must But The Name Of Auther")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters")]
        public string Author{ get; set; }
        [Range(1,50 , ErrorMessage ="The Range Must Specific between 1 dalar and 50 dolar")]
        public Double Price { get; set; }
        [Required(ErrorMessage ="Genre is Required")]
        [StringLength(30, ErrorMessage ="Genre length = 30 characters")]
        public string Genre { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public string? SearchTerm { get; set; }
    }
}
