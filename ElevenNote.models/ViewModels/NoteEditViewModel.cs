using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.models.ViewModel
{
    public class NoteEditViewModel // make sure this is public for anyone to see.
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least two characters.")]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Contents { get; set; }

        public bool IsFavorite { get; set; }
    }

    }
