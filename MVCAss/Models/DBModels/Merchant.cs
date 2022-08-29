namespace MVCAss.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Merchant
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreName { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreAddress { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        public virtual Merchant Merchants1 { get; set; }

        public virtual Merchant Merchant1 { get; set; }
    }
}
