using System;
using System.Collections.Generic;

namespace QLSanPham.Models;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string TenSp { get; set; } = null!;

    public decimal DonGia { get; set; }

    public int SoLuong { get; set; }

    public DateTime NgayNhap { get; set; }

    public string TrangThai { get; set; } = null!;

    public string MaLoai { get; set; } = null!;

    public virtual LoaiSp MaLoaiNavigation { get; set; } = null!;
}
