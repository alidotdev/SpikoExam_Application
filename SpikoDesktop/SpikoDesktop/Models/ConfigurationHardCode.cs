using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Models
{
    class ConfigurationHardCode
    {
        public void BasicTemplateChecker()
        {
            if (File.Exists(@"../../../Program Files/ConfigurationData.txt"))
            {
                //MessageBox.Show("Loading file template");
                LoadTemplate();
            }
            else
            {
                //MessageBox.Show("Creating File Template");
                CreatTemplate();
                InstructionFileCreator();
            }
        }

        public void LoadTemplate()
        {
            Configuration c = Configuration.getInstance();
            //MessageBox.Show("Loaading data from ConfigurationData.txt");
            string data = File.ReadAllText(@"../../../Program Files/ConfigurationData.txt");
            //MessageBox.Show("Data from txt file "+data);
            string[] allData = data.Split('\n');
            //MessageBox.Show("Count of constants : " + allData.Length);
            for (int i = 0; i < allData.Length ; i++)
            {
                //MessageBox.Show(allData[i]);
                string[] keys = allData[i].Split(',');
                //MessageBox.Show(keys + "");
                //MessageBox.Show("keys[0] : " + keys[0]);
                //MessageBox.Show("keys[1] : " + keys[1]);
                c.setValue(keys[0], keys[1]);
            }
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //if (File.Exists("log.txt"))
            //{
            //    File.Delete("log.txt");
            //}
        }

        public void CreatTemplate()
        {
            Configuration c = Configuration.getInstance();
            string path = @"../../../Program Files/ConfigurationData.txt";
            c.setValue("SavingPath", @"../../../Program Files/");
            c.setValue("BaseUrl", "http://exako.spikotech.com/");
            c.setValue("UsersBasePath", @"../../Users/");

            //c.setValue("BaseUrl", "http://exam.spikotech.com/");
            //MessageBox.Show("I am creating file of configuration");

            for (int i = 0; i < c.data.Count; i++)
            {
                string key = (c.data.ElementAt(i).Key);
                string value = (c.data.ElementAt(i).Value);
                if (i == 0)
                {
                    File.AppendAllText(path, key + "," + value);
                }
                else
                {
                    File.AppendAllText(path, "\n"+key + "," + value);
                }
            }
        }

        public void InstructionFileCreator()
        {
            File.WriteAllText(@"../../../Program Files/Instruction.txt", "Required version of Safe Browser (2.4.1) must be installed on the Laptop." +
                " If any other version of Safe Exam Broswer is installed, please un-install it and download," +
                "\n\nAfter Installing the Safe Exam Browser, Download the File and Double Click to Start the Exam" +
                "\nStudents are required to Login at least 15 minutes before the start of Examinations to ensure course enrollment." +
                "\nStudents must have stable internet connection preferably with UPS backup" +
                "\nWebcam is mandatory.Without camera examination will not start." +
                "\nStudent must have peaceful environment and No one should be around the students at the time of Examinations." +
                "If anyone else found around the student, the examination of the student will not be considered valid and stand cancelled." +
                "\n\nHow to Attempt MCQs:\nEach Paper / Exam is of 60 minutes’ duration having 60 MCQs." +
                "Students are required to attempt ‘60’ MCQs in 60 minutes." +
                "\n\nWhat if Paper / Exam Remains Incomplete due to any technical reason:" +
                "\nIf students’ session / examinations terminates due to any technical reason," +
                " he will be allowed to login again on resumption of his internet / electricity" +
                " only if it happens with in examinations allotted time and his examination will resume from where it was terminated.");
        }


    }
}
