using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TTNhanVien : DAL_Connection
    {
        public bool Them(DTO_TTNhanVien nv)
        {
            string sql = string.Format("insert into TTNhanVien(MaNV, HoTen, CMTND, NoiCap, GioiTinh, NoiSinh, NgaySinh, DCThuongTru, DCTamTru, SDT, DanToc, TonGiao, QuocTich, HocVan, GhiChu) values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}',N'{7}',N'{8}','{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}')",nv._MaNV,nv._HoTen,nv._CMTND,nv._NoiCap,nv._GioiTinh,nv._NoiSinh,nv._NgaySinh,nv._DCThuoungTru,nv._DCTamTru,nv._SDT,nv._DanToc,nv._TonGiao,nv._QuocTich,nv._HocVan,nv._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_TTNhanVien nv)
        {
            string sql = string.Format("update TTNhanVien set HoTen=N'{0}', CMTND='{1}', NoiCap=N'{2}', GioiTinh=N'{3}', NoiSinh=N'{4}', NgaySinh='{5}', DCThuongTru=N'{6}', DCTamTru=N'{7}', SDT='{8}', DanToc=N'{9}', TonGiao=N'{10}', QuocTich=N'{11}', HocVan=N'{12}', GhiChu=N'{13}' where MaNV ='{14}'", nv._HoTen, nv._CMTND, nv._NoiCap, nv._GioiTinh, nv._NoiSinh, nv._NgaySinh, nv._DCThuoungTru, nv._DCTamTru, nv._SDT, nv._DanToc, nv._TonGiao, nv._QuocTich, nv._HocVan, nv._GhiChu, nv._MaNV);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from TTNhanVien where MaNV='{0}'",ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
