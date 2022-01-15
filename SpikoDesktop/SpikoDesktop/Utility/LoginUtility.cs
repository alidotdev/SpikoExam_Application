using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Utility
{
    class LoginUtility
    {
        public List<Login> loginCrdentials = new List<Login>();
        private static LoginUtility _instance;

        private LoginUtility()
        {
            loginCrdentials = new List<Login>();
        }
        public static LoginUtility GetLoginUtility()
        {
            if (_instance == null)
            {
                _instance = new LoginUtility();
            }
            return _instance;
        }

        public int CheckEmail(String mail)
        {
            for (int i = 0; i < loginCrdentials.Count; i++)
            {
                Login crdential = loginCrdentials[i];
                if (crdential.Email == mail)
                {
                    return i;
                }
            }
            return -1;
        }

        public void LogoutUser()
        {
            //MessageBox.Show("Logout user called");
            Services.LoginWebService.GetService().Token = null;
            ProfileUtility p = ProfileUtility.GetInstance();
            string[] files = { "Token.txt", p.currentUserPath + "Token.txt" };
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            p.currentProfile = null;
            //AttemptExamUtility.GetInstance().listOfExams = null;
            //List<Questions> q = QuestionUtil.GetInstance().GetQList();
            //q = null;
        }
    }
}
