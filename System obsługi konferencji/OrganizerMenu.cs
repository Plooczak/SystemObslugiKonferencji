using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_obsługi_konferencji
{

    public partial class OrganizerMenu : Form
    {
        DataStore _ds;
        Sluchacz _sluchacz;
        Organizator _organizator = new Organizator();
        Organizator organizatorLogin = new Organizator();
        MiejsceKonferencji miejsce = new MiejsceKonferencji();
        Konferencja konferencja1 = new Konferencja();
        ListaUczestnikówKonferencji listaUczestnikow = new ListaUczestnikówKonferencji();
        ListaPrelegentówKonferencji listaPrelegentow = new ListaPrelegentówKonferencji();

        public OrganizerMenu(DataStore ds, Organizator organizator)
        {
            _ds = ds;
            _organizator = organizator;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Z uwagi na fakt, że tworzenie całego systemu pod kątem oceny nie przyniosłoby rezultatów (wszystkie funkcje kluczowe z punktu widzenia wymogów projektu zostały już zaimplementowane), twórcy postanowili pozostawić sobie zadanie zaprojektowania działania tego formularza do dalszej, samodzielnej już zabawy z .NET. To, co zostało zaprezentowane tutaj jest wyłącznie wizualną prezentacją potencjalnych funkcji SOKu.";
            string caption = "To wciąż wersja Alpha :(";
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            DialogResult result2;
            result2 = MessageBox.Show(message, caption, buttons2);

            Form przegladKonferencji = new Form();
            przegladKonferencji.Height = 610;
            przegladKonferencji.Width = 773;

            #region layout
            ListBox ListViewConferece = new System.Windows.Forms.ListBox();
            ColumnHeader Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader SubjectOfConference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Button ShowDetails = new System.Windows.Forms.Button();
            ComboBox SortComboBox1 = new System.Windows.Forms.ComboBox();
            Button SortBtn = new System.Windows.Forms.Button();
            TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            przegladKonferencji.SuspendLayout();

            ListViewConferece.FormattingEnabled = true;
            ListViewConferece.ItemHeight = 18;
            ListViewConferece.Location = new System.Drawing.Point(128, 121);
            ListViewConferece.Name = "listBoxPokaz";
            ListViewConferece.Size = new System.Drawing.Size(560, 337);
            ListViewConferece.TabIndex = 5;

            // 
            // ListViewConferece
            // 
            //ListViewConferece.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //ListViewConferece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            //Number,
            //SubjectOfConference,
            //});
            //ListViewConferece.GridLines = true;
            //ListViewConferece.HideSelection = false;
            //ListViewConferece.Location = new System.Drawing.Point(128, 121);
            //ListViewConferece.Name = "ListViewConferece";
            //ListViewConferece.Size = new System.Drawing.Size(560, 337);
            //ListViewConferece.TabIndex = 5;
            //ListViewConferece.UseCompatibleStateImageBehavior = false;
            //ListViewConferece.View = System.Windows.Forms.View.Details;
            //ListViewConferece.SelectedIndexChanged += new System.EventHandler(ListViewConferece_SelectedIndexChanged);

            // 
            // Number
            // 
            Number.Text = "Nr";
            Number.Width = 30;

            // 
            // SubjectOfConference
            // 
            SubjectOfConference.Text = "Temat Konferencji";
            SubjectOfConference.Width = 400;

            // 
            // Date
            // 
            Date.Text = "Data Konferencji";
            Date.Width = 125;

            // 
            // ShowDetails
            // 
            ShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ShowDetails.Location = new System.Drawing.Point(512, 489);
            ShowDetails.Name = "ShowDetails";
            ShowDetails.Size = new System.Drawing.Size(176, 41);
            ShowDetails.TabIndex = 4;
            ShowDetails.Text = "Pokaż szczegóły";
            ShowDetails.UseVisualStyleBackColor = true;

            // 
            // SortComboBox1
            // 
            SortComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SortComboBox1.FormattingEnabled = true;
            SortComboBox1.Items.AddRange(new object[] {
            "data rosnąco",
            "data malejąco",
            "alfabetycznie"});
            SortComboBox1.Location = new System.Drawing.Point(128, 92);
            SortComboBox1.Name = "SortComboBox1";
            SortComboBox1.Size = new System.Drawing.Size(159, 24);
            SortComboBox1.TabIndex = 2;
            //SortComboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);

            // 
            // SortBtn
            // 
            SortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            SortBtn.Location = new System.Drawing.Point(25, 92);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new System.Drawing.Size(97, 23);
            SortBtn.TabIndex = 0;
            SortBtn.Text = "Sortuj";
            SortBtn.UseVisualStyleBackColor = true;

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.59808F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.90092F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.586526F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tableLayoutPanel1.Controls.Add(SortBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(SortComboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(ShowDetails, 1, 4);
            tableLayoutPanel1.Controls.Add(ListViewConferece, 1, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76238F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.23763F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            tableLayoutPanel1.Size = new System.Drawing.Size(757, 565);
            tableLayoutPanel1.TabIndex = 0;
            //tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(tableLayoutPanel1_Paint);
            // 
            // PrzeglądKonferencji
            //             
            przegladKonferencji.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            przegladKonferencji.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            przegladKonferencji.ClientSize = new System.Drawing.Size(755, 563);
            przegladKonferencji.Controls.Add(ListViewConferece);
            przegladKonferencji.Controls.Add(ShowDetails);
            przegladKonferencji.Controls.Add(ShowDetails);
            przegladKonferencji.Controls.Add(SortComboBox1);
            przegladKonferencji.Controls.Add(SortBtn);
            przegladKonferencji.Controls.Add(tableLayoutPanel1);
            przegladKonferencji.Name = "PrzeglądKonferencji";
            przegladKonferencji.Text = "Przegląd Konferencji";
            przegladKonferencji.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //przegladKonferencji.Load += new System.EventHandler(this.FormularzTestowy_Load);
            tableLayoutPanel1.ResumeLayout(false);
            przegladKonferencji.ResumeLayout(false);
            przegladKonferencji.PerformLayout();
            przegladKonferencji.ShowDialog();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Z uwagi na fakt, że tworzenie całego systemu pod kątem oceny nie przyniosłoby rezultatów (wszystkie funkcje kluczowe z punktu widzenia wymogów projektu zostały już zaimplementowane), twórcy postanowili pozostawić sobie zadanie zaprojektowania działania tego formularza do dalszej, samodzielnej już zabawy z .NET. To, co zostało zaprezentowane tutaj jest wyłącznie wizualną prezentacją potencjalnych funkcji SOKu.";
            string caption = "To wciąż wersja Alpha :(";
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            DialogResult result2;
            result2 = MessageBox.Show(message, caption, buttons2);

            Form organizacja = new Form();
            organizacja.Height = 610;
            organizacja.Width = 773;

            #region layout

            Button buttonO = new System.Windows.Forms.Button();
            Button buttonZ = new System.Windows.Forms.Button();
            organizacja.SuspendLayout();
            // 
            // button1
            // 
            buttonO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonO.Location = new System.Drawing.Point(41, 68);
            buttonO.Name = "button1";
            buttonO.Size = new System.Drawing.Size(221, 90);
            buttonO.TabIndex = 0;
            buttonO.Text = "Utwórz wydarzenie";
            buttonO.UseVisualStyleBackColor = true;
            buttonO.Click += new System.EventHandler(buttonO_Click);

            // 
            // button2
            // 
            buttonZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonZ.Location = new System.Drawing.Point(41, 200);
            buttonZ.Name = "button2";
            buttonZ.Size = new System.Drawing.Size(218, 96);
            buttonZ.TabIndex = 1;
            buttonZ.Text = "Wyślij zaproszenie";
            buttonZ.UseVisualStyleBackColor = true;
            buttonZ.Click += new System.EventHandler(buttonZ_Click);
            // 
            // Organizacja
            // 
            organizacja.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            organizacja.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            organizacja.ClientSize = new System.Drawing.Size(297, 363);
            organizacja.Controls.Add(buttonZ);
            organizacja.Controls.Add(buttonO);
            organizacja.Name = "Organizacja";
            organizacja.Text = "Organizacja";
            organizacja.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //przegladKonferencji.Load += new System.EventHandler(this.FormularzTestowy_Load);
            organizacja.ResumeLayout(false);
            organizacja.PerformLayout();
            organizacja.ShowDialog();
            #endregion

            void buttonO_Click(object sender1, EventArgs e1)
            {
                Form utworzWydarzenie = new Form();
                utworzWydarzenie.Height = 566;
                utworzWydarzenie.Width = 420;

                #region layout
                Label tytul = new System.Windows.Forms.Label();
                Label temat = new System.Windows.Forms.Label();
                TextBox tematBox = new System.Windows.Forms.TextBox();
                Label data = new System.Windows.Forms.Label();
                DateTimePicker dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                Label miejsce = new System.Windows.Forms.Label();
                ComboBox miejsceBox = new System.Windows.Forms.ComboBox();
                Button dodajMiejsce = new System.Windows.Forms.Button();
                Button utworzWydarzenie1 = new System.Windows.Forms.Button();
                utworzWydarzenie.SuspendLayout();
                // 
                // tytul
                // 
                tytul.AutoSize = true;
                tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                tytul.Location = new System.Drawing.Point(17, 33);
                tytul.Name = "tytul";
                tytul.Size = new System.Drawing.Size(528, 25);
                tytul.TabIndex = 0;
                tytul.Text = "Wprowadź dane potrzebne do utworzenia nowej konferencji";
                // 
                // temat
                // 
                temat.AutoSize = true;
                temat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                temat.Location = new System.Drawing.Point(12, 113);
                temat.Name = "temat";
                temat.Size = new System.Drawing.Size(74, 25);
                temat.TabIndex = 1;
                temat.Text = "Temat:";
                // 
                // tematBox
                // 
                tematBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                tematBox.Location = new System.Drawing.Point(97, 108);
                tematBox.Name = "tematBox";
                tematBox.Size = new System.Drawing.Size(430, 30);
                tematBox.TabIndex = 2;
                // 
                // data
                // 
                data.AutoSize = true;
                data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                data.Location = new System.Drawing.Point(12, 156);
                data.Name = "data";
                data.Size = new System.Drawing.Size(59, 25);
                data.TabIndex = 3;
                data.Text = "Data:";   
                // 
                // dateTimePicker1
                // 
                dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                dateTimePicker1.Location = new System.Drawing.Point(77, 151);
                dateTimePicker1.MaxDate = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
                dateTimePicker1.MinDate = new System.DateTime(2021, 1, 7, 0, 0, 0, 0);
                dateTimePicker1.Name = "dateTimePicker1";
                dateTimePicker1.Size = new System.Drawing.Size(154, 30);
                dateTimePicker1.TabIndex = 4;
                // 
                // miejsce
                // 
                miejsce.AutoSize = true;
                miejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                miejsce.Location = new System.Drawing.Point(12, 206);
                miejsce.Name = "miejsce";
                miejsce.Size = new System.Drawing.Size(85, 25);
                miejsce.TabIndex = 5;
                miejsce.Text = "Miejsce:";
                // 
                // miejsceBox
                // 
                miejsceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                miejsceBox.FormattingEnabled = true;
                miejsceBox.Location = new System.Drawing.Point(108, 198);
                miejsceBox.Name = "miejsceBox";
                miejsceBox.Size = new System.Drawing.Size(193, 33);
                miejsceBox.TabIndex = 6;
                // 
                // dodajMiejsce
                // 
                dodajMiejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                dodajMiejsce.Location = new System.Drawing.Point(357, 175);
                dodajMiejsce.Name = "dodajMiejsce";
                dodajMiejsce.Size = new System.Drawing.Size(123, 55);
                dodajMiejsce.TabIndex = 7;
                dodajMiejsce.Text = "Utwórz miejsce";
                dodajMiejsce.UseVisualStyleBackColor = true;
                dodajMiejsce.Click += new System.EventHandler(buttonDodajMiejsce);
                // 
                // utworzWydarzenie
                // 
                utworzWydarzenie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                utworzWydarzenie1.Location = new System.Drawing.Point(173, 278);
                utworzWydarzenie1.Name = "utworzWydarzenie";
                utworzWydarzenie1.Size = new System.Drawing.Size(179, 55);
                utworzWydarzenie1.TabIndex = 8;
                utworzWydarzenie1.Text = "Utwórz wydarzenie";
                utworzWydarzenie1.UseVisualStyleBackColor = true;
                //utworzWydarzenie.Click += new System.EventHandler(button1_Click_1);
                // 
                // UtwórzWydarzenie
                // 
                utworzWydarzenie.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                utworzWydarzenie.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                utworzWydarzenie.ClientSize = new System.Drawing.Size(548, 373);
                utworzWydarzenie.Controls.Add(utworzWydarzenie1);
                utworzWydarzenie.Controls.Add(dodajMiejsce);
                utworzWydarzenie.Controls.Add(miejsceBox);
                utworzWydarzenie.Controls.Add(miejsce);
                utworzWydarzenie.Controls.Add(dateTimePicker1);
                utworzWydarzenie.Controls.Add(data);
                utworzWydarzenie.Controls.Add(tematBox);
                utworzWydarzenie.Controls.Add(temat);
                utworzWydarzenie.Controls.Add(tytul);
                utworzWydarzenie.Name = "UtwórzWydarzenie";
                utworzWydarzenie.Text = "UtwórzWydarzenie";
                utworzWydarzenie.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                // utworzWydarzenie.Load += new System.EventHandler(utworzWydarzenieOrganizacja_Load);
                utworzWydarzenie.ResumeLayout(false);
                utworzWydarzenie.PerformLayout();
                utworzWydarzenie.ShowDialog();
                #endregion

                void buttonDodajMiejsce(object sender3, EventArgs e3)
                {
                    Form noweMiejsce = new Form();
                    noweMiejsce.Height = 465;
                    noweMiejsce.Width = 494;

                    #region layout

                    TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                    Button BtnDodaj = new System.Windows.Forms.Button();
                    Label lblUlica = new System.Windows.Forms.Label();
                    TextBox textUlica = new System.Windows.Forms.TextBox();
                    Label lblMiejscowosc = new System.Windows.Forms.Label();
                    TextBox TextMiejscowosc = new System.Windows.Forms.TextBox();
                    Label lblKodPocztowy = new System.Windows.Forms.Label();
                    TextBox TextKodPo = new System.Windows.Forms.TextBox();
                    Label lblNrBud = new System.Windows.Forms.Label();
                    NumericUpDown NumUpDoBud = new System.Windows.Forms.NumericUpDown();
                    Label lblNrLok = new System.Windows.Forms.Label();
                    NumericUpDown NumUpDoNrLO = new System.Windows.Forms.NumericUpDown();
                    Label LblNrSal = new System.Windows.Forms.Label();
                    TextBox TextNrSali = new System.Windows.Forms.TextBox();
                    Label lblLiczbMiej = new System.Windows.Forms.Label();
                    TextBox TextLiczbaMiejsc = new System.Windows.Forms.TextBox();
                    tableLayoutPanel1.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)(NumUpDoBud)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(NumUpDoNrLO)).BeginInit();
                    this.SuspendLayout();
                    // 
                    // tableLayoutPanel1
                    // 
                    tableLayoutPanel1.ColumnCount = 5;
                    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
                    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23457F));
                    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.73913F));
                    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
                    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.18568F));
                    tableLayoutPanel1.Controls.Add(lblUlica, 1, 0);
                    tableLayoutPanel1.Controls.Add(textUlica, 3, 0);
                    tableLayoutPanel1.Controls.Add(lblMiejscowosc, 1, 1);
                    tableLayoutPanel1.Controls.Add(TextMiejscowosc, 3, 1);
                    tableLayoutPanel1.Controls.Add(lblKodPocztowy, 1, 2);
                    tableLayoutPanel1.Controls.Add(TextKodPo, 3, 2);
                    tableLayoutPanel1.Controls.Add(lblNrBud, 1, 3);
                    tableLayoutPanel1.Controls.Add(NumUpDoBud, 3, 3);
                    tableLayoutPanel1.Controls.Add(lblNrLok, 1, 4);
                    tableLayoutPanel1.Controls.Add(NumUpDoNrLO, 3, 4);
                    tableLayoutPanel1.Controls.Add(LblNrSal, 1, 5);
                    tableLayoutPanel1.Controls.Add(TextNrSali, 3, 5);
                    tableLayoutPanel1.Controls.Add(lblLiczbMiej, 1, 6);
                    tableLayoutPanel1.Controls.Add(TextLiczbaMiejsc, 3, 6);
                    tableLayoutPanel1.Controls.Add(BtnDodaj, 3, 7);
                    tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
                    tableLayoutPanel1.Name = "tableLayoutPanel1";
                    tableLayoutPanel1.RowCount = 8;
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.03448F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.96552F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
                    tableLayoutPanel1.Size = new System.Drawing.Size(452, 448);
                    tableLayoutPanel1.TabIndex = 0;
                    // 
                    // BtnDodaj
                    // 
                    BtnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    BtnDodaj.Location = new System.Drawing.Point(273, 345);
                    BtnDodaj.Name = "BtnDodaj";
                    BtnDodaj.Size = new System.Drawing.Size(127, 50);
                    BtnDodaj.TabIndex = 0;
                    BtnDodaj.Text = "Dodaj";
                    BtnDodaj.UseVisualStyleBackColor = true;
                    BtnDodaj.Click += new System.EventHandler(Dodaj_Click);
                    // 
                    // lblUlica
                    // 
                    lblUlica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblUlica.AutoSize = true;
                    lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblUlica.Location = new System.Drawing.Point(32, 74);
                    lblUlica.Name = "lblUlica";
                    lblUlica.Size = new System.Drawing.Size(69, 29);
                    lblUlica.TabIndex = 1;
                    lblUlica.Text = "ulica:";
                    // 
                    // textUlica
                    // 
                    textUlica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    textUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    textUlica.Location = new System.Drawing.Point(213, 70);
                    textUlica.Name = "textUlica";
                    textUlica.Size = new System.Drawing.Size(179, 30);
                    textUlica.TabIndex = 2;
                    // 
                    // lblMiejscowosc
                    // 
                    lblMiejscowosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblMiejscowosc.AutoSize = true;
                    lblMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblMiejscowosc.Location = new System.Drawing.Point(32, 116);
                    lblMiejscowosc.Name = "lblMiejscowosc";
                    lblMiejscowosc.Size = new System.Drawing.Size(159, 29);
                    lblMiejscowosc.TabIndex = 3;
                    lblMiejscowosc.Text = "miejscowość:";
                    // 
                    // TextMiejscowosc
                    // 
                    TextMiejscowosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    TextMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    TextMiejscowosc.Location = new System.Drawing.Point(213, 112);
                    TextMiejscowosc.Name = "TextMiejscowosc";
                    TextMiejscowosc.Size = new System.Drawing.Size(179, 30);
                    TextMiejscowosc.TabIndex = 4;
                    // 
                    // lblKodPocztowy
                    // 
                    lblKodPocztowy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblKodPocztowy.AutoSize = true;
                    lblKodPocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblKodPocztowy.Location = new System.Drawing.Point(32, 155);
                    lblKodPocztowy.Name = "lblKodPocztowy";
                    lblKodPocztowy.Size = new System.Drawing.Size(165, 29);
                    lblKodPocztowy.TabIndex = 5;
                    lblKodPocztowy.Text = "kod pocztowy:";
                    // 
                    // TextKodPo
                    // 
                    TextKodPo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    TextKodPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    TextKodPo.Location = new System.Drawing.Point(213, 151);
                    TextKodPo.Name = "TextKodPo";
                    TextKodPo.Size = new System.Drawing.Size(116, 30);
                    TextKodPo.TabIndex = 6;
                    // 
                    // lblNrBud
                    // 
                    lblNrBud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblNrBud.AutoSize = true;
                    lblNrBud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblNrBud.Location = new System.Drawing.Point(32, 193);
                    lblNrBud.Name = "lblNrBud";
                    lblNrBud.Size = new System.Drawing.Size(136, 29);
                    lblNrBud.TabIndex = 7;
                    lblNrBud.Text = "nr budynku:";
                    // 
                    // NumUpDoBud
                    // 
                    NumUpDoBud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    NumUpDoBud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    NumUpDoBud.Location = new System.Drawing.Point(213, 189);
                    NumUpDoBud.Name = "NumUpDoBud";
                    NumUpDoBud.Size = new System.Drawing.Size(49, 30);
                    NumUpDoBud.TabIndex = 8;
                    // 
                    // lblNrLok
                    // 
                    lblNrLok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblNrLok.AutoSize = true;
                    lblNrLok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblNrLok.Location = new System.Drawing.Point(32, 232);
                    lblNrLok.Name = "lblNrLok";
                    lblNrLok.Size = new System.Drawing.Size(110, 29);
                    lblNrLok.TabIndex = 9;
                    lblNrLok.Text = "nr lokalu:";
                    // 
                    // NumUpDoNrLO
                    // 
                    NumUpDoNrLO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    NumUpDoNrLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    NumUpDoNrLO.Location = new System.Drawing.Point(213, 228);
                    NumUpDoNrLO.Name = "NumUpDoNrLO";
                    NumUpDoNrLO.Size = new System.Drawing.Size(49, 30);
                    NumUpDoNrLO.TabIndex = 10;
                    // 
                    // LblNrSal
                    // 
                    LblNrSal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    LblNrSal.AutoSize = true;
                    LblNrSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    LblNrSal.Location = new System.Drawing.Point(32, 272);
                    LblNrSal.Name = "LblNrSal";
                    LblNrSal.Size = new System.Drawing.Size(83, 29);
                    LblNrSal.TabIndex = 11;
                    LblNrSal.Text = "nr sali:";
                    // 
                    // TextNrSali
                    // 
                    TextNrSali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    TextNrSali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    TextNrSali.Location = new System.Drawing.Point(213, 268);
                    TextNrSali.Name = "TextNrSali";
                    TextNrSali.Size = new System.Drawing.Size(49, 30);
                    TextNrSali.TabIndex = 12;
                    // 
                    // lblLiczbMiej
                    // 
                    lblLiczbMiej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lblLiczbMiej.AutoSize = true;
                    lblLiczbMiej.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    lblLiczbMiej.Location = new System.Drawing.Point(32, 313);
                    lblLiczbMiej.Name = "lblLiczbMiej";
                    lblLiczbMiej.Size = new System.Drawing.Size(157, 29);
                    lblLiczbMiej.TabIndex = 13;
                    lblLiczbMiej.Text = "liczba miejsc:";
                    // 
                    // TextLiczbaMiejsc
                    // 
                    TextLiczbaMiejsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    TextLiczbaMiejsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    TextLiczbaMiejsc.Location = new System.Drawing.Point(213, 309);
                    TextLiczbaMiejsc.Name = "TextLiczbaMiejsc";
                    TextLiczbaMiejsc.Size = new System.Drawing.Size(49, 30);
                    TextLiczbaMiejsc.TabIndex = 14;
                    // 
                    // DodajMiejsce
                    // 
                    noweMiejsce.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                    noweMiejsce.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    noweMiejsce.ClientSize = new System.Drawing.Size(447, 447);
                    noweMiejsce.Controls.Add(tableLayoutPanel1);
                    noweMiejsce.Controls.Add(temat);
                    noweMiejsce.Controls.Add(tytul);
                    noweMiejsce.Controls.Add(tematBox);
                    noweMiejsce.Controls.Add(data);
                    noweMiejsce.Controls.Add(dateTimePicker1);
                    noweMiejsce.Controls.Add(miejsce);
                    noweMiejsce.Controls.Add(dodajMiejsce);
                    noweMiejsce.Controls.Add(utworzWydarzenie1);
                    noweMiejsce.Name = "DodajMiejsce";
                    noweMiejsce.Text = "DodajMiejsce";
                    noweMiejsce.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    //noweMiejsce.Load += new System.EventHandler(this.DodajMiejsce_Load);
                    tableLayoutPanel1.ResumeLayout(false);
                    tableLayoutPanel1.PerformLayout();
                    ((System.ComponentModel.ISupportInitialize)(NumUpDoBud)).EndInit();
                    ((System.ComponentModel.ISupportInitialize)(NumUpDoNrLO)).EndInit();
                    noweMiejsce.ResumeLayout(false);
                    noweMiejsce.PerformLayout();
                    noweMiejsce.ShowDialog();
                    

                    //utworzWydarzenie.Hide();
                    noweMiejsce.Closed += (s, args) => utworzWydarzenie.Show();
                    
                    //noweMiejsce.Show();
                    #endregion

                    void Dodaj_Click (object sender2, EventArgs e2)
                    {

                    }

                }

            }

            void buttonZ_Click(object sender1, EventArgs e1)
            {
                Form wyslijZaproszenie = new Form();
                wyslijZaproszenie.Height = 537;
                wyslijZaproszenie.Width = 538;

                #region layout

                Label label13 = new System.Windows.Forms.Label();
                Label label16 = new System.Windows.Forms.Label();
                ComboBox comboBox6 = new System.Windows.Forms.ComboBox();
                Label label3 = new System.Windows.Forms.Label();
                Button button5 = new System.Windows.Forms.Button();
                ListView listView5 = new System.Windows.Forms.ListView();
                ColumnHeader columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                ColumnHeader columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                Label label17 = new System.Windows.Forms.Label();
                ComboBox comboBox7 = new System.Windows.Forms.ComboBox();
                wyslijZaproszenie.SuspendLayout();
                // 
                // label13
                // 
                label13.AutoSize = true;
                label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label13.Location = new System.Drawing.Point(22, 37);
                label13.Name = "label13";
                label13.Size = new System.Drawing.Size(164, 31);
                label13.TabIndex = 0;
                label13.Text = "Zaproszenie";
                // 
                // label16
                // 
                label16.AutoSize = true;
                label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label16.Location = new System.Drawing.Point(22, 68);
                label16.Name = "label16";
                label16.Size = new System.Drawing.Size(368, 31);
                label16.TabIndex = 1;
                label16.Text = "do udziału w konferencji jako:";
                //label16.Click += new System.EventHandler(label16_Click);
                // 
                // comboBox6
                // 
                comboBox6.FormattingEnabled = true;
                comboBox6.Items.AddRange(new object[] {
                "Prelegent",
                "Słuchacz"});
                comboBox6.Location = new System.Drawing.Point(403, 75);
                comboBox6.Name = "comboBox6";
                comboBox6.Size = new System.Drawing.Size(143, 24);
                comboBox6.TabIndex = 2;
                // 
                // label3
                // 
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label3.Location = new System.Drawing.Point(24, 190);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(165, 31);
                label3.TabIndex = 3;
                label3.Text = "Wydarzenie:";
                // 
                // button5
                // 
                button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                button5.Location = new System.Drawing.Point(423, 438);
                button5.Name = "button5";
                button5.Size = new System.Drawing.Size(123, 46);
                button5.TabIndex = 6;
                button5.Text = "wyślij";
                button5.UseVisualStyleBackColor = true;
                // 
                // listView5
                // 
                listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                    columnHeader1,
                    columnHeader2});
                listView5.GridLines = true;
                listView5.HideSelection = false;
                listView5.Location = new System.Drawing.Point(30, 233);
                listView5.Name = "listView5";
                listView5.Size = new System.Drawing.Size(516, 199);
                listView5.TabIndex = 7;
                listView5.UseCompatibleStateImageBehavior = false;
                listView5.View = System.Windows.Forms.View.Details;
                // 
                // columnHeader1
                // 
                columnHeader1.Text = "Nr";
                columnHeader1.Width = 30;
                // 
                // columnHeader2
                // 
                columnHeader2.Text = "Temat Konferencji";
                columnHeader2.Width = 500;
                // 
                // label17
                // 
                label17.AutoSize = true;
                label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label17.Location = new System.Drawing.Point(22, 132);
                label17.Name = "label17";
                label17.Size = new System.Drawing.Size(57, 31);
                label17.TabIndex = 8;
                label17.Text = "Do:";
                //label17.Click += new System.EventHandler(label17_Click_1);
                // 
                // comboBox7
                // 
                comboBox7.FormattingEnabled = true;
                comboBox7.Items.AddRange(new object[] {
                "Prelegent",
                "Słuchacz"});
                comboBox7.Location = new System.Drawing.Point(85, 139);
                comboBox7.Name = "comboBox7";
                comboBox7.Size = new System.Drawing.Size(146, 24);
                comboBox7.TabIndex = 9;
                // 
                // WyslijZaproszenie
                // 
                wyslijZaproszenie.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                wyslijZaproszenie.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                wyslijZaproszenie.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                wyslijZaproszenie.ClientSize = new System.Drawing.Size(566, 502);
                wyslijZaproszenie.Controls.Add(comboBox7);
                wyslijZaproszenie.Controls.Add(label17);
                wyslijZaproszenie.Controls.Add(listView5);
                wyslijZaproszenie.Controls.Add(button5);
                wyslijZaproszenie.Controls.Add(label3);
                wyslijZaproszenie.Controls.Add(comboBox6);
                wyslijZaproszenie.Controls.Add(label16);
                wyslijZaproszenie.Controls.Add(label13);
                wyslijZaproszenie.Name = "WyslijZaproszenie";
                wyslijZaproszenie.Text = "WyslijZaproszenie";
                wyslijZaproszenie.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                //przegladKonferencji.Load += new System.EventHandler(this.FormularzTestowy_Load);
                wyslijZaproszenie.ResumeLayout(false);
                wyslijZaproszenie.PerformLayout();
                wyslijZaproszenie.ShowDialog();

                organizacja.Hide();
                #endregion
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Z uwagi na fakt, że tworzenie całego systemu pod kątem oceny nie przyniosłoby rezultatów (wszystkie funkcje kluczowe z punktu widzenia wymogów projektu zostały już zaimplementowane), twórcy postanowili pozostawić sobie zadanie zaprojektowania działania tego formularza do dalszej, samodzielnej już zabawy z .NET. To, co zostało zaprezentowane tutaj jest wyłącznie wizualną prezentacją potencjalnych funkcji SOKu.";
            string caption = "To wciąż wersja Alpha :(";
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            DialogResult result2;
            result2 = MessageBox.Show(message, caption, buttons2);

            Form twojeWydarzenia = new Form();
            twojeWydarzenia.Height = 560;
            twojeWydarzenia.Width = 681;


            #region layout
            Label lblTwojeWyd = new System.Windows.Forms.Label();
            ListBox listBoxTwojeWyd = new System.Windows.Forms.ListBox();
            Button edytujBtn = new System.Windows.Forms.Button();
            Button usunBtn = new System.Windows.Forms.Button();
            Button szczegolyBtn = new System.Windows.Forms.Button();
            twojeWydarzenia.SuspendLayout();
            // 
            // lblTwojeWyd
            // 
            lblTwojeWyd.AutoSize = true;
            lblTwojeWyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            lblTwojeWyd.Location = new System.Drawing.Point(43, 33);
            lblTwojeWyd.Name = "lblTwojeWyd";
            lblTwojeWyd.Size = new System.Drawing.Size(208, 29);
            lblTwojeWyd.TabIndex = 0;
            lblTwojeWyd.Text = "Twoje wydarzenia";
            //lblTwojeWyd.Click += new System.EventHandler(label1_Click);
            // 
            // listBoxTwojeWyd
            // 
            listBoxTwojeWyd.FormattingEnabled = true;
            listBoxTwojeWyd.ItemHeight = 16;
            listBoxTwojeWyd.Location = new System.Drawing.Point(48, 77);
            listBoxTwojeWyd.Name = "listBoxTwojeWyd";
            listBoxTwojeWyd.Size = new System.Drawing.Size(577, 356);
            listBoxTwojeWyd.TabIndex = 1;
            // 
            // edytujBtn
            // 
            edytujBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            edytujBtn.Location = new System.Drawing.Point(372, 443);
            edytujBtn.Name = "edytujBtn";
            edytujBtn.Size = new System.Drawing.Size(124, 48);
            edytujBtn.TabIndex = 2;
            edytujBtn.Text = "Edytuj";
            edytujBtn.UseVisualStyleBackColor = true;
            // 
            // usunBtn
            // 
            usunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            usunBtn.Location = new System.Drawing.Point(502, 443);
            usunBtn.Name = "usunBtn";
            usunBtn.Size = new System.Drawing.Size(123, 48);
            usunBtn.TabIndex = 3;
            usunBtn.Text = "Usuń";
            usunBtn.UseVisualStyleBackColor = true;
            //usunBtn.Click += new System.EventHandler(usunBtn_Click);
            // 
            // szczegolyBtn
            // 
            szczegolyBtn.Location = new System.Drawing.Point(248, 443);
            szczegolyBtn.Name = "szczegolyBtn";
            szczegolyBtn.Size = new System.Drawing.Size(118, 48);
            szczegolyBtn.TabIndex = 5;
            szczegolyBtn.Text = "Szczegóły";
            szczegolyBtn.UseVisualStyleBackColor = true;
            // 
            // TwojeWydarzeniaOrganizator
            // 

            twojeWydarzenia.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            twojeWydarzenia.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            twojeWydarzenia.ClientSize = new System.Drawing.Size(663, 513);
            twojeWydarzenia.Controls.Add(szczegolyBtn);
            twojeWydarzenia.Controls.Add(usunBtn);
            twojeWydarzenia.Controls.Add(edytujBtn);
            twojeWydarzenia.Controls.Add(listBoxTwojeWyd);
            twojeWydarzenia.Controls.Add(lblTwojeWyd);
            twojeWydarzenia.Name = "TwojeWydarzeniaOrganizator";
            twojeWydarzenia.Text = "TwojeWydarzeniaOrganizator";
            twojeWydarzenia.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            twojeWydarzenia.ResumeLayout(false);
            twojeWydarzenia.PerformLayout();
            twojeWydarzenia.ShowDialog();

            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form profilOrganizatora = new Form();
            profilOrganizatora.Height = 344;
            profilOrganizatora.Width = 341;

            #region layout
            Button btnCancel = new System.Windows.Forms.Button();
            Button btnEdit= new System.Windows.Forms.Button();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label4 = new System.Windows.Forms.Label();
            Label label5 = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();
            Label label7 = new System.Windows.Forms.Label();
            Label label8 = new System.Windows.Forms.Label();
            Label label9 = new System.Windows.Forms.Label();
            Label label10 = new System.Windows.Forms.Label();
            Label label11 = new System.Windows.Forms.Label();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(12, 238);
            btnCancel.Name = "btnCreatorCancel";
            btnCancel.Size = new System.Drawing.Size(140, 43);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "OK";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += new System.EventHandler(HideProfile);
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(178, 238);
            btnEdit.Name = "btnCreatorOK";
            btnEdit.Size = new System.Drawing.Size(133, 43);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edytuj";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += new System.EventHandler(EditProfile);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(22, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 17);
            label1.TabIndex = 8;
            label1.Text = "Nazwa użytkownika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(107, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 17);
            label2.TabIndex = 9;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Control;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(63, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 17);
            label3.TabIndex = 10;
            label3.Text = "Numer konta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Control;
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(68, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 17);
            label4.TabIndex = 11;
            label4.Text = "Nazwa firmy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.Control;
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(122, 193);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 17);
            label5.TabIndex = 12;
            label5.Text = "NIP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(175, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(16, 17);
            label6.TabIndex = 13;
            label6.Text = _organizator.Login;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(175, 54);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(16, 17);
            label7.TabIndex = 14;
            label7.Text = _organizator.adres.ulica +' '+ _organizator.adres.numerBudynku+'/'+ _organizator.adres.numerLokalu;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(175, 86);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(16, 17);
            label8.TabIndex = 15;
            label8.Text = _organizator.adres.kodPocztowy+' '+ _organizator.adres.miejscowosc;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(175, 115);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(16, 17);
            label9.TabIndex = 16;
            label9.Text = _organizator.numerKonta.Substring(0, 2) + ' ' + _organizator.numerKonta.Substring(2, 4) + ' ' + _organizator.numerKonta.Substring(6, 4) + ' ' + 
                _organizator.numerKonta.Substring(10, 4) + "\n     " + _organizator.numerKonta.Substring(14, 4) + ' ' + _organizator.numerKonta.Substring(18, 4) + ' ' + _organizator.numerKonta.Substring(22, 4);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(175, 164);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(24, 17);
            label10.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(175, 193);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(24, 17);
            label11.TabIndex = 18;
            if (_organizator.nazwaFirmy != null)
            {
                label10.Text = _organizator.nazwaFirmy;
                label11.Text = _organizator.nip;
            }
            else
            {
                label10.Text = "-";
                label11.Text = "-";
            }
            // 
            // Form
            // 
            profilOrganizatora.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            profilOrganizatora.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            profilOrganizatora.ClientSize = new System.Drawing.Size(323, 297);
            profilOrganizatora.Controls.Add(label11);
            profilOrganizatora.Controls.Add(label10);
            profilOrganizatora.Controls.Add(label9);
            profilOrganizatora.Controls.Add(label8);
            profilOrganizatora.Controls.Add(label7);
            profilOrganizatora.Controls.Add(label6);
            profilOrganizatora.Controls.Add(label5);
            profilOrganizatora.Controls.Add(label4);
            profilOrganizatora.Controls.Add(label3);
            profilOrganizatora.Controls.Add(label2);
            profilOrganizatora.Controls.Add(label1);
            profilOrganizatora.Controls.Add(btnEdit);
            profilOrganizatora.Controls.Add(btnCancel);
            profilOrganizatora.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            profilOrganizatora.Name = "Form";
            profilOrganizatora.Text = "Twój profil";
            profilOrganizatora.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            profilOrganizatora.ResumeLayout(false);
            profilOrganizatora.PerformLayout();
            profilOrganizatora.ShowDialog();

            #endregion

            void HideProfile(object sender2, EventArgs e2)
            {
                profilOrganizatora.Close();
            }
            void EditProfile(object sender2, EventArgs e2)
            {
                string message = "Tu jeszcze nic nie ma.";
                string caption = "To wciąż wersja Alpha :(";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2;
                result2 = MessageBox.Show(message, caption, buttons2);
            }
        }
    }
}
