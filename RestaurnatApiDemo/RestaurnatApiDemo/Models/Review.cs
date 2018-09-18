using System.ComponentModel.DataAnnotations;

namespace RestaurnatApiDemo.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Reviewer { get; set; }
       
        [Range(1,5)]
        public int Rating { get; set; }

        public string Suggestion { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}