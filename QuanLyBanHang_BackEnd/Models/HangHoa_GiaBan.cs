using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang_BackEnd.Models
{
    public class HangHoa_GiaBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHangHoa_GiaBan { get; set; }

        [Required]
        public int IdHangHoa { get; set; }

        [Required]
        public decimal GiaBanLe { get; set; }

        [Required]
        public decimal GiaBanBuon { get; set; }

        [Required]
        public decimal GiaMua { get; set; }

        [Required]
        public decimal TyLeLaiBuon { get; set; }

        [Required]
        public decimal TyLeLaiLe { get; set; }

        [Required]
        [MaxLength(5)]
        public string MaDonVi { get; set; }

        [Required]
        [MaxLength(5)]
        public string MaDonViCon { get; set; }
        public virtual HangHoa HangHoa { get; set; }

    }
}
