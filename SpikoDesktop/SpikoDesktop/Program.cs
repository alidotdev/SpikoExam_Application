using SpikoDesktop.Models;
using SpikoDesktop.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

//[assembly: log4net.Config.XmlConfigurator(ConfigFile = ".config", Watch = true)]

namespace SpikoDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);
                //Configuration.getInstance().LoadConfiguration();

                //Configuration.getInstance().setValue("BaseUrl","http://exam.spikotech.com/");
                //Configuration.getInstance().setValue("SavingPath", @"..\..\..\Program Files\");
                //Configuration.getInstance().setValue("Instruction", File.ReadAllText(@"..\..\..\Program Files\Instructions.txt"));

                //Configuration.getInstance().SaveConfiguration();

                //Application.Run(new Dashboard2());
                //Application.Run(new DashboardForm());
                Application.Run(LoginForm.GetInstace());
                //Application.Run(Dashboard2.GetInstance());
                //Application.Run(TestSettings.GetInstance());
                //Application.Run(new QuestionsForm());
                //Application.Run(new Instructions());
                //Application.Run(new Rough());
            }

            catch (Exception ex)
            {
                //Write ex.Message to a file
                using (StreamWriter outfile = new StreamWriter(@".\error.txt"))
                {
                    outfile.Write(ex.Message.ToString());
                }
            }
        }


    }
}

