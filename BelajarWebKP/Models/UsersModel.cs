using System;
using System.ComponentModel.DataAnnotations;

namespace BelajarWebKP.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        // public string Genre { get; set; }
        // public decimal Price { get; set; }
    }
}