using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Domain.DTOs
{
    public class DepartmentReadDto
    {
        public int DID { get; set; }
        public string DName { get; set; }
    }
}
