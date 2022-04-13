using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_BacLuong
    {
        private string DTO_MaLuong;
        private int DTO_LCB;
        private string DTO_NgayTao;
        public string _MaLuong
        {
            get
            {
                return DTO_MaLuong;
            }
            set
            {
                DTO_MaLuong = value;
            }
        }
        public int _LCB
        {
            get
            {
                return DTO_LCB;
            }
            set
            {
                DTO_LCB = value;
            }
        }
        public string _NgayTao
        {
            get
            {
                return DTO_NgayTao;
            }
            set
            {
                DTO_NgayTao = value;
            }
        }
        public DTO_BacLuong(string MaLuong , int LCB, string NgayTao)
        {
            this.DTO_MaLuong = MaLuong;
            this.DTO_LCB = LCB;
            this.DTO_NgayTao = NgayTao;
        }
    }
}
