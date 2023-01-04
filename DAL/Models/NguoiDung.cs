using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NguoiDung
{
    public string MaNd { get; set; } = null!;

    public string? MaLoai { get; set; }

    public string? HoLot { get; set; }

    public string Ten { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public int? GioiTinh { get; set; }

    public string? Sdt { get; set; }

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? ImgAvt { get; set; }

    public string? ImgBg { get; set; }

    public bool TrangThai { get; set; }

    public string? MoTa { get; set; }

    public DateTime NgayTao { get; set; }

    public string? BiDanh { get; set; }

    public virtual ICollection<BaiDang> BaiDangs { get; } = new List<BaiDang>();

    public virtual ICollection<BaoCao> BaoCaos { get; } = new List<BaoCao>();

    public virtual ICollection<BiCamThi> BiCamThis { get; } = new List<BiCamThi>();

    public virtual ICollection<BinhLuan> BinhLuans { get; } = new List<BinhLuan>();

    public virtual ICollection<CamXuc> CamXucs { get; } = new List<CamXuc>();

    public virtual ICollection<CauTraLoi> CauTraLois { get; } = new List<CauTraLoi>();

    public virtual ICollection<DanhGiaLop> DanhGiaLops { get; } = new List<DanhGiaLop>();

    public virtual ICollection<HocSinhThuocLop> HocSinhThuocLops { get; } = new List<HocSinhThuocLop>();

    public virtual ICollection<LichSuGiaoDich> LichSuGiaoDiches { get; } = new List<LichSuGiaoDich>();

    public virtual ICollection<LichSuTruyCap> LichSuTruyCaps { get; } = new List<LichSuTruyCap>();

    public virtual ICollection<LopHoc> LopHocs { get; } = new List<LopHoc>();

    public virtual LoaiNd? MaLoaiNavigation { get; set; }

    public virtual PheDuyet? PheDuyet { get; set; }

    public virtual ICollection<ThichTrang> ThichTrangNguoiDungNavigations { get; } = new List<ThichTrang>();

    public virtual ICollection<ThichTrang> ThichTrangNguoiThichNavigations { get; } = new List<ThichTrang>();

    public virtual ICollection<ThoiGianLamBai> ThoiGianLamBais { get; } = new List<ThoiGianLamBai>();

    public virtual ICollection<ThongBao> ThongBaos { get; } = new List<ThongBao>();

    public virtual ICollection<TinNhan> TinNhanNguoiGuiNavigations { get; } = new List<TinNhan>();

    public virtual ICollection<TinNhan> TinNhanNguoiNhanNavigations { get; } = new List<TinNhan>();

    public virtual TrangThaiNangCap? TrangThaiNangCap { get; set; }

    public virtual ViNguoiDung? ViNguoiDung { get; set; }

    public virtual ICollection<XemTrang> XemTrangNguoiDungNavigations { get; } = new List<XemTrang>();

    public virtual ICollection<XemTrang> XemTrangNguoiXemNavigations { get; } = new List<XemTrang>();

    public virtual ICollection<YeuCauThanhToan> YeuCauThanhToans { get; } = new List<YeuCauThanhToan>();
}
