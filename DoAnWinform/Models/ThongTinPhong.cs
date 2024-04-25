namespace DoAnWinform.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinPhong")]
    public partial class ThongTinPhong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhong { get; set; }

        public int LoaiPhong { get; set; }

        public int SoGiuong { get; set; }

        public int TrangThai { get; set; }

        [Required]
        [StringLength(50)]
        public string TienNgay { get; set; }

        [Required]
        [StringLength(50)]
        public string TienGio { get; set; }

        public virtual LoaiPhong LoaiPhong1 { get; set; }

        public virtual TrangThai TrangThai1 { get; set; }
    }
}
