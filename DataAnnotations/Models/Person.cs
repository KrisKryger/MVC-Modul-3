using System;
using System.ComponentModel.DataAnnotations;

namespace Teknologisk
{
    public class Person
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name ="Navn")]
        public string Name { get; set; }

        [Range(50, 250)]
        [Display(Name ="Højde")]
        public int Height { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Fødselsdato")]       
        public DateTime BirthDate { get; set; }
    }
}