using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BKI_DichVuMatDat.US;
namespace BKI_DichVuMatDat.DTO
{
    public class DTO_QUY_THU_NHAP_KHAC
    {
        public DTO_QUY_THU_NHAP_KHAC()
        {

        }
        public decimal ID { get; set; }
        public string TEN_QUY { get; set; }
        public decimal THANG { get; set; }
        public decimal NAM { get; set; }
        public string NGUOI_LAP { get; set; }
        public DateTime? NGAY_LAP { get; set; }
        public string NGUOI_LAP_PHAN_MEM { get; set; }
        public DateTime? NGAY_LAP_PHAN_MEM { get; set; }

        public DateTime? TU_NGAY_XET_THUONG { get; set; }
        public DateTime? DEN_NGAY_XET_THUONG { get; set; }
        public string LY_DO_THUONG { get; set; }
        public string GHI_CHU { get; set; }
        public string DA_XOA { get; set; }
        public decimal ID_LOAI_THU_NHAP_KHAC { get; set; }

        public decimal SO_LUONG_NV_TRONG_QUY { get; set; }
        public decimal TONG_TIEN { get; set; }
        public decimal TONG_TIEN_NOP_THUE { get; set; }
        public decimal TONG_TIEN_THUC_LINH { get; set; }
        public bool CO_DU_LIEU { get; set; }

        public bool DA_CHOT { get; set; }
    }
}
