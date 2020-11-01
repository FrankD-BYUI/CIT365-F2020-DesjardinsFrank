using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }
        
        [Range(1, 200)]
        [Required]
        public int Chapter { get; set; }
        
        [Range(1, 200)]
        [Required]
        public int Verse { get; set; }
        
        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateAdded { get; set; }
        
        public string Note { get; set; }
    }
}
