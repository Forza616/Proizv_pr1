namespace ych_pr
{
    partial class Adm_menu
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
            this.grid_adm = new System.Windows.Forms.DataGridView();
            this.but_del = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.adm_to_app = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_adm)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_adm
            // 
            this.grid_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_adm.Location = new System.Drawing.Point(12, 0);
            this.grid_adm.Name = "grid_adm";
            this.grid_adm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_adm.Size = new System.Drawing.Size(541, 237);
            this.grid_adm.TabIndex = 0;
            this.grid_adm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_adm_CellContentClick);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(29, 284);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 23);
            this.but_del.TabIndex = 1;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(29, 332);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 2;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // adm_to_app
            // 
            this.adm_to_app.Location = new System.Drawing.Point(373, 284);
            this.adm_to_app.Name = "adm_to_app";
            this.adm_to_app.Size = new System.Drawing.Size(132, 41);
            this.adm_to_app.TabIndex = 3;
            this.adm_to_app.Text = "Открыть базу";
            this.adm_to_app.UseVisualStyleBackColor = true;
            this.adm_to_app.Click += new System.EventHandler(this.adm_to_app_Click);
            // 
            // Adm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adm_to_app);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.grid_adm);
            this.Name = "Adm_menu";
            this.Text = "Adm_menu";
            this.Load += new System.EventHandler(this.Adm_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_adm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_adm;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button adm_to_app;
    }
}