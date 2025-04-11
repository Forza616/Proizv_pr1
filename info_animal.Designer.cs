namespace ych_pr
{
    partial class info_animal
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
            this.grid_animal = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.but_anim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_animal)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_animal
            // 
            this.grid_animal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_animal.Location = new System.Drawing.Point(12, 54);
            this.grid_animal.Name = "grid_animal";
            this.grid_animal.Size = new System.Drawing.Size(776, 250);
            this.grid_animal.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Вся информация",
            "Земноводное",
            "Млекопитающее",
            "Птица"});
            this.comboBox2.Location = new System.Drawing.Point(12, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // but_anim
            // 
            this.but_anim.Location = new System.Drawing.Point(337, 327);
            this.but_anim.Name = "but_anim";
            this.but_anim.Size = new System.Drawing.Size(94, 51);
            this.but_anim.TabIndex = 2;
            this.but_anim.Text = "Назад";
            this.but_anim.UseVisualStyleBackColor = true;
            this.but_anim.Click += new System.EventHandler(this.but_anim_Click);
            // 
            // info_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_anim);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.grid_animal);
            this.Name = "info_animal";
            this.Text = "info_animal";
            this.Load += new System.EventHandler(this.info_animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_animal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_animal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button but_anim;
    }
}