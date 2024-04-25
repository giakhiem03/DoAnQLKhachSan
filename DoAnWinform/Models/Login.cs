namespace DoAnWinform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [StringLength(50)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        public int LoaiTaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TuoiNV { get; set; }

        public int GioiTinhNV { get; set; }

        [Required]
        [StringLength(50)]
        public string CCCDNV { get; set; }

        public DateTime NgaySinhNV { get; set; }

        public virtual GioiTinh GioiTinh { get; set; }

        public virtual LoaiTaiKhoan LoaiTaiKhoan1 { get; set; }
    }
}
