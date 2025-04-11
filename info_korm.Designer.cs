namespace ych_pr
{
    partial class info_korm
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
            this.grid_korm = new System.Windows.Forms.DataGridView();
            this.but_korm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_korm)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_korm
            // 
            this.grid_korm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_korm.Location = new System.Drawing.Point(12, 12);
            this.grid_korm.Name = "grid_korm";
            this.grid_korm.Size = new System.Drawing.Size(549, 180);
            this.grid_korm.TabIndex = 0;
            // 
            // but_korm
            // 
            this.but_korm.Location = new System.Drawing.Point(352, 285);
            this.but_korm.Name = "but_korm";
            this.but_korm.Size = new System.Drawing.Size(85, 45);
            this.but_korm.TabIndex = 1;
            this.but_korm.Text = "Назад";
            this.but_korm.UseVisualStyleBackColor = true;
            this.but_korm.Click += new System.EventHandler(this.but_korm_Click);
            // 
            // info_korm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_korm);
            this.Controls.Add(this.grid_korm);
            this.Name = "info_korm";
            this.Text = "info_korm";
            this.Load += new System.EventHandler(this.info_korm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_korm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_korm;
        private System.Windows.Forms.Button but_korm;
    }
}