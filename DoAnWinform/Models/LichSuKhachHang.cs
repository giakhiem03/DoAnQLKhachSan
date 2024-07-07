namespace DoAnWinform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuKhachHang")]
    public partial class LichSuKhachHang
    {
        [Key]
        [StringLength(50)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string QuocTich { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime NgayThanhToan { get; set; }

        [StringLength(50)]
        public string SoNgayDat { get; set; }

        [StringLength(50)]
        public string SoGioDat { get; set; }
        public string a {  get; set; }
        [Required]
        [StringLength(50)]
        public string TongTien { get; set; }

        public int MaPhongDat { get; set; }

        public virtual GioiTinh GioiTinh1 { get; set; }
    }
}
