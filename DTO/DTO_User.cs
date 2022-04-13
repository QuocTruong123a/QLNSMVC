using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        private int DTO_Id;
        private string DTO_UserName;
        private string DTO_Pass;
        private int DTO_Quyen;
        private string DTO_TenQuyen;
        private string DTO_NgayTao;

        public int _Id
        {
            get
            {
                return DTO_Id;
            }
            set
            {
                DTO_Id = value;
            }
        }
        public string _UserName
        {
            get
            {
                return DTO_UserName;
            }
            set
            {
                DTO_UserName = value;
            }
        }
        public string _Pass
        {
            get
            {
                return DTO_Pass;
            }
            set
            {
                DTO_Pass = value;
            }
        }
        public int _Quyen
        {
            get
            {
                return DTO_Quyen;
            }
            set
            {
                DTO_Quyen = value;
            }
        }
        public string _TenQuyen
        {
            get
            {
                return DTO_TenQuyen;
            }
            set
            {
                DTO_TenQuyen = value;
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
        public DTO_User(int Id,string UserName, string Pass, int Quyen, string TenQuyen, string NgayTao)
        {
            this.DTO_Id = Id;
            this.DTO_UserName = UserName;
            this.DTO_Pass = Pass;
            this.DTO_Quyen = Quyen;
            this.DTO_TenQuyen = TenQuyen;
            this.DTO_NgayTao = NgayTao;
        }
    }
}
