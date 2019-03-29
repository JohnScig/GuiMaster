using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetInitialFont();
            LoadColourComboBox();
            LoadWordListBox();

            pBox.ImageLocation = "good.jpg";
            chBox_Enabled.Checked = true;
            tBox_Text.Text = "Hello peasants!";

        }

        int pictureBoxCounter = 1;

        private void LoadColourComboBox()
        {
            cBox_Colours.Items.Add("Black");
            cBox_Colours.Items.Add("Red");
            cBox_Colours.Items.Add("Green");
            cBox_Colours.Items.Add("Blue");
        }

        private void LoadWordListBox()
        {
            string[] words = null;
            words = tBox_Text.Text.Split(' ');
            lBox01.Items.Clear();
            foreach (string item in words)
            {
                lBox01.Items.Add(item);
            }
            
        }

        private void SetInitialFont()
        {
            if (rBtn_MSSF.Checked) { tBox_Text.Font = new Font("Microsoft Sans Serif", (int) (numeric_Size.Value)); }
            if (rBtn_Arial.Checked) { tBox_Text.Font = new Font("Arial", (int)(numeric_Size.Value)); }
            if (rBtn_ComicSans.Checked) { tBox_Text.Font = new Font("Comic Sans MS", (int)(numeric_Size.Value)); }
        }

        private void tBox_Text_TextChanged(object sender, EventArgs e)
        {
            lbl_textCount.Text = tBox_Text.Text.Length.ToString();
        }

        private void rBtn_MSSF_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Font = new Font("Microsoft Sans Serif", (int)(numeric_Size.Value));
        }

        private void rBtn_Arial_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Font = new Font("Arial", (int)(numeric_Size.Value));
        }

        private void rBtn_ComicSans_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Font = new Font("Comic Sans MS", (int)(numeric_Size.Value));
        }

        private void numeric_Size_ValueChanged(object sender, EventArgs e)
        {
            if ((int) numeric_Size.Value <= 0)
            {
                numeric_Size.Value = 1;
            }
            tBox_Text.Font = new Font(Font.Name, (int)numeric_Size.Value);
        }

        private void cBox_Colours_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBox_Colours.SelectedItem)
            {
                case ("Black"): { tBox_Text.ForeColor = Color.Black; break; }
                case ("Red"): { tBox_Text.ForeColor = Color.Red; break; }
                case ("Green"): { tBox_Text.ForeColor = Color.Green; break; }
                case ("Blue"): { tBox_Text.ForeColor = Color.Blue; break; }
                default: tBox_Text.ForeColor = Color.Black; break;
            }
        }

        private void rButton_Up_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Dock = DockStyle.Top;
        }

        private void rButton_Down_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Dock = DockStyle.Bottom;
        }

        private void rButton_Left_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Dock = DockStyle.Left;
        }

        private void rButton_Right_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Dock = DockStyle.Right;
        }

        private void rButton_None_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.Dock = DockStyle.None;
        }

        private void chBox_ReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            tBox_Text.ReadOnly = chBox_ReadOnly.Checked;
        }

        private void chBox_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = chBox_Enabled.Checked;
            }
            chBox_Enabled.Enabled = true;
        }

        private void pBox_Click(object sender, EventArgs e)
        {
            if (pictureBoxCounter % 2 == 0)
            {
                pBox.ImageLocation = "good.jpg";
            }
            else
            {
                pBox.ImageLocation = "bad.jpg";
            }
            pictureBoxCounter++;
        }

        private void btn_progBar_Click(object sender, EventArgs e)
        {
            if (progBar.Value < 100)
            {
                progBar.Value+=10;
            }
            else
            {
                progBar.Value = 0;
            }
        }

        private void btn_listBox_Click(object sender, EventArgs e)
        {
            LoadWordListBox();
        }

        private void panel_Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_MouseMove.Text = e.Location.ToString();
        }

        private void lBox01_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_NumOfWords.Text = lBox01.SelectedItem.ToString();
        }
    }
}
