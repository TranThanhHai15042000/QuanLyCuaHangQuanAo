using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DTO
{
    public class DTO_Hang
    {
        private int _idHang;
        private int _SoLuong;
        private int _DonGiaNhap;
        private int _DonGiaBan;
        private int idCTHang;

        public int IdHang { get => _idHang; set => _idHang = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGiaNhap { get => _DonGiaNhap; set => _DonGiaNhap = value; }
        public int DonGiaBan { get => _DonGiaBan; set => _DonGiaBan = value; }
        public int IdCTHang { get => idCTHang; set => idCTHang = value; }
    }
}
