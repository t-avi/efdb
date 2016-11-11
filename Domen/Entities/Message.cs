using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public User UserAutor { get; set; }
        public User UserReciver { get; set; }
        public string Content { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDateTime { get; set; }
    }
}
