using Domen.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Concrete
{
    public class EfUserRepository
    {
        readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<User> Users
        {
            get { return _context.Users.ToList(); }
        }

        public int AddUser (User user) 
        {
            //validation
            _context.Users.Add(user);            
            _context.SaveChanges();

            return user.UserID;
        }
        public void DelUser(int id)
        {
            var us = _context.Users.FirstOrDefault(x => x.UserID == id);

            if (us != null) 
            {
                _context.Users.Remove(us);
                _context.SaveChanges();
            }
        }
    }
}
