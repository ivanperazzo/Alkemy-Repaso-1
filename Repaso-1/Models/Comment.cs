using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1.Models
{
    class Comments
    {
        public int CommentId { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
    }
}
