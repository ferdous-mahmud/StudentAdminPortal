using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        
        public List<Student> GetStudents()
        {
            return context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }
    }
}
