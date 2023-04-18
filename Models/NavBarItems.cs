using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulerHubLibrary.Models
{
    public partial class NavBarItems
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string OiItem { get; set; } = null!;
        public string Ref { get; set; } = null!; 
    }
}
