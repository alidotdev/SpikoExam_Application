using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Services.WebServices
{
    class ProfileService
    {
        #region Singleton Class
        static private ProfileService instance = null;
        private ProfileService() { }

        static public ProfileService GetInstance()
        {
            if (instance == null)
            {
                instance = new ProfileService();
            }
            return instance;
        }
        #endregion
        public Profile GetProfile(String username)
        {
            Profile f = new Profile();
            string data = File.ReadAllText(@Configuration.getInstance().getValue("UsersBasePath") + username + @"\Profile.txt");
            string[] p = data.Split(',');
            f.FirstName = p[0];
            f.LastName = p[1];
            f.EmailId = p[2];
            f.UserRole = p[3];
            f.UserName = p[4];
            return f;
        }

        public void CreatProfile(Profile p)
        {
            string dir = Configuration.getInstance().getValue("UsersBasePath") + p.UserName.ToLower(); // If directory does not exist, create it.
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                //AddDirectorySecurity(dir, @"MYDOMAIN\MyAccount", FileSystemRights.ReadData, AccessControlType.Allow);
            }
            File.WriteAllText(@dir + @"\Profile.txt", p.FirstName + "," + p.LastName + "," + p.EmailId + "," + p.UserRole + "," + p.UserName);
            string token = File.ReadAllText("Token.txt");
            File.WriteAllText(@dir+@"\token.txt",token);
        }
    }

}
