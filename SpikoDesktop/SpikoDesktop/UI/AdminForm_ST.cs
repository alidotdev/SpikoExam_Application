using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SpikoDesktop.Services;

namespace SpikoDesktop.UI
{
    public partial class AdminForm_ST : Form
    {
        const int pictureCol = 4;
        public AdminForm_ST()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string data =File.ReadAllText(@"..\..\..\Program Files\Data.csv");
            string[] DATA = data.Split('\n');
            for (int i = 0; i < DATA.Length; i++)
            {
                if (string.IsNullOrEmpty(DATA[i]))
                {
                    table.Rows.Add();
                    continue;
                }


                string[] token = DATA[i].Split(',');
                
                if (token.Length == 5)
                {
                    table.Rows.Add(token[0], token[1], token[2], token[3], Crypto.GetInstance().Base64ToImage(token[4]));
                }
                else
                {
                    table.Rows.Add(token);
                }
                //if (true)
                //{

                //}
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col == pictureCol)
            {
                int row = e.RowIndex;
                
                //MessageBox.Show("" + table[col, row].GetType());
                if (table[pictureCol, row].Value != null)
                {

                    //MessageBox.Show("Row : " + row + "\nColumn : " + col);
                    ScreenShotDisplay.GetInstance((Image)table[pictureCol, row].Value, row, this).Show();
                    
                    //PicturePopUp popUp = PicturePopUp.GetInstance(null, (Image)table[col, row].Value, this.Location);
                    //PicturePopUp.ShowBgForm();
                    //popUp.StartPosition = FormStartPosition.CenterScreen;
                    //popUp.Show();
                }

            }
        }

        public int GetNextImageRowIndex (int rowIndex)
        {
            //Image img = (Image)table[pictureCol, rowIndex].Value;
            int totalRows = table.Rows.Count;

            //MessageBox.Show("total rows : " + totalRows + "\ncurrent index : " + rowIndex);
            for (int i =  rowIndex+1; i < totalRows; i++)
            {
                //MessageBox.Show(table[pictureCol, rowIndex].Value+ "");
                if (table[pictureCol, i].Value != null)
                {
                    return i;
                }
            }
            //MessageBox.Show("Value of i after loop " + i) ;
            return rowIndex;
        }
        
        public int GetPreviousImageRowIndex (int rowIndex )
        {
            for (int i = rowIndex -1; i >= 0; i--)
            {
                if (table[pictureCol, i].Value != null)
                    return i;
            }
            return rowIndex;
        }

        public Image GetImge (int rowIndex )
        {
            return (Image)table[pictureCol, rowIndex].Value;
        }
    }
}
