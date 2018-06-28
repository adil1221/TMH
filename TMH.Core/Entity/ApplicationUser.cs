using Microsoft.AspNetCore.Identity;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TMH.Core.Entity
{
    public class ApplicationUser: IdentityUser<long>,IAuditModel<long>
    {
        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        public long CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public long? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
