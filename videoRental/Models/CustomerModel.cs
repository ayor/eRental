using System.Collections.Generic;
using System;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace videoRental.Models
{
    public class CustomerModel
    {        
        public int ID { get; set; }
        [Required]
        public string customerName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}