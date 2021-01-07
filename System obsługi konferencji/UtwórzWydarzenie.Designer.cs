
namespace System_obsługi_konferencji
{
    partial class UtwórzWydarzenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tytul = new System.Windows.Forms.Label();
            this.temat = new System.Windows.Forms.Label();
            this.tematBox = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.miejsce = new System.Windows.Forms.Label();
            this.miejsceBox = new System.Windows.Forms.ComboBox();
            this.dodajMiejsce = new System.Windows.Forms.Button();
            this.utworzWydarzenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(17, 33);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(528, 25);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "Wprowadź dane potrzebne do utworzenia nowej konferencji";
            // 
            // temat
            // 
            this.temat.AutoSize = true;
            this.temat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temat.Location = new System.Drawing.Point(12, 113);
            this.temat.Name = "temat";
            this.temat.Size = new System.Drawing.Size(74, 25);
            this.temat.TabIndex = 1;
            this.temat.Text = "Temat:";
            // 
            // tematBox
            // 
            this.tematBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tematBox.Location = new System.Drawing.Point(97, 108);
            this.tematBox.Name = "tematBox";
            this.tematBox.Size = new System.Drawing.Size(430, 30);
            this.tematBox.TabIndex = 2;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.Location = new System.Drawing.Point(12, 156);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(59, 25);
            this.data.TabIndex = 3;
            this.data.Text = "Data:";
            this.data.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 151);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // miejsce
            // 
            this.miejsce.AutoSize = true;
            this.miejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejsce.Location = new System.Drawing.Point(12, 206);
            this.miejsce.Name = "miejsce";
            this.miejsce.Size = new System.Drawing.Size(85, 25);
            this.miejsce.TabIndex = 5;
            this.miejsce.Text = "Miejsce:";
            // 
            // miejsceBox
            // 
            this.miejsceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejsceBox.FormattingEnabled = true;
            this.miejsceBox.Location = new System.Drawing.Point(108, 198);
            this.miejsceBox.Name = "miejsceBox";
            this.miejsceBox.Size = new System.Drawing.Size(193, 33);
            this.miejsceBox.TabIndex = 6;
            // 
            // dodajMiejsce
            // 
            this.dodajMiejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajMiejsce.Location = new System.Drawing.Point(357, 175);
            this.dodajMiejsce.Name = "dodajMiejsce";
            this.dodajMiejsce.Size = new System.Drawing.Size(123, 55);
            this.dodajMiejsce.TabIndex = 7;
            this.dodajMiejsce.Text = "Inne miejsce";
            this.dodajMiejsce.UseVisualStyleBackColor = true;
            // 
            // utworzWydarzenie
            // 
            this.utworzWydarzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utworzWydarzenie.Location = new System.Drawing.Point(173, 278);
            this.utworzWydarzenie.Name = "utworzWydarzenie";
            this.utworzWydarzenie.Size = new System.Drawing.Size(179, 55);
            this.utworzWydarzenie.TabIndex = 8;
            this.utworzWydarzenie.Text = "Utwórz wydarzenie";
            this.utworzWydarzenie.UseVisualStyleBackColor = true;
            this.utworzWydarzenie.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UtwórzWydarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 373);
            this.Controls.Add(this.utworzWydarzenie);
            this.Controls.Add(this.dodajMiejsce);
            this.Controls.Add(this.miejsceBox);
            this.Controls.Add(this.miejsce);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.tematBox);
            this.Controls.Add(this.temat);
            this.Controls.Add(this.tytul);
            this.Name = "UtwórzWydarzenie";
            this.Text = "Organizacja";
            this.Load += new System.EventHandler(this.Organizacja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label temat;
        private System.Windows.Forms.TextBox tematBox;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label miejsce;
        private System.Windows.Forms.ComboBox miejsceBox;
        private System.Windows.Forms.Button dodajMiejsce;
        private System.Windows.Forms.Button utworzWydarzenie;
    }
}