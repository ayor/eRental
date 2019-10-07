using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace videoRental.Models
{
    public class videoModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Kindly Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Kindly Enter Format")]
        public string Format { get; set; }

        [Required(ErrorMessage = "Kindly Enter Stock")]
        public int Stock { get; set; }
    }
}