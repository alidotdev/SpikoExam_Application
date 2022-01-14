using SpikoDesktop.Models;
using SpikoDesktop.Services.WebServices;
using SpikoDesktop.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.UI
{
    public partial class ProfilePanel : UserControl
    {
        public ProfilePanel()
        {
            InitializeComponent();
            Profile p = ProfileUtility.GetInstance().currentProfile;
            FirstNameText.Text = p.FirstName;
            LastNameText.Text = p.LastName;
            EmailText.Text = p.EmailId;
            UserRoleText.Text = p.UserRole;
            UserNameText.Text = p.UserName;
        }
        
        public void SetProfile()
        {
            //Profile f = ProfileService.GetInstance().GetProfile();
            //FirstNameTextBox.Text = f.FirstName;
            //LastNameTextBox.Text = f.LastName;
            //EmailTextBox.Text = f.EmailId;
            //UserRoleTextBox.Text = f.UserRole;
        }
       
    }
}
