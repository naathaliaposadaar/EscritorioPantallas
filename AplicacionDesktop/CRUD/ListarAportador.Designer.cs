namespace AplicacionDesktop.CRUD
{
    partial class ListarAportador
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.dgvla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(402, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 29);
            this.btnBuscar.TabIndex = 147;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(355, 68);
            this.txtDv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(31, 20);
            this.txtDv.TabIndex = 135;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(822, 471);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 26);
            this.btnVolver.TabIndex = 134;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(260, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 133;
            this.label8.Text = "Listar Aportador";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(173, 68);
            this.txtRA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(164, 20);
            this.txtRA.TabIndex = 127;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(8, 68);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(117, 21);
            this.lblRA.TabIndex = 122;
            this.lblRA.Text = "Rut Aportador";
            // 
            // dgvla
            // 
            this.dgvla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvla.Location = new System.Drawing.Point(12, 143);
            this.dgvla.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvla.Name = "dgvla";
            this.dgvla.Size = new System.Drawing.Size(886, 318);
            this.dgvla.TabIndex = 131;
            // 
            // ListarAportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(906, 501);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDv);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvla);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.lblRA);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "ListarAportador";
            this.Text = "ListarAportador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.DataGridView dgvla;
    }
}