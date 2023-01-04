using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PhongThi
{
    public string MaPhong { get; set; } = null!;

    public string? MaLop { get; set; }

    public string TenPhong { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public string? MatKhau { get; set; }

    public DateTime NgayMo { get; set; }

    public DateTime NgayDong { get; set; }

    public int LuotThi { get; set; }

    public bool XemLai { get; set; }

    public int ThoiLuong { get; set; }

    public virtual ICollection<BiCamThi> BiCamThis { get; } = new List<BiCamThi>();

    public virtual ICollection<CauHoiThi> CauHoiThis { get; } = new List<CauHoiThi>();

    public virtual LopHoc? MaLopNavigation { get; set; }

    public virtual ICollection<ThoiGianLamBai> ThoiGianLamBais { get; } = new List<ThoiGianLamBai>();
}
