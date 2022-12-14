using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreViewsExample.Models
{
    public partial class Personsview
    {
        [Key]
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
    }
}
