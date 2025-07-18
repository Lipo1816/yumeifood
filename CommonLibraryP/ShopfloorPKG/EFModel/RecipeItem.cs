﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryP.ShopfloorPKG
{
    public partial class RecipeItem
    {
        public Guid Id { get; set; }

        public Guid ConfigId { get; set; }
        [Required(ErrorMessage = "Null is invalid")]
        public string RecipeItemName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Null is invalid")]
        public int TriggerTiming { get; set; }
        [Required(ErrorMessage = "Null is invalid")]
        public Guid? TargetTagCatId { get; set; }
        [Required(ErrorMessage = "Null is invalid")]
        public Guid? TargetTagId { get; set; }
        [Required(ErrorMessage = "Null is invalid")]
        [Range(1, 44)]
        public int DataType { get; set; }
        [Required]
        public string ValueExpString { get; set; } = null!;
        public virtual WorkorderRecipeConfig? Config { get; set; }
    }
}
