
namespace System_obsługi_konferencji
{
    partial class TwojeWydarzeniaOrganizator
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
            this.lblTwojeWyd = new System.Windows.Forms.Label();
            this.listBoxTwojeWyd = new System.Windows.Forms.ListBox();
            this.edytujBtn = new System.Windows.Forms.Button();
            this.usunBtn = new System.Windows.Forms.Button();
            this.szczegolyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTwojeWyd
            // 
            this.lblTwojeWyd.AutoSize = true;
            this.lblTwojeWyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTwojeWyd.Location = new System.Drawing.Point(43, 33);
            this.lblTwojeWyd.Name = "lblTwojeWyd";
            this.lblTwojeWyd.Size = new System.Drawing.Size(208, 29);
            this.lblTwojeWyd.TabIndex = 0;
            this.lblTwojeWyd.Text = "Twoje wydarzenia";
            this.lblTwojeWyd.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxTwojeWyd
            // 
            this.listBoxTwojeWyd.FormattingEnabled = true;
            this.listBoxTwojeWyd.ItemHeight = 16;
            this.listBoxTwojeWyd.Location = new System.Drawing.Point(48, 77);
            this.listBoxTwojeWyd.Name = "listBoxTwojeWyd";
            this.listBoxTwojeWyd.Size = new System.Drawing.Size(577, 356);
            this.listBoxTwojeWyd.TabIndex = 1;
            // 
            // edytujBtn
            // 
            this.edytujBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujBtn.Location = new System.Drawing.Point(372, 443);
            this.edytujBtn.Name = "edytujBtn";
            this.edytujBtn.Size = new System.Drawing.Size(124, 48);
            this.edytujBtn.TabIndex = 2;
            this.edytujBtn.Text = "Edytuj";
            this.edytujBtn.UseVisualStyleBackColor = true;
            // 
            // usunBtn
            // 
            this.usunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunBtn.Location = new System.Drawing.Point(502, 443);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(123, 48);
            this.usunBtn.TabIndex = 3;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.UseVisualStyleBackColor = true;
            this.usunBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // szczegolyBtn
            // 
            this.szczegolyBtn.Location = new System.Drawing.Point(248, 443);
            this.szczegolyBtn.Name = "szczegolyBtn";
            this.szczegolyBtn.Size = new System.Drawing.Size(118, 48);
            this.szczegolyBtn.TabIndex = 5;
            this.szczegolyBtn.Text = "Szczegóły";
            this.szczegolyBtn.UseVisualStyleBackColor = true;
            // 
            // TwojeWydarzeniaOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 513);
            this.Controls.Add(this.szczegolyBtn);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.edytujBtn);
            this.Controls.Add(this.listBoxTwojeWyd);
            this.Controls.Add(this.lblTwojeWyd);
            this.Name = "TwojeWydarzeniaOrganizator";
            this.Text = "TwojeWydarzeniaOrganizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTwojeWyd;
        private System.Windows.Forms.ListBox listBoxTwojeWyd;
        private System.Windows.Forms.Button edytujBtn;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Button szczegolyBtn;
    }
}