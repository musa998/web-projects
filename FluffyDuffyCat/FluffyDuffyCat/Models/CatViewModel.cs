using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluffyDuffyCat.Models
{
    public class CatViewModel
    {
        [Key]
        public int CatId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string Url { get; set; }

    }
}
