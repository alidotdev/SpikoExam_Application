using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Models
{
    class AnswerModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Answer> AnswerList { get; set; }

        public AnswerModel()
        {
            AnswerList = new List<Answer>();
        }
        public AnswerModel(string username = null, int count = 0)
        {
            //AnswerList = new List<Answer>( new Answer[count]);
            AnswerList = new List<Answer>();
            for (int i = 0; i < count; i++)
            {
                AnswerList.Add(new Answer());
            }
            Username = username;
        }
    }
}
