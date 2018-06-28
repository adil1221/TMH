using Microsoft.AspNetCore.Identity;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TMH.Core.Entity
{
    public class ApplicationRole: IdentityRole<long>,IAuditModel<long>
    {
        [Required]
        public long CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public long? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
