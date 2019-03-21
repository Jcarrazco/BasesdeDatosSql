namespace BasesdeDatosSql
{
    partial class Vista_inicial
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
            this.DGV_Resultado = new System.Windows.Forms.DataGridView();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Resultado
            // 
            this.DGV_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Resultado.Location = new System.Drawing.Point(12, 12);
            this.DGV_Resultado.Name = "DGV_Resultado";
            this.DGV_Resultado.Size = new System.Drawing.Size(410, 304);
            this.DGV_Resultado.TabIndex = 0;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(466, 30);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(466, 267);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(87, 49);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Vista_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 328);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.DGV_Resultado);
            this.Name = "Vista_inicial";
            this.Text = "Vista de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Resultado;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}

