﻿namespace AplicacionDesktop.MENU
{
    partial class MenuAdminResidentes
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
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnListarU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(472, 109);
            this.btnEliminarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarU.TabIndex = 10;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            // 
            // btnModificarU
            // 
            this.btnModificarU.Location = new System.Drawing.Point(334, 109);
            this.btnModificarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(126, 37);
            this.btnModificarU.TabIndex = 9;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            // 
            // btnListarU
            // 
            this.btnListarU.Location = new System.Drawing.Point(185, 109);
            this.btnListarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnListarU.Name = "btnListarU";
            this.btnListarU.Size = new System.Drawing.Size(126, 37);
            this.btnListarU.TabIndex = 8;
            this.btnListarU.Text = "Listar";
            this.btnListarU.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrar Ficha de Residentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuAdminResidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnModificarU);
            this.Controls.Add(this.btnListarU);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuAdminResidentes";
            this.Text = "MenuAdminResidentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnListarU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}