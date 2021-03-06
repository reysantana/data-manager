namespace DataManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NonConformingReportActions")]
    public class NonConformingReportAction
    {
        [Key]
        public int ActionID { get; set; }

        [Required]
        [StringLength(100)]
        public string ActionName { get; set; }
    }
}
