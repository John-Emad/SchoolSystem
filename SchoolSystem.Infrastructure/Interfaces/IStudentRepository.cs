using SchoolSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Infrastructure.Interfaces
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllStudentsAsynch();
        public Task<Student?> GetStudentByID(int id);
    }
}
