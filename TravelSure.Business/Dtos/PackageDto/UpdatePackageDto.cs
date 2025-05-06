using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSure.Business
{
    public class UpdatePackageDto
    {


        [Required(ErrorMessage = "Destination is required.")]
        [MinLength(3, ErrorMessage = "Destination must be at least 3 characters long.")]
        public string Destination { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be positive.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(500, ErrorMessage = "Description can't exceed 500 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}
