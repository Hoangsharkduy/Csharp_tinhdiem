namespace Csharp_tinhdiem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txttrungbinh = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntinhtrungbinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Văn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trung Bình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xếp Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 18);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TÍnh điểm";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(126, 69);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 6;
            this.txtten.Text = "shark";
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(126, 126);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 7;
            this.txttoan.Text = "8";
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(126, 174);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 8;
            this.txtvan.Text = "8";
            // 
            // txttrungbinh
            // 
            this.txttrungbinh.Location = new System.Drawing.Point(126, 222);
            this.txttrungbinh.Name = "txttrungbinh";
            this.txttrungbinh.Size = new System.Drawing.Size(100, 20);
            this.txttrungbinh.TabIndex = 9;
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(126, 280);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(325, 373);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntinhtrungbinh
            // 
            this.btntinhtrungbinh.Location = new System.Drawing.Point(126, 373);
            this.btntinhtrungbinh.Name = "btntinhtrungbinh";
            this.btntinhtrungbinh.Size = new System.Drawing.Size(120, 23);
            this.btntinhtrungbinh.TabIndex = 12;
            this.btntinhtrungbinh.Text = "Tính Trung Bình";
            this.btntinhtrungbinh.UseVisualStyleBackColor = true;
            this.btntinhtrungbinh.Click += new System.EventHandler(this.btntinhtrungbinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinhtrungbinh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txttrungbinh);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txttrungbinh;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntinhtrungbinh;
    }
}

