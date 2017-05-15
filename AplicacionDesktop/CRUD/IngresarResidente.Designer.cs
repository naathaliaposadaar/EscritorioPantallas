namespace AplicacionDesktop.CRUDUsuario
{
    partial class IngresarResidente
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidficha = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblEdadR = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblApM = new System.Windows.Forms.Label();
            this.lblApP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRutR = new System.Windows.Forms.Label();
            this.txtdv = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.combedad = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtFN = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(300, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ingresar Residente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 397);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 224);
            this.dataGridView1.TabIndex = 41;
            // 
            // txtidficha
            // 
            this.txtidficha.Location = new System.Drawing.Point(565, 97);
            this.txtidficha.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtidficha.Name = "txtidficha";
            this.txtidficha.Size = new System.Drawing.Size(187, 26);
            this.txtidficha.TabIndex = 39;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(254, 255);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(179, 26);
            this.txtApeMaterno.TabIndex = 34;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(254, 198);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(179, 26);
            this.txtApePaterno.TabIndex = 33;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(255, 97);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(144, 26);
            this.txtRut.TabIndex = 31;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(486, 97);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(72, 21);
            this.lblid.TabIndex = 30;
            this.lblid.Text = "ID Ficha";
            // 
            // lblEdadR
            // 
            this.lblEdadR.AutoSize = true;
            this.lblEdadR.Location = new System.Drawing.Point(76, 368);
            this.lblEdadR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadR.Name = "lblEdadR";
            this.lblEdadR.Size = new System.Drawing.Size(49, 21);
            this.lblEdadR.TabIndex = 28;
            this.lblEdadR.Text = "Edad";
            this.lblEdadR.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(75, 313);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(171, 21);
            this.lblFN.TabIndex = 27;
            this.lblFN.Text = "Fecha de Nacimiento";
            // 
            // lblApM
            // 
            this.lblApM.AutoSize = true;
            this.lblApM.Location = new System.Drawing.Point(75, 255);
            this.lblApM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApM.Name = "lblApM";
            this.lblApM.Size = new System.Drawing.Size(136, 21);
            this.lblApM.TabIndex = 26;
            this.lblApM.Text = "ApellidoMaterno";
            // 
            // lblApP
            // 
            this.lblApP.AutoSize = true;
            this.lblApP.Location = new System.Drawing.Point(75, 201);
            this.lblApP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApP.Name = "lblApP";
            this.lblApP.Size = new System.Drawing.Size(137, 21);
            this.lblApP.TabIndex = 25;
            this.lblApP.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 147);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 21);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRutR
            // 
            this.lblRutR.AutoSize = true;
            this.lblRutR.Location = new System.Drawing.Point(76, 97);
            this.lblRutR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutR.Name = "lblRutR";
            this.lblRutR.Size = new System.Drawing.Size(37, 21);
            this.lblRutR.TabIndex = 23;
            this.lblRutR.Text = "Rut";
            // 
            // txtdv
            // 
            this.txtdv.Location = new System.Drawing.Point(407, 97);
            this.txtdv.Name = "txtdv";
            this.txtdv.Size = new System.Drawing.Size(26, 26);
            this.txtdv.TabIndex = 45;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(737, 623);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 26);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // combedad
            // 
            this.combedad.FormattingEnabled = true;
            this.combedad.Location = new System.Drawing.Point(253, 360);
            this.combedad.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.combedad.Name = "combedad";
            this.combedad.Size = new System.Drawing.Size(133, 29);
            this.combedad.TabIndex = 49;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(668, 346);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(119, 43);
            this.btnIngresar.TabIndex = 50;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 147);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 26);
            this.txtNombre.TabIndex = 51;
            // 
            // dtFN
            // 
            this.dtFN.Location = new System.Drawing.Point(255, 313);
            this.dtFN.Name = "dtFN";
            this.dtFN.Size = new System.Drawing.Size(303, 26);
            this.dtFN.TabIndex = 52;
            // 
            // IngresarResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(827, 648);
            this.Controls.Add(this.dtFN);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.combedad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtdv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtidficha);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblEdadR);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblApM);
            this.Controls.Add(this.lblApP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRutR);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IngresarResidente";
            this.Text = "IngresarResidente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidficha;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblEdadR;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblApM;
        private System.Windows.Forms.Label lblApP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRutR;
        private System.Windows.Forms.TextBox txtdv;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox combedad;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtFN;
    }
}