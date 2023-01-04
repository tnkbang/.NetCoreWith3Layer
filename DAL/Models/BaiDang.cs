using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class BaiDang
{
    public string MaBai { get; set; } = null!;

    public string? MaLop { get; set; }

    public string? MaNd { get; set; }

    public DateTime ThoiGian { get; set; }

    public string? NoiDung { get; set; }

    public string? DinhKem { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<BinhLuan> BinhLuans { get; } = new List<BinhLuan>();

    public virtual ICollection<CamXuc> CamXucs { get; } = new List<CamXuc>();

    public virtual Ghim? Ghim { get; set; }

    public virtual LopHoc? MaLopNavigation { get; set; }

    public virtual NguoiDung? MaNdNavigation { get; set; }
}
