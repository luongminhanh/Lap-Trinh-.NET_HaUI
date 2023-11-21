using System;
using System.Collections.Generic;

#nullable disable

namespace KT_1.Models
{
    public partial class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int? NamXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public int? MaTg { get; set; }

        public virtual TacGium MaTgNavigation { get; set; }
    }
}
