using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class BaoCao
{
    public string MaBaoCao { get; set; } = null!;

    public string? MaNd { get; set; }

    public string ChiMuc { get; set; } = null!;

    public string NoiDung { get; set; } = null!;

    public string? GhiChu { get; set; }

    public DateTime ThoiGian { get; set; }

    public virtual NguoiDung? MaNdNavigation { get; set; }
}
