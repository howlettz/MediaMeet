﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaMeet.Models
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String name { get; set; }
        public String description { get; set; }
    }
}