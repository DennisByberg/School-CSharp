using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Inlämning2byDB.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; } // ID, always needed! :).
        public string FirstName { get; set; } // Förnamn.
        public string LastName { get; set; } // Efternamn.
        public int? MotherId { get; set; } // Mamma ID.
        public int? FatherId { get; set; } // Pappa ID.
    }
}
 