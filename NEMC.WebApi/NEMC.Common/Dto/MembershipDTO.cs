using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.Common.Dto
{
    public class MembershipDTO
    {
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

        public virtual PersonalDataDTO PersonalData { get; set; }
        public virtual AddressDTO[] Addresses { get; set; }
    }
}
