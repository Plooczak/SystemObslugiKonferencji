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
    public partial class ParticipantMenu : Form
    {
        public ParticipantMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form przegladKonferencji = new Form();
            przegladKonferencji.Height = 610;
            przegladKonferencji.Width = 773;

            #region layout
            ListView ListViewConferece = new System.Windows.Forms.ListView();
            ColumnHeader Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader SubjectOfConference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Button ShowDetails = new System.Windows.Forms.Button();
            ComboBox SortComboBox1 = new System.Windows.Forms.ComboBox();
            Button SortBtn = new System.Windows.Forms.Button();
            TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            przegladKonferencji.SuspendLayout();

            // 
            // ListViewConferece
            // 
            ListViewConferece.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            ListViewConferece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Number,
            SubjectOfConference,
            });
            ListViewConferece.GridLines = true;
            ListViewConferece.HideSelection = false;
            ListViewConferece.Location = new System.Drawing.Point(128, 121);
            ListViewConferece.Name = "ListViewConferece";
            ListViewConferece.Size = new System.Drawing.Size(560, 337);
            ListViewConferece.TabIndex = 5;
            ListViewConferece.UseCompatibleStateImageBehavior = false;
            ListViewConferece.View = System.Windows.Forms.View.Details;
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
            SortComboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);

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

            void textBox1_TextChanged(object sender2, EventArgs e2)
            {

            }

            void tableLayoutPanel1_Paint(object sender2, PaintEventArgs e2)
            {

            }

            void listBox1_SelectedIndexChanged(object sender2, EventArgs e2)
            {

            }

            void comboBox1_SelectedIndexChanged(object sender2, EventArgs e2)
            {

            }

            void FormularzTestowy_Load(object sender2, EventArgs e2)
            {

            }

            void listView1_SelectedIndexChanged(object sender2, EventArgs e2)
            {

            }

            void numericUpDown1_ValueChanged(object sender2, EventArgs e2)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form zapisy = new Form();
            zapisy.Height = 534;
            zapisy.Width = 745;

            #region layout

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantMenu));
            TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            //PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            Label label1 = new System.Windows.Forms.Label();
            ListBox listBoxZapisz = new System.Windows.Forms.ListBox();
            Button ZapiszBtn = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            zapisy.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.65672F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.34328F));
            //tableLayoutPanel1.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(listBoxZapisz, 1, 2);
            tableLayoutPanel1.Controls.Add(ZapiszBtn, 1, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.16667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.83333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            tableLayoutPanel1.Size = new System.Drawing.Size(727, 520);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            //pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            //pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            //pictureBox1.Location = new System.Drawing.Point(654, 3);
            //pictureBox1.Name = "pictureBox1";
            //pictureBox1.Size = new System.Drawing.Size(70, 40);
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            //pictureBox1.TabIndex = 1;
            //pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(60, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(298, 33);
            label1.TabIndex = 2;
            label1.Text = "Dostępne konferencje";
            label1.Click += new System.EventHandler(label1_Click);
            // 
            // listBoxZapisz
            // 
            listBoxZapisz.FormattingEnabled = true;
            listBoxZapisz.ItemHeight = 16;
            listBoxZapisz.Location = new System.Drawing.Point(60, 96);
            listBoxZapisz.Name = "listBoxZapisz";
            listBoxZapisz.Size = new System.Drawing.Size(584, 292);
            listBoxZapisz.TabIndex = 3;
            // 
            // ZapiszBtn
            // 
            ZapiszBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ZapiszBtn.Location = new System.Drawing.Point(515, 394);
            ZapiszBtn.Name = "ZapiszBtn";
            ZapiszBtn.Size = new System.Drawing.Size(133, 45);
            ZapiszBtn.TabIndex = 4;
            ZapiszBtn.Text = "Zapisz się";
            ZapiszBtn.UseVisualStyleBackColor = true;
            // 
            // Zapisy
            // 

            zapisy.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            zapisy.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            zapisy.ClientSize = new System.Drawing.Size(727, 487);
            //zapisy.Controls.Add(pictureBox1);
            zapisy.Controls.Add(label1);
            zapisy.Controls.Add(listBoxZapisz);
            zapisy.Controls.Add(ZapiszBtn);
            zapisy.Controls.Add(tableLayoutPanel1);
            zapisy.Name = "Zapisy";
            zapisy.Text = "Zapisy";
            zapisy.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //zapisy.Load += new System.EventHandler(this.FormularzTestowy_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            zapisy.ResumeLayout(false);
            zapisy.PerformLayout();
            zapisy.ShowDialog();

            #endregion
            void tableLayoutPanel1_Paint(object sender1, PaintEventArgs e1)
            {

            }

            void label1_Click(object sender1, EventArgs e1)
            {

            }

            void Zapisy_Load(object sender1, EventArgs e1)
            {

            }

            void listBoxZapisz_SelectedIndexChanged(object sender1, EventArgs e1)
            {

            }

            void ZapiszBtn_Click(object sender1, EventArgs e1)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form twojeWydarzenia = new Form();
            twojeWydarzenia.Height = 356;
            twojeWydarzenia.Width = 577;

            #region layout

            Label label1 = new System.Windows.Forms.Label();
            ListBox listBox1 = new System.Windows.Forms.ListBox();
            Button button2 = new System.Windows.Forms.Button();
            Button button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(25, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 29);
            label1.TabIndex = 1;
            label1.Text = "Twoje wydarzenia";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new System.Drawing.Point(30, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(577, 356);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button2.Location = new System.Drawing.Point(484, 433);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(125, 48);
            button2.TabIndex = 4;
            button2.Text = "Opuść";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(360, 433);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(118, 48);
            button3.TabIndex = 5;
            button3.Text = "Szczegóły";
            button3.UseVisualStyleBackColor = true;
            // 
            // TwojeWydarzeniaUczestnik
            // 

            twojeWydarzenia.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            twojeWydarzenia.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            twojeWydarzenia.ClientSize = new System.Drawing.Size(623, 492);
            twojeWydarzenia.Controls.Add(button3);
            twojeWydarzenia.Controls.Add(button2);
            twojeWydarzenia.Controls.Add(listBox1);
            twojeWydarzenia.Controls.Add(label1);
            twojeWydarzenia.Name = "TwojeWydarzeniaUczestnik";
            twojeWydarzenia.Text = "TwojeWydarzeniaUczestnik";
            twojeWydarzenia.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            twojeWydarzenia.ResumeLayout(false);
            twojeWydarzenia.PerformLayout();
            twojeWydarzenia.ShowDialog();
            #endregion

            void button3_Click(object sender1, EventArgs e1)
            {

            }

            void button2_Click(object sender1, EventArgs e1)
            {

            }

            void listBox1_SelectedIndexChanged(object sender1, EventArgs e1)
            {

            }
        }
    }
}
