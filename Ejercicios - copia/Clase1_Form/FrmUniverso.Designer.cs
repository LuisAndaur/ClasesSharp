
namespace HeroeApp
{
    partial class FrmUniverso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoHeroe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNuevoHeroe
            // 
            this.btnNuevoHeroe.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoHeroe.Location = new System.Drawing.Point(284, 39);
            this.btnNuevoHeroe.Name = "btnNuevoHeroe";
            this.btnNuevoHeroe.Size = new System.Drawing.Size(100, 23);
            this.btnNuevoHeroe.TabIndex = 0;
            this.btnNuevoHeroe.Text = "Nuevo Heroe";
            this.btnNuevoHeroe.UseVisualStyleBackColor = false;
            this.btnNuevoHeroe.Click += new System.EventHandler(this.btnNuevoHeroe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Universo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 95);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoHeroe);
            this.Name = "Form1";
            this.Text = "Universo de Heroes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoHeroe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

