using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop
{
    public class Answer
    {
        public int Id { get; set; }
        //public string Ans { get; set; }
        public List<string> Ans { get; set; }
        public bool isAttempted { get; set; }

        public Answer()
        {
            Ans = new List<string>();
        }
    }
}