
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numNivelFuerza = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.chkEsAyudante.AutoEllipsis = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(166, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.numNivelFuerza.Name = "numNivelFuerza";
            this.numNivelFuerza.Size = new System.Drawing.Size(134, 23);
            this.numNivelFuerza.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Telepatía",
            "Velocidad",
            "Fuerza",
            "Volar"});
            this.comboBox1.Location = new System.Drawing.Point(166, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // FrmHeroe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numNivelFuerza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkEsAyudante);
            this.Controls.Add(this.lblEsAyudante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoder);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmHeroe";
            this.Text = "Formulario de Heroe";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numNivelFuerza;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}