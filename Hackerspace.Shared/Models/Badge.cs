using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerspace.Shared.Models
{
    public class Badge
    {
        //? is null so you see wheater data  field is empty haven't had anything put in it
        public Guid Id { get; set; }   
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? TurnInInstructions { get; set; }
        public bool? IsVisible { get; set; }
    }
}
