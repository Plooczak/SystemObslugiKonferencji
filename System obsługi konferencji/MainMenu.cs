using System;
using System.Windows.Forms;

namespace System_obsługi_konferencji
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openParticipant(object sender, EventArgs e)
        {
            this.Hide();
            var participantMenu = new ParticipantMenu();
            participantMenu.Closed += (s, args) => this.Show();
            participantMenu.Show();
        }

        private void openSpeaker(object sender, EventArgs e)
        {
            this.Hide();
            var speakerMenu = new SpeakerMenu();
            speakerMenu.Closed += (s, args) => this.Show();
            speakerMenu.Show();
        }

        private void openOrganizer(object sender, EventArgs e)
        {
            this.Hide();
            var organizerMenu = new OrganizerMenu();
            organizerMenu.Closed += (s, args) => this.Show();
            organizerMenu.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string message = "Czy na pewno chcesz opuścić aplikację?";
            string caption = "Nie odchodź :(";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string message = "Czy chcesz się wylogować?";
            string caption = "Wylogowywanie";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form dlgProfile = new Form();
            dlgProfile.Height = 290;
            dlgProfile.Width = 330;

            #region Layout
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label4 = new System.Windows.Forms.Label();
            Label label5 = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();
            Label label7 = new System.Windows.Forms.Label();
            Label label8 = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();
            dlgProfile.SuspendLayout();

            //
            // Label1
            //
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(25, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "Uprawnienia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label2.Location = new System.Drawing.Point(140, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 18);
            label2.TabIndex = 1;
            label2.Text = "Czy posiadane";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 17);
            label3.TabIndex = 2;
            label3.Text = "Uczestnik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(147, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 17);
            label4.TabIndex = 3;
            label4.Text = "Tak";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(147, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 17);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 132);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 17);
            label6.TabIndex = 5;
            label6.Text = "Prelegent";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(41, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 17);
            label7.TabIndex = 6;
            label7.Text = "Organizator";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(147, 179);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 17);
            label8.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(27, 218);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(97, 35);
            button1.TabIndex = 8;
            button1.Text = "Ulepsz";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(150, 218);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(99, 35);
            button2.TabIndex = 9;
            button2.Text = "Wyjdź";
            button2.UseVisualStyleBackColor = true;

            dlgProfile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            dlgProfile.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            dlgProfile.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            dlgProfile.ClientSize = new System.Drawing.Size(271, 265);
            dlgProfile.Controls.Add(button2);
            dlgProfile.Controls.Add(button1);
            dlgProfile.Controls.Add(label8);
            dlgProfile.Controls.Add(label7);
            dlgProfile.Controls.Add(label6);
            dlgProfile.Controls.Add(label5);
            dlgProfile.Controls.Add(label4);
            dlgProfile.Controls.Add(label3);
            dlgProfile.Controls.Add(label2);
            dlgProfile.Controls.Add(label1);
            dlgProfile.Name = "Form2";
            dlgProfile.Text = "Form2";
            dlgProfile.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //dlgProfile.Load += new System.EventHandler(this.Form2_Load);
            dlgProfile.ResumeLayout(false);
            dlgProfile.PerformLayout();
            dlgProfile.Show();
            #endregion 


        }
    }
}
