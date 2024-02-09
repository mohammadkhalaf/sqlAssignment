﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp2.Entities
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string SchoolName  { get; set; }
    }
}
