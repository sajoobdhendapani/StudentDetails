using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.DataAccessLayer
{
    public class StudentDetailsRepoistory : IStudentDetailsRepoistory
    {
        private readonly SampleDbContext _context;

        public StudentDetailsRepoistory(SampleDbContext context)
        {
            _context = context;
        }
        public void Insert(StudentDetail details)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec InsertStudentDetails '{details.Name}','{details.DOB}','{details.AGE}','{details.Gender}','{details.MoblieNumber}' ,'{details.Email}','{details.Subject}'");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Update(long id, StudentDetail value)
        {
            try
            {
                var update = _context.Database.ExecuteSqlRaw($"");
            }
            catch 
            {
                
            }
        }
        public void Delete(long id)
        {
            try
            {
                
            }
            catch 
            {
               
            }
        }
        public IEnumerable<StudentDetail> GetallRecords()
        {
            try
            {
                var result = _context.StudentDetail.FromSqlRaw($"select * from StudentDetail ").ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void GetByid(long id)
        {
            try
            {
            }
            catch 
            {
                
            }
        }
    }
}
