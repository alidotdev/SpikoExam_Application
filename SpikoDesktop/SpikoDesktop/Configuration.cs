using SpikoDesktop.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Models
{
    public class Configuration
    {
        public Dictionary<String, String> data;
        private static Configuration _instance;

        public static Configuration getInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }

        private Configuration()
        {
            data = new Dictionary<String, String>();
        }

        public void setValue(string key, string val)
        {
            //MessageBox.Show("Key : " + key + " value : " + val);
            data.Add(key, val);
        }

        public String getValue(string key)
        {

            if (data.ContainsKey(key))
            {
                return data[key];
            }
            return "N/A";
            //{
            //    MessageBox.Show(key+" contained by dictionary");
            //}
            //return null;
            //string output;
            //if(data.TryGetValue(key,out output))
            //{
            //    return data[key];
            //}
            //return "N/A";
        }

        public void SaveConfiguration()
        {
            string xml = Crypto.SerializeObject<Configuration>(this);
            File.WriteAllText(@"..\..\..\Program Files\config.xml", xml);
        }
        public void LoadConfiguration()
        {
            _instance = Crypto.GetInstance().FromXml<Configuration>(@"..\..\..\Program Files\config.xml");
        }
    }
}
