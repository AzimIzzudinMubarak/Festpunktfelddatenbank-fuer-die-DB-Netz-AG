﻿using System;

namespace FestpunktDB.Business.EntitiesDeleted
{
    public partial class GeloeschtPs
    {
        public string PAD { get; set; }
        public string PStrecke { get; set; }
        public short PSTRRiKz { get; set; }
        public double? Station { get; set; }
        public DateTime? Import { get; set; }
        public DateTime? LoeschDatum { get; set; }
        public DateTime? SDatum { get; set; }

        //public virtual Pp PadNavigation { get; set; }
    }
}
