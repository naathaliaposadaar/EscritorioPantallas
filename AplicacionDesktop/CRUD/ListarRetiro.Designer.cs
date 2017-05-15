namespace AplicacionDesktop.CRUD
{
    partial class ListarRetiro
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgretiropapel = new System.Windows.Forms.DataGridView();
            this.txtidretiro = new System.Windows.Forms.TextBox();
            this.lblir = new System.Windows.Forms.Label();
            this.btnVolverr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgretiropapel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(315, 63);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 30);
            this.btnBuscar.TabIndex = 172;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBFicha_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(716, 569);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 26);
            this.btnVolver.TabIndex = 168;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(266, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 24);
            this.label8.TabIndex = 167;
            this.label8.Text = "Listar Retiro Papelería";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgretiropapel
            // 
            this.dgretiropapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgretiropapel.Location = new System.Drawing.Point(12, 145);
            this.dgretiropapel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgretiropapel.Name = "dgretiropapel";
            this.dgretiropapel.Size = new System.Drawing.Size(774, 224);
            this.dgretiropapel.TabIndex = 165;
            this.dgretiropapel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgretiropapel_CellContentClick);
            // 
            // txtidretiro
            // 
            this.txtidretiro.Location = new System.Drawing.Point(114, 68);
            this.txtidretiro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtidretiro.Name = "txtidretiro";
            this.txtidretiro.Size = new System.Drawing.Size(180, 20);
            this.txtidretiro.TabIndex = 162;
            this.txtidretiro.TextChanged += new System.EventHandler(this.txtidretiro_TextChanged);
            // 
            // lblir
            // 
            this.lblir.AutoSize = true;
            this.lblir.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblir.Location = new System.Drawing.Point(14, 68);
            this.lblir.Name = "lblir";
            this.lblir.Size = new System.Drawing.Size(77, 21);
            this.lblir.TabIndex = 157;
            this.lblir.Text = "ID Retiro";
            this.lblir.Click += new System.EventHandler(this.lblir_Click);
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(720, 377);
            this.btnVolverr.Name = "btnVolverr";
            this.btnVolverr.Size = new System.Drawing.Size(65, 32);
            this.btnVolverr.TabIndex = 173;
            this.btnVolverr.Text = "Volver";
            this.btnVolverr.UseVisualStyleBackColor = true;
            // 
            // ListarRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(793, 415);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgretiropapel);
            this.Controls.Add(this.txtidretiro);
            this.Controls.Add(this.lblir);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "ListarRetiro";
            this.Text = "ListarRetiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgretiropapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgretiropapel;
        private System.Windows.Forms.TextBox txtidretiro;
        private System.Windows.Forms.Label lblir;
        private System.Windows.Forms.Button btnVolverr;
    }
}