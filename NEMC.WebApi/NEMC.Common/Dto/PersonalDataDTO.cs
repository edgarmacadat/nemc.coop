using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.Common.Dto
{
    public class PersonalDataDTO
    {
        public int PersonalDataID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public char Sex { get; set; }
        public short Age { get; set; }
        public string Status { get; set; }
        public string SSS { get; set; }
        public string TIN { get; set; }
        public string PHIC { get; set; }
    }
}
