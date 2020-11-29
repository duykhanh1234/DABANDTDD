using DAL;
using Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangNhapBLL
    {
        public IDangNhapRepository DangNhapRepo;

        public DangNhapBLL()
        {
            DangNhapRepo = new DangNhapRepository();
        }

        public DangNhapBLL(IDangNhapRepository DangNhap)
        {
            this.DangNhapRepo = DangNhap;

        }

        public int KiemTraDangNhap(string userName, string password)
        {
            try
            {
                return DangNhapRepo.KiemTraDangNhap(userName, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User DangsNhap(string userName, string password)
        {
            try
            {
                return DangNhapRepo.DangNhap(userName, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
