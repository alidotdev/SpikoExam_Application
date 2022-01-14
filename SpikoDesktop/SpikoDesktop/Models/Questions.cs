using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop
{
    public class Questions
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public bool ImgStatus { get; set; }
        public string Img { get; set; }
        public string Statement { get; set; }
        public double Points { get; set; }
        public int QuestionType { get; set; }
        public List<OptionsModel> Options { get; set; }
    }
}
