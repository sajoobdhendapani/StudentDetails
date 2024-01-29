using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.DataAccessLayer
{
    public interface IStudentDetailsRepoistory
    {
        public void Insert(StudentDetail details);
        public IEnumerable<StudentDetail> GetallRecords();
        public void Update(long id, StudentDetail value);
        public void GetByid(long id);
        public void Delete(long id);
    }
}
