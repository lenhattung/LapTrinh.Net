using System;
using System.Collections.Generic;

namespace Lab08_QuanLySV.Models;

public partial class SinhVien
{
    public int MaSo { get; set; }

    public string HoTen { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public bool? GioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public int? DienThoai { get; set; }

    public string? MaKhoa { get; set; }

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();

    public virtual Khoa? MaKhoaNavigation { get; set; }
}
