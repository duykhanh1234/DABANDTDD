using Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDangKyRepository
    {
        int Insert(User user);

        int KiemTraUserName(string userName);

    }

    public class DangKyRepository : IDangKyRepository
    {
        DienThoaiDbContext db;

        public DangKyRepository()
        {
            db = new DienThoaiDbContext();
        }

        public DangKyRepository(DienThoaiDbContext context)
        {
            db = context;
        }

        public int Insert(User user)
        {
            user.NgayTao = DateTime.Now;
            var dangKy = db.Users.Add(user);
            db.SaveChanges();

            if (dangKy.Id > 0)
            {
                return 1;
            }
            else
            {
                return 0;

            }
        }

        public int KiemTraUserName(string userName)
        {
            var userNameTonTai = db.Users.Where(x => x.UserName == userName).Any();
            if (userNameTonTai)
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
