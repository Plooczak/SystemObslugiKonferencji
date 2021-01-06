using System;
using System.Windows.Forms;

namespace System_obsługi_konferencji
{
    public partial class MainMenu : Form
    {
        DataStore _ds;
        Sluchacz _sluchacz;
        Prelegent prelegent = new Prelegent();
        Prelegent prelegentLogin = new Prelegent();
        public MainMenu(DataStore ds, Sluchacz sluchacz)
        {
            _ds = ds;
            _sluchacz = sluchacz;
            InitializeComponent();
        }//Przekazanie DataStore i użytkownika zalogowanego ze Start.cs

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

        private void pbxCloseClick(object sender, EventArgs e)
        {
            string message = "Czy na pewno chcesz opuścić aplikację?";
            string caption = "Nie odchodź :(";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                _ds.DataStore_save(_ds);
                Application.Exit();
            }
        }//Zrobione

        private void pbxLogOutClick(object sender, EventArgs e)
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
        }//Zrobione

        private void pbxProfileClick(object sender, EventArgs e)
        {
            Form dlgProfile = new Form();
            dlgProfile.Height = 290;
            dlgProfile.Width = 330;
            prelegentLogin = new Prelegent(_sluchacz.Login, _sluchacz.Haslo);

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
            if (_ds.Prelegenci.Contains(prelegentLogin))
            {
                label5.Text = "Tak";
            }
            else
            {
                label5.Text = "Nie";
            }
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
            if (_ds.Organizatorzy.Equals(_sluchacz.Login))
            {
                label8.Text = "Tak";
            }
            else
            {
                label8.Text = "Nie";
            }
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(27, 218);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(97, 35);
            button1.TabIndex = 8;
            button1.Text = "Ulepsz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(btnUpgrade);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(150, 218);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(99, 35);
            button2.TabIndex = 9;
            button2.Text = "Wyjdź";
            button2.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(DlgProfileCancel);

            dlgProfile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            dlgProfile.ShowDialog();
            #endregion 

            void btnUpgrade(object sender2, EventArgs e2)
            {
                if (label5.Text == "Tak" && label8.Text == "Tak")
                {
                    string message = "Masz już pełnię dostępnych uprawnień.";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    Form dlgChooseUpgrade = new Form();
                    dlgChooseUpgrade.Height = 208;
                    dlgChooseUpgrade.Width = 295;

                    #region layout
                    Label lblChoose = new System.Windows.Forms.Label();
                    ComboBox cbxProfile = new System.Windows.Forms.ComboBox();
                    Button btnCancel = new System.Windows.Forms.Button();
                    Button btnOK = new System.Windows.Forms.Button();
                    this.SuspendLayout();

                    // 
                    // lblChoose
                    // 
                    lblChoose.AutoSize = true;
                    lblChoose.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblChoose.Location = new System.Drawing.Point(41, 21);
                    lblChoose.Name = "lblChoose";
                    lblChoose.Size = new System.Drawing.Size(192, 21);
                    lblChoose.TabIndex = 1;
                    lblChoose.Text = "Wybierz rodzaj uprawnień";
                    // 
                    // cbxProfile
                    // 
                    cbxProfile.FormattingEnabled = true;
                    if (label5.Text == "Tak")
                    {
                        cbxProfile.Items.AddRange(new object[] { "Organizator" });
                    }
                    else if (label8.Text == "Tak")
                    {
                        cbxProfile.Items.AddRange(new object[] { "Prelegent" });
                    }
                    else
                    {
                        cbxProfile.Items.AddRange(new object[] { "Prelegent", "Organizator" });
                    }
                    cbxProfile.Location = new System.Drawing.Point(63, 62);
                    cbxProfile.Name = "cbxProfile";
                    cbxProfile.Size = new System.Drawing.Size(150, 24);
                    cbxProfile.TabIndex = 2;
                    // 
                    // btnCancel
                    // 
                    btnCancel.Location = new System.Drawing.Point(35, 117);
                    btnCancel.Name = "btnCancel";
                    btnCancel.Size = new System.Drawing.Size(95, 32);
                    btnCancel.TabIndex = 3;
                    btnCancel.Text = "Anuluj";
                    btnCancel.UseVisualStyleBackColor = true;
                    btnCancel.Click += new System.EventHandler(DlgChooseUpgradeCancel);
                    // 
                    // btnOK
                    // 
                    btnOK.Location = new System.Drawing.Point(150, 117);
                    btnOK.Name = "btnOK";
                    btnOK.Size = new System.Drawing.Size(95, 32);
                    btnOK.TabIndex = 4;
                    btnOK.Text = "Dalej";
                    btnOK.UseVisualStyleBackColor = true;
                    btnOK.Click += new System.EventHandler(BtnCreateSpeaker);

                    dlgChooseUpgrade.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                    dlgChooseUpgrade.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    dlgChooseUpgrade.AutoSize = true;
                    dlgChooseUpgrade.ClientSize = new System.Drawing.Size(277, 161);
                    dlgChooseUpgrade.Controls.Add(btnOK);
                    dlgChooseUpgrade.Controls.Add(btnCancel);
                    dlgChooseUpgrade.Controls.Add(cbxProfile);
                    dlgChooseUpgrade.Controls.Add(lblChoose);
                    dlgChooseUpgrade.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    dlgChooseUpgrade.Name = "Form2";
                    dlgChooseUpgrade.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    dlgChooseUpgrade.Text = "Form2";
                    //dlgChooseUpgrade.Load += new System.EventHandler(Form2_Load);
                    dlgChooseUpgrade.ResumeLayout(false);
                    dlgChooseUpgrade.PerformLayout();
                    dlgChooseUpgrade.ShowDialog();
                    dlgProfile.Close();
                    #endregion

                    void BtnCreateSpeaker(object sender3, EventArgs e3)
                    {
                        if (cbxProfile.Text == "Prelegent")
                        {
                            Form dlgCreateSpeaker = new Form();
                            dlgCreateSpeaker.Width = 341;
                            dlgCreateSpeaker.Height = 373;

                            #region layout

                            TextBox tbxDiscipline = new System.Windows.Forms.TextBox();
                            Button btnCreatorCancel = new System.Windows.Forms.Button();
                            Label lblAbout = new System.Windows.Forms.Label();
                            Button btnCreatorOK = new System.Windows.Forms.Button();
                            Label lblDiscipline = new System.Windows.Forms.Label();
                            Label lblTitle = new System.Windows.Forms.Label();
                            ComboBox cbxTitle = new System.Windows.Forms.ComboBox();
                            RichTextBox rtbxAbout = new System.Windows.Forms.RichTextBox();
                            dlgCreateSpeaker.SuspendLayout();

                            // 
                            // tbxDiscipline
                            // 
                            tbxDiscipline.Location = new System.Drawing.Point(178, 39);
                            tbxDiscipline.MaxLength = 50;
                            tbxDiscipline.Name = "tbxDiscipline";
                            tbxDiscipline.Size = new System.Drawing.Size(133, 22);
                            tbxDiscipline.TabIndex = 1;
                            // 
                            // btnCreatorCancel
                            // 
                            btnCreatorCancel.Location = new System.Drawing.Point(12, 258);
                            btnCreatorCancel.Name = "btnCreatorCancel";
                            btnCreatorCancel.Size = new System.Drawing.Size(140, 43);
                            btnCreatorCancel.TabIndex = 4;
                            btnCreatorCancel.Text = "Anuluj";
                            btnCreatorCancel.UseVisualStyleBackColor = true;
                            btnCreatorCancel.Click += new System.EventHandler(DlgCancelSpeakerCreation);
                            // 
                            // lblAbout
                            // 
                            lblAbout.AutoSize = true;
                            lblAbout.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lblAbout.Location = new System.Drawing.Point(18, 78);
                            lblAbout.Name = "lblAbout";
                            lblAbout.Size = new System.Drawing.Size(51, 13);
                            lblAbout.TabIndex = 5;
                            lblAbout.Text = "Coś o sobie";
                            // 
                            // btnCreatorOK
                            // 
                            btnCreatorOK.Location = new System.Drawing.Point(178, 258);
                            btnCreatorOK.Name = "btnCreatorOK";
                            btnCreatorOK.Size = new System.Drawing.Size(133, 43);
                            btnCreatorOK.TabIndex = 7;
                            btnCreatorOK.Text = "Zostań mówcą";
                            btnCreatorOK.UseVisualStyleBackColor = true;
                            btnCreatorOK.Click += new System.EventHandler(CreateSpeaker);
                            // 
                            // lblDiscipline
                            // 
                            lblDiscipline.AutoSize = true;
                            lblDiscipline.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lblDiscipline.Location = new System.Drawing.Point(184, 23);
                            lblDiscipline.Name = "lblDiscipline";
                            lblDiscipline.Size = new System.Drawing.Size(45, 13);
                            lblDiscipline.TabIndex = 8;
                            lblDiscipline.Text = "Dziedzina";
                            // 
                            // lblTitle
                            // 
                            lblTitle.AutoSize = true;
                            lblTitle.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lblTitle.Location = new System.Drawing.Point(18, 23);
                            lblTitle.Name = "lblTitle";
                            lblTitle.Size = new System.Drawing.Size(66, 13);
                            lblTitle.TabIndex = 9;
                            lblTitle.Text = "Tytuł naukowy";
                            // 
                            // cbxTitle
                            // 
                            cbxTitle.FormattingEnabled = true;
                            cbxTitle.Items.AddRange(new object[] {
            "Magister",
            "Inżynier",
            "Magister inżynier",
            "Doktor",
            "Doktor inżynier",
            "Doktor habilitowany",
            "Doktor habilitowany inżynier",
            "Profesor nadzwyczajny",
            "Profesor nadzwyczajny inżynier",
            "Profesor zwyczajny",
            "Profesor zwyczajny inżynier"});
                            cbxTitle.Location = new System.Drawing.Point(12, 39);
                            cbxTitle.Name = "cbxTitle";
                            cbxTitle.Size = new System.Drawing.Size(140, 24);
                            cbxTitle.TabIndex = 10;
                            // 
                            // rtbxAbout
                            // 
                            rtbxAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            rtbxAbout.Location = new System.Drawing.Point(12, 94);
                            rtbxAbout.MaxLength = 500;
                            rtbxAbout.Name = "rtbxAbout";
                            rtbxAbout.Size = new System.Drawing.Size(299, 136);
                            rtbxAbout.TabIndex = 11;
                            rtbxAbout.Text = "";

                            dlgCreateSpeaker.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                            dlgCreateSpeaker.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                            dlgCreateSpeaker.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                            dlgCreateSpeaker.ClientSize = new System.Drawing.Size(323, 326);
                            dlgCreateSpeaker.Controls.Add(rtbxAbout);
                            dlgCreateSpeaker.Controls.Add(cbxTitle);
                            dlgCreateSpeaker.Controls.Add(lblTitle);
                            dlgCreateSpeaker.Controls.Add(lblDiscipline);
                            dlgCreateSpeaker.Controls.Add(btnCreatorOK);
                            dlgCreateSpeaker.Controls.Add(lblAbout);
                            dlgCreateSpeaker.Controls.Add(btnCreatorCancel);
                            dlgCreateSpeaker.Controls.Add(tbxDiscipline);
                            dlgCreateSpeaker.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                            dlgCreateSpeaker.Name = "Form1";
                            dlgCreateSpeaker.Text = "Form1";
                            dlgCreateSpeaker.ResumeLayout(false);
                            dlgCreateSpeaker.PerformLayout();
                            dlgCreateSpeaker.ShowDialog();
                            dlgChooseUpgrade.Close();
                            #endregion

                            void CreateSpeaker(object sender4, EventArgs e4)
                            {
                                if (String.IsNullOrEmpty(cbxTitle.Text) || String.IsNullOrWhiteSpace(tbxDiscipline.Text) || String.IsNullOrWhiteSpace(rtbxAbout.Text))
                                {
                                    string message = "Uzupełnij wszystkie pola.";
                                    string caption = "";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result;

                                    result = MessageBox.Show(message, caption, buttons);
                                }
                                else
                                {
                                    string message = "Witaj w Systemie Wyimaginowanych Płatności! Aby zasubskrybować i uzyskać status prelegenta wciśnij \"OK\".";
                                    string caption = "SWP";
                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                    DialogResult result;
                                    result = MessageBox.Show(message, caption, buttons);
                                    if (result == DialogResult.OK)
                                    {
                                        prelegent = new Prelegent(_sluchacz.Login, _sluchacz.Haslo, cbxTitle.Text, tbxDiscipline.Text, rtbxAbout.Text);
                                        _ds.Prelegenci.Add(prelegent);
                                        _ds.DataStore_save(_ds);
                                        string messag = "Gratulacje! Od teraz możesz pełnić na konferencjach funkcję prelegenta.";
                                        string captio = "Dziękujemy!";
                                        MessageBoxButtons button = MessageBoxButtons.OK;
                                        DialogResult resul;
                                        resul = MessageBox.Show(messag, captio, button);
                                        dlgCreateSpeaker.Close();
                                    }
                                }
                            }
                            void DlgCancelSpeakerCreation(object sender4, EventArgs e4)
                            {
                                dlgCreateSpeaker.Close();
                            }
                        }
                        else if(cbxProfile.Text == "Organizator")
                        {

                        }
                        else
                        {
                            string message = "Najpierw wybierz uprawnienia, które chcesz otrzymać.";
                            string caption = "";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;

                            result = MessageBox.Show(message, caption, buttons);
                        }
                    }

                    void DlgChooseUpgradeCancel(object sender3, EventArgs e3)
                    {
                        dlgChooseUpgrade.Close();
                    }
                }
            }
            void DlgProfileCancel(object sender2, EventArgs e2)
            {
                dlgProfile.Close();
            }
        }
    }
}
