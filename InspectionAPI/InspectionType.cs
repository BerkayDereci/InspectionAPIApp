﻿using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspeectionName { get; set; } = string.Empty;
    }
}
