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
    public partial class SpeakerMenu : Form
    {
        public SpeakerMenu()
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form twojeWydarzenia = new Form();
            twojeWydarzenia.Height = 544;
            twojeWydarzenia.Width = 630;

            #region layout

            Label label1 = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();
            ListBox listBox1 = new System.Windows.Forms.ListBox();
            Button button3 = new System.Windows.Forms.Button();
            twojeWydarzenia.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(29, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 29);
            label1.TabIndex = 0;
            label1.Text = "Twoje wydarzenia";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(333, 423);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 50);
            button1.TabIndex = 1;
            button1.Text = "Opuść";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(460, 424);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 50);
            button2.TabIndex = 2;
            button2.Text = "Dodaj referat";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new System.Drawing.Point(34, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(545, 340);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(209, 424);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(118, 48);
            button3.TabIndex = 4;
            button3.Text = "Szczegóły";
            button3.UseVisualStyleBackColor = true;
            // 
            // TwojeWydarzeniaPrelegent
            // 
      
            twojeWydarzenia.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            twojeWydarzenia.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            twojeWydarzenia.Controls.Add(button3);
            twojeWydarzenia.Controls.Add(listBox1);
            twojeWydarzenia.Controls.Add(button2);
            twojeWydarzenia.Controls.Add(button1);
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

            void button1_Click(object sender1, EventArgs e1)
            {

            }

            void button2_Click(object sender1, EventArgs e1)
            {
                Form dodajReferat = new Form();
                dodajReferat.Height = 406;
                dodajReferat.Width = 492;

                #region layout
                Button button7 = new System.Windows.Forms.Button();
                Label label7 = new System.Windows.Forms.Label();
                Label label2 = new System.Windows.Forms.Label();
                Label label3 = new System.Windows.Forms.Label();
                TextBox textBox1 = new System.Windows.Forms.TextBox();
                TextBox textBox2 = new System.Windows.Forms.TextBox();
                Label label4 = new System.Windows.Forms.Label();
                Label label5 = new System.Windows.Forms.Label();
                NumericUpDown numericUpDown1 = new System.Windows.Forms.NumericUpDown();
                NumericUpDown numericUpDown2 = new System.Windows.Forms.NumericUpDown();
                ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(numericUpDown2)).BeginInit();
                dodajReferat.SuspendLayout();
                // 
                // button1
                // 
                button7.Location = new System.Drawing.Point(270, 382);
                button7.Name = "button1";
                button7.Size = new System.Drawing.Size(106, 51);
                button7.TabIndex = 0;
                button7.Text = "Dodaj referat";
                button7.UseVisualStyleBackColor = true;
                button7.Click += new System.EventHandler(button1_Click);
                // 
                // label1
                // 
                label7.AutoSize = true;
                label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label7.Location = new System.Drawing.Point(18, 25);
                label7.Name = "label1";
                label7.Size = new System.Drawing.Size(74, 25);
                label7.TabIndex = 1;
                label7.Text = "Temat:";
                // 
                // label2
                // 
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label2.Location = new System.Drawing.Point(18, 64);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(131, 25);
                label2.TabIndex = 2;
                label2.Text = "Streszczenie:";
                // 
                // label3
                // 
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label3.Location = new System.Drawing.Point(18, 242);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(233, 25);
                label3.TabIndex = 3;
                label3.Text = "Szacowany czas trwania:";
                // 
                // textBox1
                // 
                textBox1.Location = new System.Drawing.Point(92, 25);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(283, 22);
                textBox1.TabIndex = 4;
                // 
                // textBox2
                // 
                textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                textBox2.Location = new System.Drawing.Point(23, 92);
                textBox2.Multiline = true;
                textBox2.Name = "textBox2";
                textBox2.Size = new System.Drawing.Size(354, 135);
                textBox2.TabIndex = 5;
                // 
                // label4
                // 
                label4.AutoSize = true;
                label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label4.Location = new System.Drawing.Point(18, 277);
                label4.Name = "label4";
                label4.Size = new System.Drawing.Size(86, 25);
                label4.TabIndex = 6;
                label4.Text = "godziny:";
                // 
                // label5
                // 
                label5.AutoSize = true;
                label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                label5.Location = new System.Drawing.Point(165, 277);
                label5.Name = "label5";
                label5.Size = new System.Drawing.Size(75, 25);
                label5.TabIndex = 7;
                label5.Text = "minuty:";
                // 
                // numericUpDown1
                // 
                numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                numericUpDown1.Location = new System.Drawing.Point(110, 280);
                numericUpDown1.Maximum = new decimal(new int[] {
                2,
                0,
                0,
                0});
                numericUpDown1.Name = "numericUpDown1";
                numericUpDown1.Size = new System.Drawing.Size(41, 24);
                numericUpDown1.TabIndex = 8;
                // 
                // numericUpDown2
                // 
                numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                numericUpDown2.Location = new System.Drawing.Point(246, 280);
                numericUpDown2.Maximum = new decimal(new int[] {
                60,
                0,
                0,
                0});
                numericUpDown2.Name = "numericUpDown2";
                numericUpDown2.Size = new System.Drawing.Size(41, 24);
                numericUpDown2.TabIndex = 9;
                // 
                // Dodaj_referat
                // 
                dodajReferat.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                dodajReferat.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                dodajReferat.ClientSize = new System.Drawing.Size(388, 445);
                dodajReferat.Controls.Add(numericUpDown2);
                dodajReferat.Controls.Add(numericUpDown1);
                dodajReferat.Controls.Add(label5);
                dodajReferat.Controls.Add(label4);
                dodajReferat.Controls.Add(textBox2);
                dodajReferat.Controls.Add(textBox1);
                dodajReferat.Controls.Add(label3);
                dodajReferat.Controls.Add(label2);
                dodajReferat.Controls.Add(label7);
                dodajReferat.Controls.Add(button7);
                dodajReferat.Name = "Dodaj_referat";
                dodajReferat.Text = "Dodaj_referat";
                dodajReferat.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                //dodajReferat.Load += new System.EventHandler(this.Dodaj_referat_Load);
                ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(numericUpDown2)).EndInit();
                dodajReferat.ResumeLayout(false);
                dodajReferat.PerformLayout();
                dodajReferat.ShowDialog();
                #endregion

                void button7_Click(object sender2, EventArgs e2)
                {

                }

                void Dodaj_referat_Load(object sender2, EventArgs e2)
                {

                }

                void numericUpDown1_ValueChanged(object sender2, EventArgs e2)
                {

                }

                void numericUpDown2_ValueChanged(object sender2, EventArgs e2)
                {

                }

                void textBox2_TextChanged(object sender2, EventArgs e2)
                {

                }

                void textBox1_TextChanged(object sender2, EventArgs e2)
                {

                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
