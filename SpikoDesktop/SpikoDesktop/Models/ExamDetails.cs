using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Models
{
    class ExamDetails : Exam
    {
        public string Description { get; set; }
        public string AddedBy { get; set; }
        public string Email { get; set; }
        public ExamSetting ExamSettings { get; set; }

    }
    internal class ExamSetting
    {
        public int TotalMarks { get; set; }     //total marks of the exam
        public int TotalWeightage { get; set; } //weightage of the exam
        public int TimeAllowed { get; set; }    //time allowed in minutes
        
    }
}
