﻿using System.ComponentModel.DataAnnotations;

namespace LaboratoryReagents.DL.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [MaxLength(20)]
        public string LocationName { get; set; }
    }
}
