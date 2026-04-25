using System;
using System.ComponentModel.DataAnnotations;

namespace Todos_Podemos.Moduls
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamA { get; set; }

        [Required]
        public string TeamB { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}