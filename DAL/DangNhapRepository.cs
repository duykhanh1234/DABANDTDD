using Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDangNhapRepository
    {
        User DangNhap(string userName, string password);

        int KiemTraDangNhap(string userName, string password);

    }
    public class DangNhapRepository : IDangNhapRepository
    {
        DienThoaiDbContext db;

        public DangNhapRepository()
        {
            db = new DienThoaiDbContext();
        }

        public DangNhapRepository(DienThoaiDbContext context)
        {
            db = context;
        }

        public User DangNhap(string userName, string password)
        {
            var user = db.Users.Where(x => x.UserName == userName && x.Password == password).SingleOrDefault();
            return user;
        }

        public int KiemTraDangNhap(string userName, string password)
        {
            var kiemTra = db.Users.Where(x => x.UserName == userName && x.Password == password).Any();

            if (!kiemTra)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
