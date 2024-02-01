using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace StudentDetails.DataAccessLayer
{
    public class StudentDetail
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int AGE { get; set; }
        public string Gender { get; set; }
        public long MobileNumber { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
