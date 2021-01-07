
namespace System_obsługi_konferencji
{
    partial class PrzeglądKonferencji
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
            this.ListViewConferece = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectOfConference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowDetails = new System.Windows.Forms.Button();
            this.SortComboBox1 = new System.Windows.Forms.ComboBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewConferece
            // 
            this.ListViewConferece.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListViewConferece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.SubjectOfConference,
            this.Date});
            this.ListViewConferece.GridLines = true;
            this.ListViewConferece.HideSelection = false;
            this.ListViewConferece.Location = new System.Drawing.Point(128, 121);
            this.ListViewConferece.Name = "ListViewConferece";
            this.ListViewConferece.Size = new System.Drawing.Size(560, 337);
            this.ListViewConferece.TabIndex = 5;
            this.ListViewConferece.UseCompatibleStateImageBehavior = false;
            this.ListViewConferece.View = System.Windows.Forms.View.Details;
            this.ListViewConferece.SelectedIndexChanged += new System.EventHandler(this.ListViewConferece_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "Nr";
            this.Number.Width = 30;
            // 
            // SubjectOfConference
            // 
            this.SubjectOfConference.Text = "Temat Konferencji";
            this.SubjectOfConference.Width = 400;
            // 
            // Date
            // 
            this.Date.Text = "Data Konferencji";
            this.Date.Width = 125;
            // 
            // ShowDetails
            // 
            this.ShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDetails.Location = new System.Drawing.Point(512, 489);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(176, 41);
            this.ShowDetails.TabIndex = 4;
            this.ShowDetails.Text = "Pokaż szczegóły";
            this.ShowDetails.UseVisualStyleBackColor = true;
            // 
            // SortComboBox1
            // 
            this.SortComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SortComboBox1.FormattingEnabled = true;
            this.SortComboBox1.Items.AddRange(new object[] {
            "data rosnąco",
            "data malejąco",
            "alfabetycznie"});
            this.SortComboBox1.Location = new System.Drawing.Point(128, 92);
            this.SortComboBox1.Name = "SortComboBox1";
            this.SortComboBox1.Size = new System.Drawing.Size(159, 24);
            this.SortComboBox1.TabIndex = 2;
            this.SortComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SortBtn
            // 
            this.SortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBtn.Location = new System.Drawing.Point(25, 92);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(97, 23);
            this.SortBtn.TabIndex = 0;
            this.SortBtn.Text = "Sortuj";
            this.SortBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.59808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.90092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.586526F));
            this.tableLayoutPanel1.Controls.Add(this.SortBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowDetails, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ListViewConferece, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SortComboBox1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.23763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 565);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PrzeglądKonferencji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrzeglądKonferencji";
            this.Text = "Przegląd Konferencji";
            this.Load += new System.EventHandler(this.FormularzTestowy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewConferece;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader SubjectOfConference;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button ShowDetails;
        private System.Windows.Forms.ComboBox SortComboBox1;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}