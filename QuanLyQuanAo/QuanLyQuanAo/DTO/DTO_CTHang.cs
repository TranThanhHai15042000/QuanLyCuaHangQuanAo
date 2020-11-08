using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DTO
{
    class DTO_CTHang
    {
        private string _idCTHang;
        private string _Ten;
        private string _Size;
        private string _KieuDang;
        private string _ChatLieu;
        private string _Anh;
        private string _GhiChu;

        public string IdCTHang { get => _idCTHang; set => _idCTHang = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string Size { get => _Size; set => _Size = value; }
        public string KieuDang { get => _KieuDang; set => _KieuDang = value; }
        public string ChatLieu { get => _ChatLieu; set => _ChatLieu = value; }
        public string Anh { get => _Anh; set => _Anh = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
