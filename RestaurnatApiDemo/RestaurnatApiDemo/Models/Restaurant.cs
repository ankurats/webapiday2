using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurnatApiDemo.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Review> Reviews { get; set; }
    }
}