using System;
using System.Linq;
using System.Windows.Forms;

namespace System_obsługi_konferencji
{
    public partial class MainMenu : Form
    {
        DataStore _ds;
        Sluchacz _sluchacz;
        Prelegent prelegent = new Prelegent();
        Prelegent prelegentLogin = new Prelegent();
        Organizator organizator = new Organizator();
        Organizator organizatorLogin = new Organizator();
        public MainMenu(DataStore ds, Sluchacz sluchacz)
        {
            _ds = ds;
            _sluchacz = sluchacz;
            InitializeComponent();
        }//Przekazanie DataStore i użytkownika zalogowanego ze Start.cs

        private void openParticipant(object sender, EventArgs e)//Zrobione, dodać przekazywanie do konstruktowa
        {
            this.Hide();
            var participantMenu = new ParticipantMenu();
            participantMenu.Closed += (s, args) => this.Show();
            participantMenu.Show();
        }

        private void openSpeaker(object sender, EventArgs e)//Zrobione, dodać przekazywanie do konstruktowa
        {
            prelegent = new Prelegent(_sluchacz.Login, _sluchacz.Haslo);
            if (_ds.Prelegenci.Contains(prelegent))
            {
                this.Hide();
                var speakerMenu = new SpeakerMenu();
                speakerMenu.Closed += (s, args) => this.Show();
                speakerMenu.Show();
            }
            else
            {
                string message = "Nie posiadasz uprawnień prelegenta. Aby to zmienić, kliknij ikonkę profilu w prawym górnym rogu.";
                string caption = "Brak uprawnień";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void openOrganizer(object sender, EventArgs e)//Zrobione, dodać przekazywanie do konstruktowa
        {
            organizator = new Organizator(_sluchacz.Login, _sluchacz.Haslo);
            if (_ds.Organizatorzy.Contains(organizator))
            {
                this.Hide();
                var organizerMenu = new OrganizerMenu(_ds, _sluchacz, organizator);
                organizerMenu.Closed += (s, args) => this.Show();
                organizerMenu.Show();
            }
            else
            {
                string message = "Nie posiadasz uprawnień organizatora. Aby to zmienić, kliknij ikonkę profilu w prawym górnym rogu.";
                string caption = "Brak uprawnień";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
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

        private void pbxProfileClick(object sender, EventArgs e)//Zrobione
        {
            Form dlgProfile = new Form();
            dlgProfile.Height = 290;
            dlgProfile.Width = 330;
            prelegentLogin = new Prelegent(_sluchacz.Login, _sluchacz.Haslo);
            organizatorLogin = new Organizator(_sluchacz.Login, _sluchacz.Haslo);

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
            if (_ds.Organizatorzy.Contains(organizatorLogin))
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
            button2.Click += new System.EventHandler(DlgProfileCancel);

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
                    dlgProfile.Close();
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
                    btnOK.Click += new System.EventHandler(BtnCreate);

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

                    void BtnCreate(object sender3, EventArgs e3)
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
                            btnCreatorOK.Text = "Utwórz";
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
                            Form dlgCreateOrganizer = new Form();
                            dlgCreateOrganizer.Width = 314;
                            dlgCreateOrganizer.Height = 339;

                            #region layout
                            TextBox tbxStreet = new System.Windows.Forms.TextBox();
                            TextBox tbxBuilding = new System.Windows.Forms.TextBox();
                            TextBox tbxAppartment = new System.Windows.Forms.TextBox();
                            TextBox tbxCity = new System.Windows.Forms.TextBox();
                            TextBox tbxPostalCode = new System.Windows.Forms.TextBox();
                            TextBox tbxBankAccount = new System.Windows.Forms.TextBox();
                            TextBox tbxCompanyName = new System.Windows.Forms.TextBox();
                            TextBox tbxNIP1 = new System.Windows.Forms.TextBox();
                            Button btnCancelOrganizerCreation = new System.Windows.Forms.Button();
                            Button btnCreateOrganizer = new System.Windows.Forms.Button();
                            Label lbl1 = new System.Windows.Forms.Label();
                            Label lbl2 = new System.Windows.Forms.Label();
                            Label lbl3 = new System.Windows.Forms.Label();
                            Label lbl4 = new System.Windows.Forms.Label();
                            Label lbl5 = new System.Windows.Forms.Label();
                            Label lbl6 = new System.Windows.Forms.Label();
                            Label lbl7 = new System.Windows.Forms.Label();
                            Label lbl8 = new System.Windows.Forms.Label();
                            TextBox tbxNIP2 = new System.Windows.Forms.TextBox();
                            TextBox tbxNIP3 = new System.Windows.Forms.TextBox();
                            TextBox tbxNIP4 = new System.Windows.Forms.TextBox();
                            Button btnSwitch = new System.Windows.Forms.Button();
                            dlgCreateOrganizer.SuspendLayout();

                            // 
                            // tbxStreet
                            // 
                            tbxStreet.Location = new System.Drawing.Point(12, 34);
                            tbxStreet.MaxLength = 40;
                            tbxStreet.Name = "tbxStreet";
                            tbxStreet.Size = new System.Drawing.Size(177, 22);
                            tbxStreet.TabIndex = 0;
                            // 
                            // tbxBuilding
                            // 
                            tbxBuilding.Location = new System.Drawing.Point(195, 34);
                            tbxBuilding.MaxLength = 5;
                            tbxBuilding.Name = "tbxBuilding";
                            tbxBuilding.Size = new System.Drawing.Size(41, 22);
                            tbxBuilding.TabIndex = 1;
                            // 
                            // tbxAppartment
                            // 
                            tbxAppartment.Location = new System.Drawing.Point(242, 34);
                            tbxAppartment.MaxLength = 5;
                            tbxAppartment.Name = "tbxAppartment";
                            tbxAppartment.Size = new System.Drawing.Size(42, 22);
                            tbxAppartment.TabIndex = 2;
                            // 
                            // tbxCity
                            // 
                            tbxCity.Location = new System.Drawing.Point(13, 86);
                            tbxCity.MaxLength = 40;
                            tbxCity.Name = "tbxCity";
                            tbxCity.Size = new System.Drawing.Size(188, 22);
                            tbxCity.TabIndex = 3;
                            // 
                            // tbxPostalCode
                            // 
                            tbxPostalCode.Location = new System.Drawing.Point(207, 86);
                            tbxPostalCode.MaxLength = 6;
                            tbxPostalCode.Name = "tbxPostalCode";
                            tbxPostalCode.Size = new System.Drawing.Size(77, 22);
                            tbxPostalCode.TabIndex = 4;
                            // 
                            // tbxBankAccount
                            // 
                            tbxBankAccount.Location = new System.Drawing.Point(12, 138);
                            tbxBankAccount.MaxLength = 26;
                            tbxBankAccount.Name = "tbxBankAccount";
                            tbxBankAccount.Size = new System.Drawing.Size(272, 22);
                            tbxBankAccount.TabIndex = 5;
                            // 
                            // btnSwitch
                            // 
                            btnSwitch.BackColor = System.Drawing.SystemColors.ButtonShadow;
                            btnSwitch.Location = new System.Drawing.Point(47, 176);
                            btnSwitch.Name = "btnSwitch";
                            btnSwitch.Size = new System.Drawing.Size(213, 34);
                            btnSwitch.TabIndex = 22;
                            btnSwitch.Text = "Konto prywatne";
                            btnSwitch.UseVisualStyleBackColor = false;
                            btnSwitch.Click += new System.EventHandler(BtnSwitch);
                            // 
                            // tbxCompanyName
                            // 
                            tbxCompanyName.Location = new System.Drawing.Point(12, 230);
                            tbxCompanyName.MaxLength = 50;
                            tbxCompanyName.Name = "tbxCompanyName";
                            tbxCompanyName.Size = new System.Drawing.Size(272, 22);
                            tbxCompanyName.TabIndex = 7;
                            // 
                            // tbxNIP1
                            // 
                            tbxNIP1.Location = new System.Drawing.Point(13, 272);
                            tbxNIP1.MaxLength = 2;
                            tbxNIP1.Name = "tbxNIP1";
                            tbxNIP1.Size = new System.Drawing.Size(28, 22);
                            tbxNIP1.TabIndex = 8;
                            // 
                            // btnCancelOrganizerCreation
                            // 
                            btnCancelOrganizerCreation.Location = new System.Drawing.Point(13, 238);
                            btnCancelOrganizerCreation.Name = "btnCancelOrganizerCreation";
                            btnCancelOrganizerCreation.Size = new System.Drawing.Size(119, 42);
                            btnCancelOrganizerCreation.TabIndex = 9;
                            btnCancelOrganizerCreation.Text = "Anuluj";
                            btnCancelOrganizerCreation.UseVisualStyleBackColor = true;
                            // 
                            // btnCreateOrganizer
                            // 
                            btnCreateOrganizer.Location = new System.Drawing.Point(165, 238);
                            btnCreateOrganizer.Name = "btnCreateOrganizer";
                            btnCreateOrganizer.Size = new System.Drawing.Size(119, 42);
                            btnCreateOrganizer.TabIndex = 10;
                            btnCreateOrganizer.Text = "Utwórz";
                            btnCreateOrganizer.UseVisualStyleBackColor = true;
                            btnCreateOrganizer.Click += new System.EventHandler(CreateOrganizer);
                            // 
                            // lbl1
                            // 
                            lbl1.AutoSize = true;
                            lbl1.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl1.Location = new System.Drawing.Point(20, 18);
                            lbl1.Name = "lbl1";
                            lbl1.Size = new System.Drawing.Size(26, 13);
                            lbl1.TabIndex = 11;
                            lbl1.Text = "Ulica";
                            // 
                            // lbl2
                            // 
                            lbl2.AutoSize = true;
                            lbl2.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl2.Location = new System.Drawing.Point(192, 18);
                            lbl2.Name = "lbl2";
                            lbl2.Size = new System.Drawing.Size(41, 13);
                            lbl2.TabIndex = 12;
                            lbl2.Text = "Nr domu";
                            // 
                            // lbl3
                            // 
                            lbl3.AutoSize = true;
                            lbl3.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl3.Location = new System.Drawing.Point(243, 18);
                            lbl3.Name = "lbl3";
                            lbl3.Size = new System.Drawing.Size(42, 13);
                            lbl3.TabIndex = 13;
                            lbl3.Text = "Nr mszk.";
                            // 
                            // lbl4
                            // 
                            lbl4.AutoSize = true;
                            lbl4.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl4.Location = new System.Drawing.Point(20, 70);
                            lbl4.Name = "lbl4";
                            lbl4.Size = new System.Drawing.Size(35, 13);
                            lbl4.TabIndex = 14;
                            lbl4.Text = "Miasto";
                            // 
                            // lbl5
                            // 
                            lbl5.AutoSize = true;
                            lbl5.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl5.Location = new System.Drawing.Point(213, 70);
                            lbl5.Name = "lbl5";
                            lbl5.Size = new System.Drawing.Size(62, 13);
                            lbl5.TabIndex = 15;
                            lbl5.Text = "Kod pocztowy";
                            // 
                            // lbl6
                            // 
                            lbl6.AutoSize = true;
                            lbl6.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl6.Location = new System.Drawing.Point(20, 122);
                            lbl6.Name = "lbl6";
                            lbl6.Size = new System.Drawing.Size(108, 13);
                            lbl6.TabIndex = 16;
                            lbl6.Text = "Numer konta bankowego (bez spacji)";
                            // 
                            // lbl7
                            // 
                            lbl7.AutoSize = true;
                            lbl7.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl7.Location = new System.Drawing.Point(20, 214);
                            lbl7.Name = "lbl7";
                            lbl7.Size = new System.Drawing.Size(57, 13);
                            lbl7.TabIndex = 17;
                            lbl7.Text = "Nazwa firmy";
                            // 
                            // lbl8
                            // 
                            lbl8.AutoSize = true;
                            lbl8.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                            lbl8.Location = new System.Drawing.Point(20, 256);
                            lbl8.Name = "lbl8";
                            lbl8.Size = new System.Drawing.Size(21, 13);
                            lbl8.TabIndex = 18;
                            lbl8.Text = "NIP";
                            // 
                            // tbxNIP2
                            // 
                            tbxNIP2.Location = new System.Drawing.Point(49, 272);
                            tbxNIP2.MaxLength = 2;
                            tbxNIP2.Name = "tbxNIP2";
                            tbxNIP2.Size = new System.Drawing.Size(28, 22);
                            tbxNIP2.TabIndex = 19;
                            // 
                            // tbxNIP3
                            // 
                            tbxNIP3.Location = new System.Drawing.Point(83, 272);
                            tbxNIP3.MaxLength = 3;
                            tbxNIP3.Name = "tbxNIP3";
                            tbxNIP3.Size = new System.Drawing.Size(33, 22);
                            tbxNIP3.TabIndex = 20;
                            // 
                            // tbxNIP4
                            // 
                            tbxNIP4.Location = new System.Drawing.Point(122, 272);
                            tbxNIP4.MaxLength = 3;
                            tbxNIP4.Name = "tbxNIP4";
                            tbxNIP4.Size = new System.Drawing.Size(33, 22);
                            tbxNIP4.TabIndex = 21;
                            //
                            //BtnSwitchCompany
                            //
                            void BtnSwitch(object sender4, EventArgs e4)
                            {
                                if (btnSwitch.Text.Equals("Konto prywatne"))
                                {
                                    dlgCreateOrganizer.Width = 314;
                                    dlgCreateOrganizer.Height = 423;
                                    btnCancelOrganizerCreation.Location = new System.Drawing.Point(13, 316);
                                    btnCreateOrganizer.Location = new System.Drawing.Point(165, 316);

                                    dlgCreateOrganizer.Controls.Add(tbxNIP4);
                                    dlgCreateOrganizer.Controls.Add(tbxNIP3);
                                    dlgCreateOrganizer.Controls.Add(tbxNIP2);
                                    dlgCreateOrganizer.Controls.Add(lbl8);
                                    dlgCreateOrganizer.Controls.Add(lbl7);
                                    dlgCreateOrganizer.Controls.Add(tbxNIP1);
                                    dlgCreateOrganizer.Controls.Add(tbxCompanyName);

                                    btnSwitch.Text = "Konto firmy";
                                    btnSwitch.BackColor = System.Drawing.SystemColors.ActiveBorder;
                                }
                                else
                                {
                                    dlgCreateOrganizer.Width = 314;
                                    dlgCreateOrganizer.Height = 339;
                                    btnCancelOrganizerCreation.Location = new System.Drawing.Point(13, 238);
                                    btnCreateOrganizer.Location = new System.Drawing.Point(165, 238);

                                    dlgCreateOrganizer.Controls.Remove(tbxNIP4);
                                    dlgCreateOrganizer.Controls.Remove(tbxNIP3);
                                    dlgCreateOrganizer.Controls.Remove(tbxNIP2);
                                    dlgCreateOrganizer.Controls.Remove(lbl8);
                                    dlgCreateOrganizer.Controls.Remove(lbl7);
                                    dlgCreateOrganizer.Controls.Remove(tbxNIP1);
                                    dlgCreateOrganizer.Controls.Remove(tbxCompanyName);

                                    btnSwitch.Text = "Konto prywatne";
                                    btnSwitch.BackColor = System.Drawing.SystemColors.ButtonShadow;
                                }
                            }
                            // 
                            // Form2
                            //
                            dlgCreateOrganizer.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                            dlgCreateOrganizer.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                            dlgCreateOrganizer.AutoSize = true;
                            //dlgCreateOrganizer.ClientSize = new System.Drawing.Size(296, 376);
                            dlgCreateOrganizer.Controls.Add(lbl6);
                            dlgCreateOrganizer.Controls.Add(lbl5);
                            dlgCreateOrganizer.Controls.Add(lbl4);
                            dlgCreateOrganizer.Controls.Add(lbl3);
                            dlgCreateOrganizer.Controls.Add(lbl2);
                            dlgCreateOrganizer.Controls.Add(lbl1);
                            dlgCreateOrganizer.Controls.Add(btnCreateOrganizer);
                            dlgCreateOrganizer.Controls.Add(btnCancelOrganizerCreation);
                            dlgCreateOrganizer.Controls.Add(tbxBankAccount);
                            dlgCreateOrganizer.Controls.Add(tbxPostalCode);
                            dlgCreateOrganizer.Controls.Add(tbxCity);
                            dlgCreateOrganizer.Controls.Add(tbxAppartment);
                            dlgCreateOrganizer.Controls.Add(tbxBuilding);
                            dlgCreateOrganizer.Controls.Add(tbxStreet);
                            dlgCreateOrganizer.Controls.Add(btnSwitch);
                            dlgCreateOrganizer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                            dlgCreateOrganizer.Name = "Form2";
                            dlgCreateOrganizer.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                            dlgCreateOrganizer.Text = "Form2";
                            //dlgCreateOrganizer.Load += new System.EventHandler(dlgCreateOrganizer.Form2_Load);
                            //dlgCreateOrganizer.ResumeLayout(false);
                            dlgCreateOrganizer.PerformLayout();
                            dlgCreateOrganizer.ShowDialog();
                            dlgChooseUpgrade.Close();

                            #endregion

                            void CreateOrganizer(object sender4, EventArgs e4)
                            {
                                Adres adresik = new Adres();
                                if (btnSwitch.Text.Equals("Konto prywatne"))
                                {

                                    if (String.IsNullOrWhiteSpace(tbxStreet.Text) || String.IsNullOrWhiteSpace(tbxBuilding.Text) || String.IsNullOrWhiteSpace(tbxAppartment.Text) || String.IsNullOrWhiteSpace(tbxCity.Text) ||
                                        String.IsNullOrWhiteSpace(tbxPostalCode.Text) || String.IsNullOrWhiteSpace(tbxBankAccount.Text))
                                    {
                                        string message = "Uzupełnij wszystkie pola.";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (!tbxAppartment.Text.Any(char.IsDigit) || !tbxBuilding.Text.Any(char.IsDigit) || !tbxBankAccount.Text.Any(char.IsDigit))
                                    {
                                        string message = "Numery zwykle zawierają cyfry.";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (tbxPostalCode.Text.Length < 6)
                                    {
                                        string message = "Uzupełnij kod pocztowy według wzoru: XX-XXX";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if(!tbxPostalCode.Text.Substring(0, 2).All(char.IsDigit) || !tbxPostalCode.Text.Substring(2, 1).Equals("-") || !tbxPostalCode.Text.Substring(3, 3).All(char.IsDigit))
                                    {
                                        string message = "Uzupełnij kod pocztowy według wzoru: XX-XXX";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (tbxBankAccount.Text.Length < 26)
                                    {
                                        string message = "Numer konta bankowego składa się z 26 cyfr.";
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
                                            adresik = new Adres(tbxStreet.Text, tbxCity.Text, tbxPostalCode.Text, tbxBuilding.Text, tbxAppartment.Text);
                                            organizator = new Organizator(_sluchacz.Login, _sluchacz.Haslo, adresik, tbxBankAccount.Text);
                                            _ds.Organizatorzy.Add(organizator);
                                            _ds.DataStore_save(_ds);
                                            string messag = "Gratulacje! Od teraz możesz pełnić na konferencjach funkcję organizatora.";
                                            string captio = "Dziękujemy!";
                                            MessageBoxButtons button = MessageBoxButtons.OK;
                                            DialogResult resul;
                                            resul = MessageBox.Show(messag, captio, button);
                                            dlgCreateOrganizer.Close();
                                        }
                                        else
                                        {
                                            dlgCreateOrganizer.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    if (String.IsNullOrWhiteSpace(tbxStreet.Text) || String.IsNullOrWhiteSpace(tbxBuilding.Text) || String.IsNullOrWhiteSpace(tbxAppartment.Text) || String.IsNullOrWhiteSpace(tbxCity.Text) ||
                                    String.IsNullOrWhiteSpace(tbxPostalCode.Text) || String.IsNullOrWhiteSpace(tbxBankAccount.Text) || String.IsNullOrWhiteSpace(tbxCompanyName.Text) || String.IsNullOrWhiteSpace(tbxNIP1.Text) ||
                                    String.IsNullOrWhiteSpace(tbxNIP2.Text) || String.IsNullOrWhiteSpace(tbxNIP3.Text) || String.IsNullOrWhiteSpace(tbxNIP4.Text))
                                    {
                                        string message = "Uzupełnij wszystkie pola.";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (!tbxAppartment.Text.Any(char.IsDigit) || !tbxBuilding.Text.Any(char.IsDigit) || !tbxBankAccount.Text.All(char.IsDigit) || !tbxNIP1.Text.All(char.IsDigit) || !tbxNIP2.Text.All(char.IsDigit) ||
                                        !tbxNIP3.Text.All(char.IsDigit) || !tbxNIP4.Text.All(char.IsDigit))
                                    {
                                        string message = "Numery zwykle zawierają cyfry.";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (tbxPostalCode.Text.Length < 6)
                                    {
                                        string message = "Uzupełnij kod pocztowy według wzoru: XX-XXX";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (!tbxPostalCode.Text.Substring(0, 2).All(char.IsDigit) || !tbxPostalCode.Text.Substring(2, 1).Equals("-") || !tbxPostalCode.Text.Substring(3, 3).All(char.IsDigit))
                                    {
                                        string message = "Uzupełnij kod pocztowy według wzoru: XX-XXX";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (tbxBankAccount.Text.Length < 26)
                                    {
                                        string message = "Numer konta bankowego składa się z 26 cyfr.";
                                        string caption = "";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                    }
                                    else if (tbxNIP1.Text.Length != 2 || tbxNIP2.Text.Length != 2 || tbxNIP3.Text.Length != 3 || tbxNIP4.Text.Length != 3)
                                    {
                                        string message = "NIP wprowadź według wzoru:\nXX XX XXX XXX";
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
                                            adresik = new Adres(tbxStreet.Text, tbxCity.Text, tbxPostalCode.Text, tbxBuilding.Text, tbxAppartment.Text);
                                            organizator = new Organizator(_sluchacz.Login, _sluchacz.Haslo, adresik, tbxBankAccount.Text, (tbxNIP1.Text + '-' + tbxNIP2.Text + '-' + tbxNIP3.Text + '-' + tbxNIP4.Text), tbxCompanyName.Text);
                                            _ds.Organizatorzy.Add(organizator);
                                            _ds.DataStore_save(_ds);
                                            string messag = "Gratulacje! Od teraz możesz pełnić na konferencjach funkcję organizatora.";
                                            string captio = "Dziękujemy!";
                                            MessageBoxButtons button = MessageBoxButtons.OK;
                                            DialogResult resul;
                                            resul = MessageBox.Show(messag, captio, button);
                                            dlgCreateOrganizer.Close();
                                        }
                                        else
                                        {
                                            dlgCreateOrganizer.Close();
                                        }
                                    }
                                }
                            }
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
