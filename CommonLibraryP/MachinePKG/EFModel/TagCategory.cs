﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryP.MachinePKG
{
    public partial class TagCategory
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int ConnectionType { get; set; }

        public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
