using Recipe.NetCore.Base.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TMH.Core.Entity
{
    public class User : EntityBase<long>
    {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(255)]
        public string MobileCarrier { get; set; }

        [Required]
        public int TenantId { get; set; }

        [Required]
        public int UserType { get; set; }

        [Required]
        public long UserRoleId { get; set; }

        [MaxLength(50)]
        public string BoxAppUserId { get; set; }

        [MaxLength(255)]
        public string AlternateEmail2 { get; set; }

        [MaxLength(50)]
        public string BusinessPhone { get; set; }

        [MaxLength(50)]
        public string AlternateBusinessPhone { get; set; }

        [MaxLength(255)]
        public string Organization { get; set; }

        [MaxLength(50)]
        public string ZipCode { get; set; }

        public bool? FirstTimeLogin { get; set; }

        public bool BlockSignIn { get; set; }

        public DateTime LastLogin { get; set; }

        public bool? IsLicenseAssigned { get; set; }

        public virtual UserImage UserImage { get; set; }

        public virtual UserRole UserRole { get; set; }

        public virtual ICollection<UserInvitation> UserInvitations { get; set; }

        public virtual ICollection<UserInvitation> InviteeUserInvitation { get; set; }
    }
}
