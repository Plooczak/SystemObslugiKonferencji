﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace System_obsługi_konferencji
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dlgLogin = new Form();
            dlgLogin.Height = 210;
            dlgLogin.Width = 292;
            //dlgLogin.AutoScaleMode = ;

            #region layout
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();


            textBox1.Location = new System.Drawing.Point(140, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(118, 22);
            //textBox1.TabIndex = 0;

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 17);
            //label1.TabIndex = 2;
            label1.Text = "Nazwa użytkownika";

            textBox2.Location = new System.Drawing.Point(140, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(118, 22);

            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(93, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 17);
            //label2.TabIndex = 3;
            label2.Text = "Hasło";

            button1.Location = new System.Drawing.Point(21, 120);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 32);
            //button1.TabIndex = 4;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(BtnZaloguj);

            button2.Location = new System.Drawing.Point(154, 120);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(104, 32);
            //button2.TabIndex = 7;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(BtnCancel);

            dlgLogin.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            dlgLogin.Controls.Add(textBox1);
            dlgLogin.Controls.Add(textBox2);
            dlgLogin.Controls.Add(label1);
            dlgLogin.Controls.Add(label2);
            dlgLogin.Controls.Add(button1);
            dlgLogin.Controls.Add(button2);
            #endregion

            void BtnZaloguj(object sender2, EventArgs e2)
            {
                dlgLogin.DialogResult = DialogResult.OK;
                dlgLogin.Dispose();
                this.Hide();
                var mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Show();
                mainMenu.Show();
            }

            void BtnCancel(object sender2, EventArgs e2)
            {
                dlgLogin.Close();
            }

            dlgLogin.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form dlgRegister = new Form();
            dlgRegister.Height = 448;
            dlgRegister.Width = 373;

            #region layout
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
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            TextBox textBox3 = new System.Windows.Forms.TextBox();
            DateTimePicker dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
            TextBox textBox4 = new System.Windows.Forms.TextBox();
            TextBox textBox5 = new System.Windows.Forms.TextBox();
            TextBox textBox6 = new System.Windows.Forms.TextBox();
            Button button1 = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(40, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 29);
            label1.TabIndex = 0;
            label1.Text = "Wprowadź swoje dane";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(45, 92);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(120, 22);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(196, 92);
            textBox2.MaxLength = 25;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(120, 22);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(45, 151);
            textBox3.MaxLength = 100;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(152, 22);
            textBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(45, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "K",
            "M"});
            comboBox1.Location = new System.Drawing.Point(273, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(43, 24);
            comboBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(45, 271);
            textBox4.MaxLength = 20;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(120, 22);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(196, 271);
            textBox5.MaxLength = 20;
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(120, 22);
            textBox5.TabIndex = 7;
            textBox5.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(235, 151);
            textBox6.MaxLength = 9;
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(81, 22);
            textBox6.TabIndex = 8;
            textBox6.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label2.Location = new System.Drawing.Point(52, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 13);
            label2.TabIndex = 9;
            label2.Text = "Imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label3.Location = new System.Drawing.Point(204, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 10;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label4.Location = new System.Drawing.Point(52, 135);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 13);
            label4.TabIndex = 11;
            label4.Text = "Adres e-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label5.Location = new System.Drawing.Point(217, 135);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 13);
            label5.TabIndex = 12;
            label5.Text = "Nr telefonu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label6.Location = new System.Drawing.Point(203, 154);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 17);
            label6.TabIndex = 13;
            label6.Text = "+48";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label7.Location = new System.Drawing.Point(279, 195);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 13);
            label7.TabIndex = 14;
            label7.Text = "Płeć";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label8.Location = new System.Drawing.Point(52, 195);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 13);
            label8.TabIndex = 15;
            label8.Text = "Data urodzenia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label9.Location = new System.Drawing.Point(52, 255);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(99, 13);
            label9.TabIndex = 16;
            label9.Text = "Nazwa użytkownika";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label10.Location = new System.Drawing.Point(204, 255);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(33, 13);
            label10.TabIndex = 17;
            label10.Text = "Hasło";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(45, 333);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 38);
            button1.TabIndex = 18;
            button1.Text = "Zarejestruj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(BtnRegister);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(196, 333);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 38);
            button2.TabIndex = 19;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(BtnCancel);
            //
            //
            //
            dlgRegister.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            dlgRegister.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            dlgRegister.ClientSize = new System.Drawing.Size(355, 401);
            dlgRegister.Controls.Add(button2);
            dlgRegister.Controls.Add(button1);
            dlgRegister.Controls.Add(label10);
            dlgRegister.Controls.Add(label9);
            dlgRegister.Controls.Add(label8);
            dlgRegister.Controls.Add(label7);
            dlgRegister.Controls.Add(label6);
            dlgRegister.Controls.Add(label5);
            dlgRegister.Controls.Add(label4);
            dlgRegister.Controls.Add(label3);
            dlgRegister.Controls.Add(label2);
            dlgRegister.Controls.Add(textBox6);
            dlgRegister.Controls.Add(textBox5);
            dlgRegister.Controls.Add(textBox4);
            dlgRegister.Controls.Add(comboBox1);
            dlgRegister.Controls.Add(dateTimePicker1);
            dlgRegister.Controls.Add(textBox3);
            dlgRegister.Controls.Add(textBox2);
            dlgRegister.Controls.Add(textBox1);
            dlgRegister.Controls.Add(label1);
            dlgRegister.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            dlgRegister.Name = "Rejestracja";
            dlgRegister.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            dlgRegister.Text = "Rejestracja";
            dlgRegister.ResumeLayout(false);
            dlgRegister.PerformLayout();
            #endregion

            void BtnRegister(object sender2, EventArgs e2)
            {
                string message = "Zostałeś zarejestrowany!";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                dlgRegister.Close();
            }

            void BtnCancel(object sender2, EventArgs e2)
            {
                dlgRegister.Close();
            }

            dlgRegister.ShowDialog();
        }


        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

       
    }
}
