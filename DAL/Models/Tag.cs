using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Tag
{
    public string MaTag { get; set; } = null!;

    public string TenTag { get; set; } = null!;

    public virtual ICollection<LopThuocTag> LopThuocTags { get; } = new List<LopThuocTag>();
}
