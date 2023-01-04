using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CauHoiThi
{
    public int Stt { get; set; }

    public string MaPhong { get; set; } = null!;

    public string CauHoi { get; set; } = null!;

    public string LoiGiai { get; set; } = null!;

    public string DapAn { get; set; } = null!;

    public virtual ICollection<CauTraLoi> CauTraLois { get; } = new List<CauTraLoi>();

    public virtual PhongThi MaPhongNavigation { get; set; } = null!;
}
