namespace AplicacionDesktop.CRUDUsuario
{
    partial class ModificarResidente
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
            this.txtdv = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.combedad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.lblFic = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblf = new System.Windows.Forms.Label();
            this.lblAm = new System.Windows.Forms.Label();
            this.lblAp = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtFi = new System.Windows.Forms.TextBox();
            this.dtFn = new System.Windows.Forms.DateTimePicker();
            this.btnMod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdv
            // 
            this.txtdv.Location = new System.Drawing.Point(345, 113);
            this.txtdv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdv.Name = "txtdv";
            this.txtdv.Size = new System.Drawing.Size(31, 26);
            this.txtdv.TabIndex = 97;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(197, 113);
            this.txtRut.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(138, 26);
            this.txtRut.TabIndex = 96;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 159);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 26);
            this.txtNombre.TabIndex = 94;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(197, 206);
            this.txtAp.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(179, 26);
            this.txtAp.TabIndex = 92;
            // 
            // combedad
            // 
            this.combedad.FormattingEnabled = true;
            this.combedad.Location = new System.Drawing.Point(197, 366);
            this.combedad.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.combedad.Name = "combedad";
            this.combedad.Size = new System.Drawing.Size(139, 29);
            this.combedad.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(280, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 24);
            this.label8.TabIndex = 90;
            this.label8.Text = "Modificar Residentes";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(197, 259);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(179, 26);
            this.txtApeMaterno.TabIndex = 88;
            // 
            // lblFic
            // 
            this.lblFic.AutoSize = true;
            this.lblFic.Location = new System.Drawing.Point(512, 113);
            this.lblFic.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblFic.Name = "lblFic";
            this.lblFic.Size = new System.Drawing.Size(71, 21);
            this.lblFic.TabIndex = 87;
            this.lblFic.Text = "Id Ficha";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(6, 374);
            this.lblE.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(49, 21);
            this.lblE.TabIndex = 86;
            this.lblE.Text = "Edad";
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Location = new System.Drawing.Point(6, 321);
            this.lblf.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(171, 21);
            this.lblf.TabIndex = 85;
            this.lblf.Text = "Fecha de Nacimiento";
            // 
            // lblAm
            // 
            this.lblAm.AutoSize = true;
            this.lblAm.Location = new System.Drawing.Point(8, 264);
            this.lblAm.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAm.Name = "lblAm";
            this.lblAm.Size = new System.Drawing.Size(136, 21);
            this.lblAm.TabIndex = 84;
            this.lblAm.Text = "ApellidoMaterno";
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Location = new System.Drawing.Point(8, 211);
            this.lblAp.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(137, 21);
            this.lblAp.TabIndex = 83;
            this.lblAp.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 162);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 21);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(6, 113);
            this.lblRut.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(37, 21);
            this.lblRut.TabIndex = 81;
            this.lblRut.Text = "Rut";
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(598, 110);
            this.txtFi.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(179, 26);
            this.txtFi.TabIndex = 98;
            // 
            // dtFn
            // 
            this.dtFn.Location = new System.Drawing.Point(197, 316);
            this.dtFn.Name = "dtFn";
            this.dtFn.Size = new System.Drawing.Size(313, 26);
            this.dtFn.TabIndex = 100;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(580, 379);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(110, 31);
            this.btnMod.TabIndex = 101;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(724, 672);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 26);
            this.button2.TabIndex = 102;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 435);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 224);
            this.dataGridView1.TabIndex = 103;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(384, 113);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 29);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // ModificarResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 701);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.dtFn);
            this.Controls.Add(this.txtFi);
            this.Controls.Add(this.txtdv);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.combedad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.lblFic);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblf);
            this.Controls.Add(this.lblAm);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRut);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModificarResidente";
            this.Text = "ModificarResidente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdv;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.ComboBox combedad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label lblFic;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.Label lblAm;
        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtFi;
        private System.Windows.Forms.DateTimePicker dtFn;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
    }
}