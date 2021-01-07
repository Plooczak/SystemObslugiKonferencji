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
        public OrganizerMenu()
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
    }
}
