using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Media;

namespace Party_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (HCMODE.Checked == true)
            {
                Player4CHECK.Visible = false;
            }
            if (HCMODE.Checked == false)
            {
                Player4CHECK.Visible = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (Player4CHECK.Checked == true)
            {
                Debug.WriteLine("Player_4 Checked.");
            }
            else if (Player4CHECK.Checked == false)
            {
                Debug.WriteLine("Player_4 Unchecked.");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Player1CHECK.Checked == true)
            {
                Debug.WriteLine("Player_1 Checked.");
            }
            else if (Player1CHECK.Checked == false)
            {
                Debug.WriteLine("Player_1 Unchecked.");
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            int Error = 0;
            // StratName Part
            string StratName = "NULL";
            StratName = StratName_Box.Text;
            if (StratName_Box.Text == "")
            {
                MessageBox.Show("Enter a strategy name.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("Missing StrategyName");
                Error = 1;
            }
            // StratLink Part
            string StratLink = "NULL";
            StratLink = StratLink_Box.Text;
            if (StratLink_Box.Text == "")
            {
                MessageBox.Show("Enter a strategy link.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("Missing StrategyLink");
                Error = 1;
            }
            // Player Part
            string Player_1 = "Open :green_circle:";
            if (Player1CHECK.Checked == true)
            {
                Player_1 = "Close :red_circle:";
                Debug.WriteLine("Player_1 is checked and ready.");
            }
            string Player_2 = "Open :green_circle:";
            if (Player2CHECK.Checked == true)
            {
                Player_2 = "Close :red_circle:";
                Debug.WriteLine("Player_2 is checked and ready.");
            }
            string Player_3 = "Open :green_circle:";
            if (Player3CHECK.Checked == true)
            {
                Player_3 = "Close :red_circle:";
                Debug.WriteLine("Player_3 is checked and ready.");
            }
            string Player_4 = "Open :green_circle:";
            if (Player4CHECK.Checked == true)
            {
                Player_4 = "Close :red_circle:";
                Debug.WriteLine("Player_4 is checked and ready.");
            }
            //
            //Final Part
            if (HCMODE.Checked == true)
            {
                Final_Box.Text = "Hosting " + StratName
                    + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                    + Environment.NewLine + "Player 1 : " + Player_1
                    + Environment.NewLine + "Player 2 : " + Player_2
                    + Environment.NewLine + "Player 3 : " + Player_3;
            }
            else if (HCMODE.Checked == false) 
            {
                Final_Box.Text = "Hosting " + StratName
                    + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                    + Environment.NewLine + "Player 1 : " + Player_1
                    + Environment.NewLine + "Player 2 : " + Player_2
                    + Environment.NewLine + "Player 3 : " + Player_3
                    + Environment.NewLine + "Player 4 : " + Player_4;
            }
            if (Error == 1)
            {
                Final_Box.Text = "Something error.";
            }
            Debug.WriteLine("Text Created.");
        }

        private void CHECK13_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK13.Checked == true)
            {
                Requirements_Box.Text = "Need to be 13+";
            }
        }

        private void Requirements_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pop_strat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pop_strat.Text == "Lucille HC")
            {
                HCMODE.Checked = true;
                StratName_Box.Text = "Lucille Hardcore.";
                StratLink_Box.Text = "https://docs.google.com/document/d/1NOE7FtL-l8T23LbuK-XHYb3YwFhv_EkL6FnHPrcSih4/edit?usp=sharing";
                Debug.WriteLine("Lucille Selected.");
            }
        }

        private void Player2CHECK_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2CHECK.Checked == true)
            {
                Debug.WriteLine("Player_2 Checked.");
            }
            else if (Player2CHECK.Checked == false)
            {
                Debug.WriteLine("Player_2 Unchecked.");
            }
        }

        private void Player3CHECK_CheckedChanged(object sender, EventArgs e)
        {
            if(Player3CHECK.Checked == true)
            {
                Debug.WriteLine("Player_3 Checked.");
            }
            else if (Player3CHECK.Checked == false)
            {
                Debug.WriteLine("Player_3 Unchecked.");
            }
        }
    }
}
