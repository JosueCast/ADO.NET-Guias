namespace Capa_Desconectada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerTpiado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObtenerTpiado);
            this.groupBox1.Controls.Add(this.gridTipado);
            this.groupBox1.Location = new System.Drawing.Point(392, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet Tipado";
            // 
            // btnObtenerTpiado
            // 
            this.btnObtenerTpiado.Location = new System.Drawing.Point(103, 299);
            this.btnObtenerTpiado.Name = "btnObtenerTpiado";
            this.btnObtenerTpiado.Size = new System.Drawing.Size(140, 23);
            this.btnObtenerTpiado.TabIndex = 2;
            this.btnObtenerTpiado.Text = "Obtener Datos Tipados";
            this.btnObtenerTpiado.UseVisualStyleBackColor = true;
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(6, 29);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(347, 250);
            this.gridTipado.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox2.Controls.Add(this.gridNoTipado);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet no Tipado";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(91, 299);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(126, 23);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener No Tipado";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(6, 29);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(351, 250);
            this.gridNoTipado.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerTpiado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNoTipado;
    }
}

