using System;
using System.Collections.Generic;

#nullable disable

namespace OnTapTX2_1.Models
{
    public partial class TacGium
    {
        public TacGium()
        {
            Saches = new HashSet<Sach>();
        }

        public int? MaTg { get; set; }
        public string TenTg { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
