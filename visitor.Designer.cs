namespace ych_pr
{
    partial class visitor
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
            this.grid_visit = new System.Windows.Forms.DataGridView();
            this.but_visit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_visit
            // 
            this.grid_visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_visit.Location = new System.Drawing.Point(12, 12);
            this.grid_visit.Name = "grid_visit";
            this.grid_visit.Size = new System.Drawing.Size(577, 203);
            this.grid_visit.TabIndex = 0;
            // 
            // but_visit
            // 
            this.but_visit.Location = new System.Drawing.Point(357, 272);
            this.but_visit.Name = "but_visit";
            this.but_visit.Size = new System.Drawing.Size(91, 45);
            this.but_visit.TabIndex = 1;
            this.but_visit.Text = "Назад";
            this.but_visit.UseVisualStyleBackColor = true;
            // 
            // visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_visit);
            this.Controls.Add(this.grid_visit);
            this.Name = "visitor";
            this.Text = "visitor";
            ((System.ComponentModel.ISupportInitialize)(this.grid_visit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_visit;
        private System.Windows.Forms.Button but_visit;
    }
}