using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Utility
{
    class ProfileUtility
    {
        private Profile _currentProfile;
        public Profile currentProfile
        {
            get
            {
                return _currentProfile;
            }
            set
            {
                _currentProfile = value;
                //MessageBox.Show(value.ToString()+ "\n"+value.UserName);
                if (_currentProfile == null)
                {
                    currentUserPath = null;
                }
                else
                {
                    string username = _currentProfile.UserName;
                    currentUserPath = Configuration.getInstance().getValue("UsersBasePath") + username.ToLower() + @"\";
                }
                
            }
        }

        public string currentUserPath { get; private set; }

        #region Singleton
        static private ProfileUtility _instance;
        static public ProfileUtility GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProfileUtility();
            }
            return _instance;
        }

        private ProfileUtility() { }
        #endregion



    }
}
