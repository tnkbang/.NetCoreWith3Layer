using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ThichTrang
{
    public string MaYt { get; set; } = null!;

    public string? NguoiDung { get; set; }

    public string? NguoiThich { get; set; }

    public DateTime ThoiGian { get; set; }

    public virtual NguoiDung? NguoiDungNavigation { get; set; }

    public virtual NguoiDung? NguoiThichNavigation { get; set; }
}
