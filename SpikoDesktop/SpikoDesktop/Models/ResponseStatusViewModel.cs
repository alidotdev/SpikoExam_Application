using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Models
{
    class ResponseStatusViewModel
    {
        public bool status { get; set; }
        public String Message { get; set; }
        public object Data { get; set; }
    }
}
