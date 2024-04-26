namespace Party_Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            StratName_Box = new TextBox();
            StratLink_Box = new TextBox();
            label2 = new Label();
            HCMODE = new CheckBox();
            Player1CHECK = new CheckBox();
            Player2CHECK = new CheckBox();
            Player3CHECK = new CheckBox();
            Player4CHECK = new CheckBox();
            label3 = new Label();
            Requirements_Box = new TextBox();
            Final_Box = new TextBox();
            Done = new Button();
            CHECK13 = new CheckBox();
            pop_strat = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 100);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Strategy Name";
            label1.Click += label1_Click;
            // 
            // StratName_Box
            // 
            StratName_Box.Location = new Point(192, 97);
            StratName_Box.Name = "StratName_Box";
            StratName_Box.Size = new Size(454, 23);
            StratName_Box.TabIndex = 1;
            StratName_Box.TextChanged += textBox1_TextChanged;
            // 
            // StratLink_Box
            // 
            StratLink_Box.AccessibleName = "StratLink_Box";
            StratLink_Box.Location = new Point(192, 140);
            StratLink_Box.Name = "StratLink_Box";
            StratLink_Box.Size = new Size(454, 23);
            StratLink_Box.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 143);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Strategy Link";
            // 
            // HCMODE
            // 
            HCMODE.AccessibleName = "HCMODECHECK";
            HCMODE.AutoSize = true;
            HCMODE.Location = new Point(12, 12);
            HCMODE.Name = "HCMODE";
            HCMODE.Size = new Size(114, 19);
            HCMODE.TabIndex = 4;
            HCMODE.Text = "Hardcore Mode?\r\n";
            HCMODE.UseVisualStyleBackColor = true;
            HCMODE.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Player1CHECK
            // 
            Player1CHECK.AutoSize = true;
            Player1CHECK.Location = new Point(679, 97);
            Player1CHECK.Name = "Player1CHECK";
            Player1CHECK.Size = new Size(67, 19);
            Player1CHECK.TabIndex = 5;
            Player1CHECK.Text = "Player 1";
            Player1CHECK.UseVisualStyleBackColor = true;
            Player1CHECK.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Player2CHECK
            // 
            Player2CHECK.AutoSize = true;
            Player2CHECK.Location = new Point(679, 122);
            Player2CHECK.Name = "Player2CHECK";
            Player2CHECK.Size = new Size(67, 19);
            Player2CHECK.TabIndex = 6;
            Player2CHECK.Text = "Player 2";
            Player2CHECK.UseVisualStyleBackColor = true;
            Player2CHECK.CheckedChanged += Player2CHECK_CheckedChanged;
            // 
            // Player3CHECK
            // 
            Player3CHECK.AutoSize = true;
            Player3CHECK.Location = new Point(679, 147);
            Player3CHECK.Name = "Player3CHECK";
            Player3CHECK.Size = new Size(67, 19);
            Player3CHECK.TabIndex = 7;
            Player3CHECK.Text = "Player 3";
            Player3CHECK.UseVisualStyleBackColor = true;
            Player3CHECK.CheckedChanged += Player3CHECK_CheckedChanged;
            // 
            // Player4CHECK
            // 
            Player4CHECK.AccessibleName = "Player4CHECK";
            Player4CHECK.AutoSize = true;
            Player4CHECK.Location = new Point(679, 172);
            Player4CHECK.Name = "Player4CHECK";
            Player4CHECK.Size = new Size(67, 19);
            Player4CHECK.TabIndex = 8;
            Player4CHECK.Text = "Player 4";
            Player4CHECK.UseVisualStyleBackColor = true;
            Player4CHECK.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 186);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "Requirements";
            // 
            // Requirements_Box
            // 
            Requirements_Box.Location = new Point(192, 186);
            Requirements_Box.Multiline = true;
            Requirements_Box.Name = "Requirements_Box";
            Requirements_Box.Size = new Size(454, 92);
            Requirements_Box.TabIndex = 10;
            Requirements_Box.TextChanged += Requirements_Box_TextChanged;
            // 
            // Final_Box
            // 
            Final_Box.Location = new Point(12, 337);
            Final_Box.Multiline = true;
            Final_Box.Name = "Final_Box";
            Final_Box.Size = new Size(776, 92);
            Final_Box.TabIndex = 11;
            // 
            // Done
            // 
            Done.Location = new Point(380, 435);
            Done.Name = "Done";
            Done.Size = new Size(75, 23);
            Done.TabIndex = 12;
            Done.Text = "Create Text";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // CHECK13
            // 
            CHECK13.AccessibleName = "CHECK13";
            CHECK13.AutoSize = true;
            CHECK13.Location = new Point(12, 37);
            CHECK13.Name = "CHECK13";
            CHECK13.Size = new Size(147, 19);
            CHECK13.TabIndex = 13;
            CHECK13.Text = "Player Need to be 13+?";
            CHECK13.UseVisualStyleBackColor = true;
            CHECK13.CheckedChanged += CHECK13_CheckedChanged;
            // 
            // pop_strat
            // 
            pop_strat.FormattingEnabled = true;
            pop_strat.Items.AddRange(new object[] { "Lucille HC" });
            pop_strat.Location = new Point(667, 8);
            pop_strat.Name = "pop_strat";
            pop_strat.Size = new Size(121, 23);
            pop_strat.TabIndex = 14;
            pop_strat.SelectedIndexChanged += pop_strat_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(pop_strat);
            Controls.Add(CHECK13);
            Controls.Add(Done);
            Controls.Add(Final_Box);
            Controls.Add(Requirements_Box);
            Controls.Add(label3);
            Controls.Add(Player4CHECK);
            Controls.Add(Player3CHECK);
            Controls.Add(Player2CHECK);
            Controls.Add(Player1CHECK);
            Controls.Add(HCMODE);
            Controls.Add(StratLink_Box);
            Controls.Add(label2);
            Controls.Add(StratName_Box);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Auto Party Texter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StratName_Box;
        private TextBox StratLink_Box;
        private Label label2;
        private CheckBox HCMODE;
        private CheckBox Player1CHECK;
        private CheckBox Player2CHECK;
        private CheckBox Player3CHECK;
        private CheckBox Player4CHECK;
        private Label label3;
        private TextBox Requirements_Box;
        private TextBox Final_Box;
        private Button Done;
        private CheckBox CHECK13;
        private ComboBox pop_strat;
    }
}
