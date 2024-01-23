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
                _context.Database.ExecuteSqlRaw($"exec InsertStudentDetails '{details.Name}','{details.DOB}',{details.AGE},'{details.Gender}',{details.MoblieNumber} ,'{details.Email}','{details.Subject}'");
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
                var result = _context.Database.ExecuteSqlRaw($" update Students set Name='{value.Name}',DOB='{value.DOB}',Age={value.AGE},Gender='{value.Gender}',MobileNum='{value.MoblieNumber}', Emailid='{value.Email}',Subject='{value.Subject}' where StudentID={id} ");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Delete(long id)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"delete Students where StudentID={id}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<StudentDetail> GetallRecords()
        {
            try
            {
                var result = _context.StudentDetail.FromSqlRaw($"exec ReadallRecords ").ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public StudentDetail GetByid(long id)
        {
            try
            {
                var result = _context.StudentDetail.FromSqlRaw<StudentDetail>($"select * from Students where StudentID={id}");
                return result.ToList().FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
