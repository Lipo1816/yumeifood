﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryP.ShopfloorPKG
{
    public partial class ItemDetail
    {
        public Guid Id { get; set; }

        public Guid? WorkordersId { get; set; }

        public string? SerialNo { get; set; }

        public int TargetAmount { get; set; }

        public int Okamount { get; set; }

        public int Ngamount { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? FinishedTime { get; set; }


        public virtual ICollection<ItemRecordDetail> ItemRecordDetails { get; set; } = new List<ItemRecordDetail>();

        public virtual ICollection<TaskDetail> TaskDetails { get; set; } = new List<TaskDetail>();

        public virtual Workorder? Workorders { get; set; }
    }
}
