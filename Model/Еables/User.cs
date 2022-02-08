namespace WpfLesson08
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FerstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LsatName { get; set; }

        public int Fk_LoginId { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime DateRegistration { get; set; }

        public int RoleId { get; set; }

        public virtual LoginUser LoginUser { get; set; }

        public virtual UserRoles UserRoles { get; set; }
    }
}
