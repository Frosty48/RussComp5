using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerspace.Shared.Models
{
    public class ToDo
    {

        public int? Id;
        public String? Title;
        public String? Description;
        public DateTime? CreateDate { get; set; }
        public bool? Complete;
        public DateTime? CloseDate { get; set; }
        public String? Notes;
    }
}
