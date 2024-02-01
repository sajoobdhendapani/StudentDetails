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
                _context.Database.ExecuteSqlRaw($"exec InsertStudentDetails '{details.Name}','{details.DOB}','{details.AGE}','{details.Gender}','{details.MobileNumber}' ,'{details.Email}','{details.Subject}'");
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
                var update = _context.Database.ExecuteSqlRaw($" update StudentDetail set name='{value.Name}',DOB={value.DOB},AGE={value.AGE},Gender='{value.Gender}',MobileNumber={value.MobileNumber},Email='{value.Email}',subject='{value.Subject}' where StudentId={id} ");
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
        public StudentDetail GetByid(long id)
        {
            try
            {
                var result = _context.StudentDetail.FromSqlRaw($" select *from StudentDetail where StudentId= {id} ");
                return result.ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
