using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NEMC.DataAccess.Entities
{
    [Table("Membership", Schema = "dbo")]
    public class Membership
    {
        [Key]
        public int MembershipID { get; set; }
        public string MembershipNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsOfficer { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public decimal? ShareMonthlyDeduction { get; set; }
        public decimal? SubscribedAmount { get; set; }
    }
}
