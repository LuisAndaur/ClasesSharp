
namespace HeroeApp
{
    partial class FrmHeroe
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPoder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEsAyudante = new System.Windows.Forms.Label();
            this.chkEsAyudante = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numNivelFuerza = new System.Windows.Forms.NumericUpDown();
            this.cmbPoder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNivelFuerza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPoder
            // 
            this.lblPoder.AutoSize = true;
            this.lblPoder.Location = new System.Drawing.Point(32, 81);
            this.lblPoder.Name = "lblPoder";
            this.lblPoder.Size = new System.Drawing.Size(38, 15);
            this.lblPoder.TabIndex = 1;
            this.lblPoder.Text = "Poder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel de fuerza";
            // 
            // lblEsAyudante
            // 
            this.lblEsAyudante.AutoSize = true;
            this.lblEsAyudante.Location = new System.Drawing.Point(32, 153);
            this.lblEsAyudante.Name = "lblEsAyudante";
            this.lblEsAyudante.Size = new System.Drawing.Size(70, 15);
            this.lblEsAyudante.TabIndex = 3;
            this.lblEsAyudante.Text = "Es ayudante";
            // 
            // chkEsAyudante
            // 
            this.chkEsAyudante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEsAyudante.AutoSize = true;
            this.chkEsAyudante.Checked = true;
            this.chkEsAyudante.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEsAyudante.Location = new System.Drawing.Point(166, 153);
            this.chkEsAyudante.Name = "chkEsAyudante";
            this.chkEsAyudante.Size = new System.Drawing.Size(89, 19);
            this.chkEsAyudante.TabIndex = 4;
            this.chkEsAyudante.Text = "True or false";
            this.chkEsAyudante.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(166, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(166, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // numNivelFuerza
            // 
            this.numNivelFuerza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNivelFuerza.Location = new System.Drawing.Point(166, 116);
            this.numNivelFuerza.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numNivelFuerza.Name = "numNivelFuerza";
            this.numNivelFuerza.Size = new System.Drawing.Size(134, 23);
            this.numNivelFuerza.TabIndex = 7;
            // 
            // cmbPoder
            // 
            this.cmbPoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPoder.FormattingEnabled = true;
            this.cmbPoder.Items.AddRange(new object[] {
            "Telepatía",
            "Velocidad",
            "Fuerza",
            "Volar"});
            this.cmbPoder.Location = new System.Drawing.Point(166, 78);
            this.cmbPoder.Name = "cmbPoder";
            this.cmbPoder.Size = new System.Drawing.Size(134, 23);
            this.cmbPoder.TabIndex = 8;
            // 
            // FrmHeroe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.cmbPoder);
            this.Controls.Add(this.numNivelFuerza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkEsAyudante);
            this.Controls.Add(this.lblEsAyudante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoder);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmHeroe";
            this.Text = "Formulario de Heroe";
            this.Activated += new System.EventHandler(this.FrmHeroe_Activated);
            this.Load += new System.EventHandler(this.FrmHeroe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNivelFuerza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPoder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEsAyudante;
        private System.Windows.Forms.CheckBox chkEsAyudante;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numNivelFuerza;
        private System.Windows.Forms.ComboBox cmbPoder;
    }
}