namespace WpfLesson08
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pass_Reset_History
    {
        public int Id { get; set; }

        public int FK_loginNameId { get; set; }

        public DateTime? DataReset { get; set; }

        public virtual LoginUser LoginUser { get; set; }
    }
}
