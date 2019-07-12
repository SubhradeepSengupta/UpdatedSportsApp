﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApplication.Models
{
    public class Test
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<UserTestMapper> UserTestMappers { get; set; }
        public virtual TestTypeMapper TestTypeMapper { get; set; }
    }
}
