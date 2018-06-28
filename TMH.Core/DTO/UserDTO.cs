using Recipe.NetCore.Base.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TMH.Core.Entity;

namespace TMH.Core.DTO
{
    public class UserDTO : DTO<ApplicationUser, long>
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [MaxLength(255, ErrorMessage = "First Name cannot exceed maximum 255 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name is not valid")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [MaxLength(255, ErrorMessage = "Last Name cannot exceed maximum 255 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name is not valid")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,4})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        [MaxLength(255, ErrorMessage = "Email cannot exceed maximum 255 characters.")]

        public string PrimaryEmail { get; set; }

        [Required(ErrorMessage = "Mobile phone is required")]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Mobile phone is not valid")]
        public string MobileNo { get; set; }
        
        public long UserRoleId { get; set; }
        
        public bool IsDeleted { get; set; }

        public override void ConvertFromEntity(ApplicationUser entity)
        {
            base.ConvertFromEntity(entity);
            this.UserName = entity.UserName;
            this.FirstName = entity.FirstName;
            this.LastName = entity.LastName;
            this.PrimaryEmail = entity.Email;
            this.MobileNo = entity.PhoneNumber;
            this.IsDeleted = entity.IsDeleted;
            this.ModifiedBy = entity.LastModifiedBy;
            this.ModifiedOn = entity.LastModifiedOn;
        }

        public override ApplicationUser ConvertToEntity(ApplicationUser entity)
        {
            entity = base.ConvertToEntity(entity);
            entity.UserName = this.UserName;
            entity.FirstName = this.FirstName;
            entity.LastName = this.LastName;
            entity.Email = this.PrimaryEmail;
            entity.PhoneNumber = this.MobileNo;
            entity.IsDeleted = this.IsDeleted;
            entity.LastModifiedBy = this.ModifiedBy;
            entity.LastModifiedOn = this.ModifiedOn;
            return entity;
        }
    }
}
