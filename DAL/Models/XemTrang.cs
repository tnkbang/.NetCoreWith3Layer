using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class XemTrang
{
    public string MaXt { get; set; } = null!;

    public string? NguoiDung { get; set; }

    public string? NguoiXem { get; set; }

    public DateTime ThoiGian { get; set; }

    public virtual NguoiDung? NguoiDungNavigation { get; set; }

    public virtual NguoiDung? NguoiXemNavigation { get; set; }
}
