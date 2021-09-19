using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NEMC.DataAccess.Entities
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public int PersonalDataID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int? Zip { get; set; }
        public int? AddressTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
