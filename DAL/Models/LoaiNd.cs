using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiNd
{
    public string MaLoai { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<NguoiDung> NguoiDungs { get; } = new List<NguoiDung>();
}
