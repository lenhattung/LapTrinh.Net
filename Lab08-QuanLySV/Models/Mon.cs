using System;
using System.Collections.Generic;

namespace Lab08_QuanLySV.Models;

public partial class Mon
{
    public string MaMh { get; set; } = null!;

    public string TenMh { get; set; } = null!;

    public int? SoTiet { get; set; }

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
}
