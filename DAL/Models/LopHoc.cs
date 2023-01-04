using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LopHoc
{
    public string MaLop { get; set; } = null!;

    public string? MaNd { get; set; }

    public DateTime NgayTao { get; set; }

    public string TenLop { get; set; } = null!;

    public string? BiDanh { get; set; }

    public double GiaTien { get; set; }

    public string? MoTa { get; set; }

    public bool TrangThai { get; set; }

    public string? ImgBia { get; set; }

    public virtual ICollection<BaiDang> BaiDangs { get; } = new List<BaiDang>();

    public virtual ICollection<DanhGiaLop> DanhGiaLops { get; } = new List<DanhGiaLop>();

    public virtual ICollection<HocSinhThuocLop> HocSinhThuocLops { get; } = new List<HocSinhThuocLop>();

    public virtual ICollection<LichSuTruyCap> LichSuTruyCaps { get; } = new List<LichSuTruyCap>();

    public virtual ICollection<LopThuocTag> LopThuocTags { get; } = new List<LopThuocTag>();

    public virtual NguoiDung? MaNdNavigation { get; set; }

    public virtual ICollection<PhongThi> PhongThis { get; } = new List<PhongThi>();
}
