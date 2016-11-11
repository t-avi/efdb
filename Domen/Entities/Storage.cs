using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Entities
{
    public class Storage
    {
        public int StorageID { get; set; }
        public User Autor { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime CreateDateTime { get; set; }
        public string ContentPath { get; set; }

    }
}
 