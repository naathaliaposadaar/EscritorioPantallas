namespace AplicacionDesktop.CRUDUsuario
{
    partial class EliminarResidente
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
            this.combedad = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApeM = new System.Windows.Forms.TextBox();
            this.lblIDF = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.lblFNa = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtAPa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtdv = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtFN = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combedad
            // 
            this.combedad.FormattingEnabled = true;
            this.combedad.Location = new System.Drawing.Point(238, 350);
            this.combedad.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.combedad.Name = "combedad";
            this.combedad.Size = new System.Drawing.Size(94, 29);
            this.combedad.TabIndex = 68;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(1072, 1029);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 42);
            this.btnVolver.TabIndex = 67;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(318, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = "Eliminar Residente";
            // 
            // txtApeM
            // 
            this.txtApeM.Location = new System.Drawing.Point(238, 248);
            this.txtApeM.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtApeM.Name = "txtApeM";
            this.txtApeM.Size = new System.Drawing.Size(179, 26);
            this.txtApeM.TabIndex = 59;
            // 
            // lblIDF
            // 
            this.lblIDF.AutoSize = true;
            this.lblIDF.Location = new System.Drawing.Point(523, 97);
            this.lblIDF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIDF.Name = "lblIDF";
            this.lblIDF.Size = new System.Drawing.Size(72, 21);
            this.lblIDF.TabIndex = 57;
            this.lblIDF.Text = "ID Ficha";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.Location = new System.Drawing.Point(58, 357);
            this.lblEd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(49, 21);
            this.lblEd.TabIndex = 56;
            this.lblEd.Text = "Edad";
            // 
            // lblFNa
            // 
            this.lblFNa.AutoSize = true;
            this.lblFNa.Location = new System.Drawing.Point(58, 305);
            this.lblFNa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFNa.Name = "lblFNa";
            this.lblFNa.Size = new System.Drawing.Size(171, 21);
            this.lblFNa.TabIndex = 55;
            this.lblFNa.Text = "Fecha de Nacimiento";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(58, 253);
            this.lblAM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(136, 21);
            this.lblAM.TabIndex = 54;
            this.lblAM.Text = "ApellidoMaterno";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(58, 198);
            this.lblAP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(137, 21);
            this.lblAP.TabIndex = 53;
            this.lblAP.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 152);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 21);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(57, 104);
            this.lblRut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(37, 21);
            this.lblRut.TabIndex = 51;
            this.lblRut.Text = "Rut";
            // 
            // txtAPa
            // 
            this.txtAPa.Location = new System.Drawing.Point(238, 193);
            this.txtAPa.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtAPa.Name = "txtAPa";
            this.txtAPa.Size = new System.Drawing.Size(179, 26);
            this.txtAPa.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 391);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 224);
            this.dataGridView1.TabIndex = 74;
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(605, 95);
            this.txtF.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(187, 26);
            this.txtF.TabIndex = 75;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(551, 344);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 34);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(724, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 77;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(238, 97);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(144, 26);
            this.txtRut.TabIndex = 78;
            // 
            // txtdv
            // 
            this.txtdv.Location = new System.Drawing.Point(389, 97);
            this.txtdv.Name = "txtdv";
            this.txtdv.Size = new System.Drawing.Size(26, 26);
            this.txtdv.TabIndex = 79;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(238, 147);
            this.txtN.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(179, 26);
            this.txtN.TabIndex = 80;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(419, 96);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 25);
            this.btnBuscar.TabIndex = 81;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dtFN
            // 
            this.dtFN.Location = new System.Drawing.Point(238, 300);
            this.dtFN.Name = "dtFN";
            this.dtFN.Size = new System.Drawing.Size(200, 26);
            this.dtFN.TabIndex = 82;
            // 
            // EliminarResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(798, 658);
            this.Controls.Add(this.dtFN);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtdv);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAPa);
            this.Controls.Add(this.combedad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApeM);
            this.Controls.Add(this.lblIDF);
            this.Controls.Add(this.lblEd);
            this.Controls.Add(this.lblFNa);
            this.Controls.Add(this.lblAM);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRut);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarResidente";
            this.Text = "EliminarResidentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combedad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.Label lblIDF;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.Label lblFNa;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtAPa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtdv;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtFN;
    }
}