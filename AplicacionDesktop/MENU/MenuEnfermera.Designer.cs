namespace AplicacionDesktop.MENU
{
    partial class MenuEnfermera
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
            this.btnsolicitudm = new System.Windows.Forms.Button();
            this.btnfichar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsolicitudm
            // 
            this.btnsolicitudm.Location = new System.Drawing.Point(309, 140);
            this.btnsolicitudm.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsolicitudm.Name = "btnsolicitudm";
            this.btnsolicitudm.Size = new System.Drawing.Size(191, 61);
            this.btnsolicitudm.TabIndex = 8;
            this.btnsolicitudm.Text = "Gestionar Solicitud de Medicamnetos";
            this.btnsolicitudm.UseVisualStyleBackColor = true;
            // 
            // btnfichar
            // 
            this.btnfichar.Location = new System.Drawing.Point(84, 140);
            this.btnfichar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnfichar.Name = "btnfichar";
            this.btnfichar.Size = new System.Drawing.Size(178, 61);
            this.btnfichar.TabIndex = 7;
            this.btnfichar.Text = "Gestionar Fichas de Residentes";
            this.btnfichar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(202, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenida Enfermera";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuEnfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(677, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsolicitudm);
            this.Controls.Add(this.btnfichar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuEnfermera";
            this.Text = "MenuEnfermera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsolicitudm;
        private System.Windows.Forms.Button btnfichar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}