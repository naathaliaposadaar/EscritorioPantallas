﻿namespace AplicacionDesktop.MENU
{
    partial class MenuAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminu = new System.Windows.Forms.Button();
            this.btnAdminR = new System.Windows.Forms.Button();
            this.btnAdminP = new System.Windows.Forms.Button();
            this.btnAdminm = new System.Windows.Forms.Button();
            this.btnCerrarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // btnAdminu
            // 
            this.btnAdminu.Location = new System.Drawing.Point(89, 116);
            this.btnAdminu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminu.Name = "btnAdminu";
            this.btnAdminu.Size = new System.Drawing.Size(144, 61);
            this.btnAdminu.TabIndex = 1;
            this.btnAdminu.Text = "Administrar Usuarios";
            this.btnAdminu.UseVisualStyleBackColor = true;
            // 
            // btnAdminR
            // 
            this.btnAdminR.Location = new System.Drawing.Point(366, 116);
            this.btnAdminR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminR.Name = "btnAdminR";
            this.btnAdminR.Size = new System.Drawing.Size(150, 61);
            this.btnAdminR.TabIndex = 2;
            this.btnAdminR.Text = "Administrar Residentes";
            this.btnAdminR.UseVisualStyleBackColor = true;
            // 
            // btnAdminP
            // 
            this.btnAdminP.Location = new System.Drawing.Point(366, 236);
            this.btnAdminP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminP.Name = "btnAdminP";
            this.btnAdminP.Size = new System.Drawing.Size(150, 61);
            this.btnAdminP.TabIndex = 3;
            this.btnAdminP.Text = "Administrar Personal";
            this.btnAdminP.UseVisualStyleBackColor = true;
            // 
            // btnAdminm
            // 
            this.btnAdminm.Location = new System.Drawing.Point(89, 236);
            this.btnAdminm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminm.Name = "btnAdminm";
            this.btnAdminm.Size = new System.Drawing.Size(144, 61);
            this.btnAdminm.TabIndex = 4;
            this.btnAdminm.Text = "Administrar Medicamentos";
            this.btnAdminm.UseVisualStyleBackColor = true;
            // 
            // btnCerrarAdmin
            // 
            this.btnCerrarAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarAdmin.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAdmin.Location = new System.Drawing.Point(555, 432);
            this.btnCerrarAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarAdmin.Name = "btnCerrarAdmin";
            this.btnCerrarAdmin.Size = new System.Drawing.Size(112, 27);
            this.btnCerrarAdmin.TabIndex = 5;
            this.btnCerrarAdmin.Text = "Cerrar Sesion";
            this.btnCerrarAdmin.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(680, 473);
            this.Controls.Add(this.btnCerrarAdmin);
            this.Controls.Add(this.btnAdminm);
            this.Controls.Add(this.btnAdminP);
            this.Controls.Add(this.btnAdminR);
            this.Controls.Add(this.btnAdminu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminu;
        private System.Windows.Forms.Button btnAdminR;
        private System.Windows.Forms.Button btnAdminP;
        private System.Windows.Forms.Button btnAdminm;
        private System.Windows.Forms.Button btnCerrarAdmin;
    }
}