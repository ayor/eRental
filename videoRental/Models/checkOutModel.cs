using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace videoRental.Models
{
    public class checkOutModel
    {
        public int ID { get; set; }
        public int custId { get; set; }
        public int VidID { get; set; }

        public DateTime? RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
