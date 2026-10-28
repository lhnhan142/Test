using System;
using System.Collections.Generic;

namespace QLSanPham.Models;

public partial class LoaiSp
{
    public string MaLoai { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
