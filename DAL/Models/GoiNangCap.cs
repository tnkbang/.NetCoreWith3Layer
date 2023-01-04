using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GoiNangCap
{
    public int MaGoi { get; set; }

    public string TenGoi { get; set; } = null!;

    public double GiaTien { get; set; }

    public int HieuLuc { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<TrangThaiNangCap> TrangThaiNangCaps { get; } = new List<TrangThaiNangCap>();
}
