namespace ych_pr
{
    partial class info_postav
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
            this.grid_postav = new System.Windows.Forms.DataGridView();
            this.but_postav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_postav)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_postav
            // 
            this.grid_postav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_postav.Location = new System.Drawing.Point(12, 37);
            this.grid_postav.Name = "grid_postav";
            this.grid_postav.Size = new System.Drawing.Size(544, 198);
            this.grid_postav.TabIndex = 0;
            // 
            // but_postav
            // 
            this.but_postav.Location = new System.Drawing.Point(323, 303);
            this.but_postav.Name = "but_postav";
            this.but_postav.Size = new System.Drawing.Size(91, 49);
            this.but_postav.TabIndex = 1;
            this.but_postav.Text = "Назад";
            this.but_postav.UseVisualStyleBackColor = true;
            this.but_postav.Click += new System.EventHandler(this.but_postav_Click);
            // 
            // info_postav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_postav);
            this.Controls.Add(this.grid_postav);
            this.Name = "info_postav";
            this.Text = "info_postav";
            this.Load += new System.EventHandler(this.info_postav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_postav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_postav;
        private System.Windows.Forms.Button but_postav;
    }
}