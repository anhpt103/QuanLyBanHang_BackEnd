using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang_BackEnd.Models
{
    public class HangHoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHangHoa { get; set; }

        [Required]
        [MaxLength(250)]
        public string TenHangHoa { get; set; }

        [Required]
        public int IdDonViTinh { get; set; }

        [Required]
        public int IdNhaCungCap { get; set; }

        [Required]
        public int IdLoaiHang { get; set; }

        [Required]
        public int IdNhomHang { get; set; }

        public string Barcode { get; set; }

        [Required]
        public int MaVatVao { get; set; }

        [Required]
        public int MaVatRa { get; set; }

        [Required]
        [MaxLength(5)]
        public string MaDonVi { get; set; }
        public virtual ICollection<HangHoa_GiaBan> HangHoa_GiaBans { get; set; }

    }
}
