using Domen.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Concrete
{
    //Происходит типо связывание объектов с ДБ (вроде как создаются таблицы)
    public class EfDbContext: DbContext
    {
        public EfDbContext()
            : base("Data Source=PC;Initial Catalog=ArtDB;Persist Security Info=True;User ID=tavi;Password=123456")
        {

        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
