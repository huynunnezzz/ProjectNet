namespace De_1
{
    partial class Find
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
            this.drTimkiem = new System.Windows.Forms.DataGridView();
            this.txtQuenquan = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.rdQuequan = new System.Windows.Forms.RadioButton();
            this.rdDonvi = new System.Windows.Forms.RadioButton();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.rdHocham = new System.Windows.Forms.RadioButton();
            this.txtHocham = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // drTimkiem
            // 
            this.drTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drTimkiem.Location = new System.Drawing.Point(2, 135);
            this.drTimkiem.Name = "drTimkiem";
            this.drTimkiem.RowHeadersWidth = 51;
            this.drTimkiem.RowTemplate.Height = 24;
            this.drTimkiem.Size = new System.Drawing.Size(969, 316);
            this.drTimkiem.TabIndex = 3;
            // 
            // txtQuenquan
            // 
            this.txtQuenquan.Location = new System.Drawing.Point(159, 9);
            this.txtQuenquan.Name = "txtQuenquan";
            this.txtQuenquan.Size = new System.Drawing.Size(156, 22);
            this.txtQuenquan.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(448, 66);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(141, 40);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // rdQuequan
            // 
            this.rdQuequan.AutoSize = true;
            this.rdQuequan.Location = new System.Drawing.Point(53, 11);
            this.rdQuequan.Name = "rdQuequan";
            this.rdQuequan.Size = new System.Drawing.Size(86, 20);
            this.rdQuequan.TabIndex = 11;
            this.rdQuequan.TabStop = true;
            this.rdQuequan.Text = "Quê quán";
            this.rdQuequan.UseVisualStyleBackColor = true;
            // 
            // rdDonvi
            // 
            this.rdDonvi.AutoSize = true;
            this.rdDonvi.Location = new System.Drawing.Point(53, 55);
            this.rdDonvi.Name = "rdDonvi";
            this.rdDonvi.Size = new System.Drawing.Size(65, 20);
            this.rdDonvi.TabIndex = 13;
            this.rdDonvi.TabStop = true;
            this.rdDonvi.Text = "Đơn vị";
            this.rdDonvi.UseVisualStyleBackColor = true;
            // 
            // txtDonvi
            // 
            this.txtDonvi.Location = new System.Drawing.Point(159, 53);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(156, 22);
            this.txtDonvi.TabIndex = 12;
            // 
            // rdHocham
            // 
            this.rdHocham.AutoSize = true;
            this.rdHocham.Location = new System.Drawing.Point(371, 13);
            this.rdHocham.Name = "rdHocham";
            this.rdHocham.Size = new System.Drawing.Size(82, 20);
            this.rdHocham.TabIndex = 15;
            this.rdHocham.TabStop = true;
            this.rdHocham.Text = "Học hàm";
            this.rdHocham.UseVisualStyleBackColor = true;
            // 
            // txtHocham
            // 
            this.txtHocham.Location = new System.Drawing.Point(493, 9);
            this.txtHocham.Name = "txtHocham";
            this.txtHocham.Size = new System.Drawing.Size(156, 22);
            this.txtHocham.TabIndex = 14;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.rdHocham);
            this.Controls.Add(this.txtHocham);
            this.Controls.Add(this.rdDonvi);
            this.Controls.Add(this.txtDonvi);
            this.Controls.Add(this.rdQuequan);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtQuenquan);
            this.Controls.Add(this.drTimkiem);
            this.Name = "Find";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.drTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView drTimkiem;
        private System.Windows.Forms.TextBox txtQuenquan;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton rdQuequan;
        private System.Windows.Forms.RadioButton rdDonvi;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.RadioButton rdHocham;
        private System.Windows.Forms.TextBox txtHocham;
    }
}