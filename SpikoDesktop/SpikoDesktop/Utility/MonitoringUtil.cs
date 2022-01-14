using AForge.Video.DirectShow;
using SpikoDesktop.Models;
using SpikoDesktop.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Utility
{
    class MonitoringUtil
    {
        private string IPAddress;
        public Bitmap embeddedCameraImg;
        public Bitmap embeddedSs;
        public static MonitoringUtil instance;
        static Process[] previous = null;

        private MonitoringUtil() { }
        public static MonitoringUtil GetInstance ()
        {
            if (instance == null)
            {
                instance = new MonitoringUtil();
            }

            return instance;
        }

        public string GetCameraName()
        {
            string path = Configuration.getInstance().getValue("SavingPath") + "CameraName.txt";
            try
            {
                if (!File.Exists(path))
                {
                    //MessageBox.Show("file does not exists");
                    throw new Exception();
                }

                string cameraName = File.ReadAllText(path);

                foreach (FilterInfo filterInfo in new FilterInfoCollection(FilterCategory.VideoInputDevice))
                {
                    //MessageBox.Show( cameraName.Trim() +"\n" + filterInfo.MonikerString );
                    if (string.Equals(cameraName.Trim(), filterInfo.MonikerString))
                    {
                        return cameraName.Trim();
                    }
                }

                throw new Exception();

                //MessageBox.Show(cameraName);
            }
            catch (Exception)
            {
                Logger.log.Error("Camera name is not present in file");
                if (File.Exists(path))
                    File.Delete(path);
                return null;
            }
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        /*private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            img = (Bitmap)pictureBox1.Image;
            pictureBox2.Image = embedText(str, img);
            MessageBox.Show("Text : " + str + "\n is added to iamge");
            textBox1.Text = string.Empty;
        }*/
        public Bitmap embedAddresses(Bitmap bmp)
        {
            string text = String.Empty;
#pragma warning disable CS0612 // Type or member is obsolete
            text = "IP Address: " + GetIPAddress();
            text += "\nHost Name: " + GetHostName();
#pragma warning restore CS0612 // Type or member is obsolete
            text += "\nMAC Address: " + GetMacAddress();

            Logger.log.Info("Staganography is done in image");
            return embedText(text, bmp);
        }

        public Bitmap embedText(string text, Bitmap bmp)
        {
            //if the picture is null, do not process the image
            if (bmp == null)
            {
                return bmp;
            }

            // initially, we'll be hiding characters in the image
            State state = State.Hiding;

            // holds the index of the character that is being hidden
            int charIndex = 0;

            // holds the value of the character converted to integer
            int charValue = 0;

            // holds the index of the color element (R or G or B) that is currently being processed
            long pixelElementIndex = 0;

            // holds the number of trailing zeros that have been added when finishing the process
            int zeros = 0;

            // hold pixel elements
            int R = 0, G = 0, B = 0;

            // pass through the rows
            for (int i = 0; i < bmp.Height; i++)
            {
                // pass through each row
                for (int j = 0; j < bmp.Width; j++)
                {
                    // holds the pixel that is currently being processed
                    Color pixel = bmp.GetPixel(j, i);

                    // now, clear the least significant bit (LSB) from each pixel element
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    // for each pixel, pass through its elements (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        // check if new 8 bits has been processed
                        if (pixelElementIndex % 8 == 0)
                        {
                            // check if the whole process has finished
                            // we can say that it's finished when 8 zeros are added
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                // apply the last pixel on the image
                                // even if only a part of its elements have been affected
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                // return the bitmap with the text hidden in
                                return bmp;
                            }

                            // check if all characters has been hidden
                            if (charIndex >= text.Length)
                            {
                                // start adding zeros to mark the end of the text
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                // move to the next character and process again
                                charValue = text[charIndex++];
                            }
                        }

                        // check which pixel element has the turn to hide a bit in its LSB
                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        // the rightmost bit in the character will be (charValue % 2)
                                        // to put this value instead of the LSB of the pixel element
                                        // just add it to it
                                        // recall that the LSB of the pixel element had been cleared
                                        // before this operation
                                        R += charValue % 2;

                                        // removes the added rightmost bit of the character
                                        // such that next time we can reach the next one
                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {
                            // increment the value of zeros until it is 8
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }

        public string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            // holds the text that will be extracted from the image
            string extractedText = String.Empty;

            // pass through the rows
            for (int i = 0; i < bmp.Height; i++)
            {
                // pass through each row
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    // for each pixel, pass through its elements (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    // get the LSB from the pixel element (will be pixel.R % 2)
                                    // then add one bit to the right of the current character
                                    // this can be done by (charValue = charValue * 2)
                                    // replace the added bit (which value is by default 0) with
                                    // the LSB of the pixel element, simply by addition
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        // if 8 bits has been added, then add the current character to the result text
                        if (colorUnitIndex % 8 == 0)
                        {
                            // reverse? of course, since each time the process happens on the right (for simplicity)
                            charValue = reverseBits(charValue);

                            // can only be 0 if it is the stop character (the 8 zeros)
                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            // convert the character value from int to char
                            char c = (char)charValue;

                            // add the current character to the result text
                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }
        public int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }



        public string GetHostName()
        {
            return Dns.GetHostName();
        }

        //[Obsolete]
        public string GetIPAddress()
        {
            //if IP address is not available and network is connected, take the ip address
            if (IPAddress == null || NetworkInterface.GetIsNetworkAvailable())
            {
                IPAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
                Logger.log.Info("IP address is traced");
            }

            return IPAddress;
        }

        public string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }

            }

            for (int i = macAddresses.Length-2; i > 0; i-= 2)
                macAddresses= macAddresses.Insert(i,":");

            return macAddresses;
        }

        public Bitmap CaptureMyScreen()
        {
            try
            {
                Rectangle screenSize = SystemInformation.WorkingArea;
                //Bitmap screenshot = new Bitmap(screenSize.Width, screenSize.Height);
                Bitmap screenshot = new Bitmap(1920,1080);
                //MessageBox.Show("Screen Width : " + Screen.PrimaryScreen.Bounds.Width);
                //MessageBox.Show("Screen Height : " + Screen.PrimaryScreen.Bounds.Height);
                using (Graphics screenGraph = Graphics.FromImage(screenshot))
                {
                    screenGraph.CopyFromScreen(
                        SystemInformation.VirtualScreen.X,
                        SystemInformation.VirtualScreen.Y,
                        0,
                        0,
                        screenshot.Size,
                        CopyPixelOperation.SourceCopy);
                }
                //MessageBox.Show("Bounds Size : " + SystemInformation.VirtualScreen.Size);
                //string screen = "screenshot.png";
                //screenshot.Save(screen);
                //if (File.Exists(screen))
                //{
                //    //pictureBox1.Image = null;
                //    System.GC.Collect();
                //    System.GC.WaitForPendingFinalizers();
                //    File.Delete(screen);
                //    screenshot.Save(screen);
                //    //pictureBox1.Image = Image.FromFile("Screen.jpg");
                    return screenshot;
                //}
                //else
                //{
                //    //pictureBox1.Image = Image.FromFile("Screen.jpg");
                //    //screenshot.Save("Screen.jpg", ImageFormat.Jpeg);
                //    return (Bitmap)Image.FromFile(screen);
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
        }


        public void Filling()
        {
            MonitoringUtil m = MonitoringUtil.GetInstance();
            bool isOld = false;
            //Image i = GetUserImage();
            //pictureBox1.Image = i;
            //var image = CaptureMyScreen();
            string camera64 = Crypto.GetInstance().ImageToBase64(m.embeddedCameraImg);
            string ss64 = Crypto.GetInstance().ImageToBase64(m.embeddedSs);
            string file = Configuration.getInstance().getValue("SavingPath") + "Data1.csv";
            File.AppendAllText(file, $"{"Date and Time : "},{DateTime.Now},{"Screen short     "},{ss64}, {"Camera Image: "},{camera64}\n");
            File.AppendAllText(file, $"{"Applications"},{"RAM Used in MB"},{"Starting Time"}\n");
            Logger.log.Info("Writing data to csv file");
            Process[] p = Process.GetProcesses();
            if (previous == null)
            {
                foreach (Process s in p)
                {
                    if (s.MainWindowTitle.Length > 0)
                        File.AppendAllText(file, $"{ s.MainWindowTitle },{ String.Format("{0:0.00}", (((double)s.WorkingSet64) / 1024 / 1024)) },{s.StartTime.ToString("dddd dd MMMM yyyy hh:mm:ss tt")}\n\n");
                }
                File.AppendAllText(file, "\n\n");
                previous = p;
            }
            else
            {
                foreach (Process s in p)
                {
                    isOld = true;
                    if (s.MainWindowTitle.Length > 0)
                    {
                        foreach (Process prev in previous)
                        {
                            isOld = true;
                            if (s.Id == prev.Id)
                            {
                                break;
                            }
                            else
                            {
                                isOld = false;
                            }
                        }
                        if (isOld)
                        {
                            string test = $"{ s.MainWindowTitle },{ String.Format("{0:0.00}", ((double)s.WorkingSet64) / 1024 / 1024) },{s.StartTime.ToString("dddd dd MMMM yyyy hh:mm:ss tt")}\n";
                            File.AppendAllText(file, test);
                        }
                        else
                        {
                            string test = $"{ s.MainWindowTitle },{ String.Format("{0:0.00}", (((double)s.WorkingSet64) / 1024 / 1024)) },{s.StartTime.ToString("dddd dd MMMM yyyy hh:mm:ss tt")},{"New"}\n";
                            File.AppendAllText(file, test);
                            isOld = false;
                        }
                    }
                }
                File.AppendAllText(file, "\n\n");
                previous = p;
            }
        }

        public bool NetworkConnectionDetector()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public void DisconnectInternet()
        {
            Logger.log.Info("Network disconnected");
            Process prcsDisocnnect = Process.Start("ipconfig", "/release"); //For disabling internet
            //prcsDisocnnect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //prcsDisocnnect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            
            prcsDisocnnect.WaitForExit();
        }

        public void ConnectInternet ()
        {
            Logger.log.Info("Network enabled");
            Process process = Process.Start("ipconfig", "/renew"); //For enabling internet
            process.WaitForExit();

        }

        public Color getStatusColor ()
        {
            if (NetworkConnectionDetector())
                return Color.FromArgb(0, 255, 0);
            else
                return Color.FromArgb(255, 0, 0);
        }
    }
    
}
