﻿using SchoolSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Domain.DTOs
{
    public class StudentReadDto
    {
        // public int StudID { get; set; }
        public string Name { get; set; }
        // public string Address { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
    }
}
