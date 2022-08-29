namespace MVCAss.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Buyer
    {
        public int BuyerId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
