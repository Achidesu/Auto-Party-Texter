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
                Debug.WriteLine("[Debug] Hardcore mode.");
            }
            if (HCMODE.Checked == false)
            {
                Player4CHECK.Visible = true;
                Debug.WriteLine("[Debug] Normal mode.");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (Player4CHECK.Checked == true)
            {
                Debug.WriteLine("[Debug] Player_4 Checked.");
            }
            else if (Player4CHECK.Checked == false)
            {
                Debug.WriteLine("[Debug] Player_4 Unchecked.");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Player1CHECK.Checked == true)
            {
                Debug.WriteLine("[Debug] Player_1 Checked.");
            }
            else if (Player1CHECK.Checked == false)
            {
                Debug.WriteLine("[Debug] Player_1 Unchecked.");
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
                Debug.WriteLine("[Debug] Missing Strategy Name");
                Error = 1;
            }
            // StratLink Part
            string StratLink = "NULL";
            StratLink = StratLink_Box.Text;
            if (StratLink_Box.Text == "")
            {
                MessageBox.Show("Enter a strategy link.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("[Debug] Missing Strategy Link.");
                Error = 1;
            }
            // Player Part
            string Player_1 = "Open :green_circle:";
            if (Player1CHECK.Checked == true)
            {
                Player_1 = "Close :red_circle:";
                Debug.WriteLine("[Debug] Player_1 is checked and ready.");
            }
            string Player_2 = "Open :green_circle:";
            if (Player2CHECK.Checked == true)
            {
                Player_2 = "Close :red_circle:";
                Debug.WriteLine("[Debug] Player_2 is checked and ready.");
            }
            string Player_3 = "Open :green_circle:";
            if (Player3CHECK.Checked == true)
            {
                Player_3 = "Close :red_circle:";
                Debug.WriteLine("[Debug] Player_3 is checked and ready.");
            }
            string Player_4 = "Open :green_circle:";
            if (Player4CHECK.Checked == true)
            {
                Player_4 = "Close :red_circle:";
                Debug.WriteLine("[Debug] Player_4 is checked and ready.");
            }
            //
            //Final Part
            string Requirements_Text = Requirements_Box.Text;
            if (HCMODE.Checked == true)
            {
                if (Requirements_Text == "")
                {
                    Final_Box.Text = "Hosting " + StratName
                        + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                        + Environment.NewLine + "Player 1 : " + Player_1
                        + Environment.NewLine + "Player 2 : " + Player_2
                        + Environment.NewLine + "Player 3 : " + Player_3;
                }
                else
                {
                    Final_Box.Text = "Hosting " + StratName
                        + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                        + Environment.NewLine + "Player 1 : " + Player_1
                        + Environment.NewLine + "Player 2 : " + Player_2
                        + Environment.NewLine + "Player 3 : " + Player_3
                        + Environment.NewLine + "Requirements : " + Requirements_Text;
                }
            }
            else if (HCMODE.Checked == false)
            {
                if (Requirements_Text == "")
                {
                    Final_Box.Text = "Hosting " + StratName
                        + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                        + Environment.NewLine + "Player 1 : " + Player_1
                        + Environment.NewLine + "Player 2 : " + Player_2
                        + Environment.NewLine + "Player 3 : " + Player_3
                        + Environment.NewLine + "Player 4 : " + Player_4;
                }
                else
                {
                    Final_Box.Text = "Hosting " + StratName
                        + Environment.NewLine + "Strategy Link : **" + StratLink + "**"
                        + Environment.NewLine + "Player 1 : " + Player_1
                        + Environment.NewLine + "Player 2 : " + Player_2
                        + Environment.NewLine + "Player 3 : " + Player_3
                        + Environment.NewLine + "Player 4 : " + Player_4
                        + Environment.NewLine + "Requirements : " + Requirements_Text;
                }
            }
            if (Error == 1)
            {
                Final_Box.Text = "Something error.";
            }
            Debug.WriteLine("[Debug] Text Created.");
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
            string StratName_Data = "Null";
            string StratLink_Data = "Null";
            if (pop_strat.SelectedItem == "Lucille HC")
            {
                HCMODE.Checked = true;
                StratName_Data = "Lucille Hardcore.";
                StratLink_Data = "https://docs.google.com/document/d/1NOE7FtL-l8T23LbuK-XHYb3YwFhv_EkL6FnHPrcSih4/edit?usp=sharing";
                Debug.WriteLine("[Debug] Lucille Selected.");
            }
            else if (pop_strat.SelectedItem == "Cyber SPAM")
            {
                HCMODE.Checked = true;
                StratName_Data = "Cyber SPAM.";
                StratLink_Data = "https://docs.google.com/document/d/1ox-6_y7HeO03BRjg_FWp2UMb3BHfOGfCrJyaJaWd1eM/edit?usp=sharing";
                Debug.WriteLine("[Debug] Cyber SPAM Selected.");
            }
            else if (pop_strat.SelectedItem == "Unknown SPAM")
            {
                HCMODE.Checked = true;
                StratName_Data = "Unknown SPAM.";
                StratLink_Data = "https://docs.google.com/document/d/1Ci9eAHTHygTfqiyzQh0IuGX-hWiceRgV0ju_Svue2uU/edit?usp=sharing";
                Debug.WriteLine("[Debug] Unknown SPAM Selected.");
            }
            else if (pop_strat.SelectedItem == "Nether SPAM")
            {
                HCMODE.Checked = true;
                StratName_Data = "Nether SPAM.";
                StratLink_Data = "https://docs.google.com/document/d/1mAt1AsnvRe7CcwVyEcevtWUQNi20OWoocIima5Wx5gU/edit?usp=sharing";
                Debug.WriteLine("[Debug] Nether SPAM Selected.");
            }
            StratName_Box.Text = StratName_Data;
            StratLink_Box.Text = StratLink_Data;
        }

        private void Player2CHECK_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2CHECK.Checked == true)
            {
                Debug.WriteLine("[Debug] Player_2 Checked.");
            }
            else if (Player2CHECK.Checked == false)
            {
                Debug.WriteLine("[Debug] Player_2 Unchecked.");
            }
        }

        private void Player3CHECK_CheckedChanged(object sender, EventArgs e)
        {
            if (Player3CHECK.Checked == true)
            {
                Debug.WriteLine("[Debug] Player_3 Checked.");
            }
            else if (Player3CHECK.Checked == false)
            {
                Debug.WriteLine("[Debug] Player_3 Unchecked.");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StratName_Box.Text = "";
            StratLink_Box.Text = "";
            Final_Box.Text = "";
            pop_strat.Text = "";
            Requirements_Box.Text = "";
            CHECK13.Checked = false;
            Player1CHECK.Checked = false;
            Player2CHECK.Checked = false;
            Player3CHECK.Checked = false;
            Player4CHECK.Checked = false;
            Debug.WriteLine("[Debug] Cleared all text.");
        }

        private void Final_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Final_Box.Text == "")
            {
                MessageBox.Show("Enter info first before copy.", "Wraning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("[Debug] Copy text fail.");
            }
            else
            {
                Clipboard.SetText(Final_Box.Text);
                Debug.WriteLine("[Debug] Text has been copy.");
            }
        }
    }
}
