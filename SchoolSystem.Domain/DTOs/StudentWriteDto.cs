﻿using SchoolSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Domain.DTOs
{
    public class StudentWriteDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
