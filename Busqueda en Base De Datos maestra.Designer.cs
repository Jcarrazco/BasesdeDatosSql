namespace BasesdeDatosSql
{
    partial class BusquedaMaster
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
            this.Btn_return = new System.Windows.Forms.Button();
            this.Lstb_BD = new System.Windows.Forms.ListBox();
            this.Lstb_Tables = new System.Windows.Forms.ListBox();
            this.Lstb_View = new System.Windows.Forms.ListBox();
            this.Lstb_SP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_return
            // 
            this.Btn_return.Location = new System.Drawing.Point(668, 251);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(73, 53);
            this.Btn_return.TabIndex = 0;
            this.Btn_return.Text = "Regresar";
            this.Btn_return.UseVisualStyleBackColor = true;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // Lstb_BD
            // 
            this.Lstb_BD.FormattingEnabled = true;
            this.Lstb_BD.Location = new System.Drawing.Point(12, 27);
            this.Lstb_BD.Name = "Lstb_BD";
            this.Lstb_BD.Size = new System.Drawing.Size(141, 251);
            this.Lstb_BD.TabIndex = 1;
            // 
            // Lstb_Tables
            // 
            this.Lstb_Tables.FormattingEnabled = true;
            this.Lstb_Tables.Location = new System.Drawing.Point(183, 27);
            this.Lstb_Tables.Name = "Lstb_Tables";
            this.Lstb_Tables.Size = new System.Drawing.Size(141, 251);
            this.Lstb_Tables.TabIndex = 2;
            // 
            // Lstb_View
            // 
            this.Lstb_View.FormattingEnabled = true;
            this.Lstb_View.Location = new System.Drawing.Point(358, 27);
            this.Lstb_View.Name = "Lstb_View";
            this.Lstb_View.Size = new System.Drawing.Size(141, 251);
            this.Lstb_View.TabIndex = 3;
            // 
            // Lstb_SP
            // 
            this.Lstb_SP.FormattingEnabled = true;
            this.Lstb_SP.Location = new System.Drawing.Point(521, 27);
            this.Lstb_SP.Name = "Lstb_SP";
            this.Lstb_SP.Size = new System.Drawing.Size(141, 251);
            this.Lstb_SP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bases de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tablas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stored Procedures";
            // 
            // BusquedaMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lstb_SP);
            this.Controls.Add(this.Lstb_View);
            this.Controls.Add(this.Lstb_Tables);
            this.Controls.Add(this.Lstb_BD);
            this.Controls.Add(this.Btn_return);
            this.Name = "BusquedaMaster";
            this.Text = "Busqueda Base de Datos Master";
            this.Load += new System.EventHandler(this.BusquedaMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_return;
        private System.Windows.Forms.ListBox Lstb_BD;
        private System.Windows.Forms.ListBox Lstb_Tables;
        private System.Windows.Forms.ListBox Lstb_View;
        private System.Windows.Forms.ListBox Lstb_SP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}