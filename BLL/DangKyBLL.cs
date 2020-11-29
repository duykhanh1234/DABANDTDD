using DAL;
using Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class DangKyBLL
    {
        public IDangKyRepository DangKy;

        public DangKyBLL()
        {
            DangKy = new DangKyRepository();
        }

        public DangKyBLL(IDangKyRepository DangKy)
        {
            this.DangKy = DangKy;

        }

        public int Insert(User user)
        {
            try
            {
                return this.DangKy.Insert(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int KiemTraUserName(string userName)
        {
            try
            {
                return this.DangKy.KiemTraUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
