namespace Business
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAccount
    {
        public int Id { get; set; }

        public int? AccountId { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        [StringLength(50)]
        public string AccountUserName { get; set; }

        [StringLength(50)]
        public string AccountPassword { get; set; }

        [StringLength(50)]
        public string AccountEmail { get; set; }

        [StringLength(10)]
        public string AccountType { get; set; }
    }
}
