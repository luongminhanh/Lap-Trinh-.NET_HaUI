﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DE03_2.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public string MaPhong { get; set; }
        public string TenPhong { get; set; }

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}