﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class ItemProperty : ModelBase
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }
}
