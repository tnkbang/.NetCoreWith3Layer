﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TinNhan
{
    public int Id { get; set; }

    public string? NguoiGui { get; set; }

    public string? NguoiNhan { get; set; }

    public DateTime ThoiGian { get; set; }

    public string NoiDung { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual NguoiDung? NguoiGuiNavigation { get; set; }

    public virtual NguoiDung? NguoiNhanNavigation { get; set; }
}
