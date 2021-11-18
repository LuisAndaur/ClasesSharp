
namespace UIClinica
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_noatender = new System.Windows.Forms.Button();
            this.btn_Atender = new System.Windows.Forms.Button();
            this.btnPacienteHardcodeado = new System.Windows.Forms.Button();
            this.dtgv_doctores = new System.Windows.Forms.DataGridView();
            this.lb_pacientes = new System.Windows.Forms.Label();
            this.lb_doctores = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_doctores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(517, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_noatender
            // 
            this.btn_noatender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noatender.Location = new System.Drawing.Point(583, 356);
            this.btn_noatender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_noatender.Name = "btn_noatender";
            this.btn_noatender.Size = new System.Drawing.Size(137, 87);
            this.btn_noatender.TabIndex = 1;
            this.btn_noatender.Text = "Dejar de atender";
            this.btn_noatender.UseVisualStyleBackColor = false;
            this.btn_noatender.Click += new System.EventHandler(this.btn_noatender_Click);
            // 
            // btn_Atender
            // 
            this.btn_Atender.BackColor = System.Drawing.Color.Lime;
            this.btn_Atender.Location = new System.Drawing.Point(583, 236);
            this.btn_Atender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Atender.Name = "btn_Atender";
            this.btn_Atender.Size = new System.Drawing.Size(137, 76);
            this.btn_Atender.TabIndex = 2;
            this.btn_Atender.Text = "Atender pacientes";
            this.btn_Atender.UseVisualStyleBackColor = false;
            this.btn_Atender.Click += new System.EventHandler(this.btn_Atender_Click);
            // 
            // btnPacienteHardcodeado
            // 
            this.btnPacienteHardcodeado.BackColor = System.Drawing.Color.Yellow;
            this.btnPacienteHardcodeado.Location = new System.Drawing.Point(583, 501);
            this.btnPacienteHardcodeado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPacienteHardcodeado.Name = "btnPacienteHardcodeado";
            this.btnPacienteHardcodeado.Size = new System.Drawing.Size(137, 105);
            this.btnPacienteHardcodeado.TabIndex = 3;
            this.btnPacienteHardcodeado.Text = "Agregar Paciente Hardcodeado";
            this.btnPacienteHardcodeado.UseVisualStyleBackColor = false;
            this.btnPacienteHardcodeado.Click += new System.EventHandler(this.btnPacienteHardcodeado_Click);
            // 
            // dtgv_doctores
            // 
            this.dtgv_doctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_doctores.Location = new System.Drawing.Point(840, 166);
            this.dtgv_doctores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_doctores.Name = "dtgv_doctores";
            this.dtgv_doctores.RowHeadersWidth = 51;
            this.dtgv_doctores.RowTemplate.Height = 25;
            this.dtgv_doctores.Size = new System.Drawing.Size(498, 552);
            this.dtgv_doctores.TabIndex = 4;
            // 
            // lb_pacientes
            // 
            this.lb_pacientes.AutoSize = true;
            this.lb_pacientes.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pacientes.Location = new System.Drawing.Point(160, 59);
            this.lb_pacientes.Name = "lb_pacientes";
            this.lb_pacientes.Size = new System.Drawing.Size(221, 62);
            this.lb_pacientes.TabIndex = 5;
            this.lb_pacientes.Text = "Pacientes";
            // 
            // lb_doctores
            // 
            this.lb_doctores.AutoSize = true;
            this.lb_doctores.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_doctores.Location = new System.Drawing.Point(942, 77);
            this.lb_doctores.Name = "lb_doctores";
            this.lb_doctores.Size = new System.Drawing.Size(215, 62);
            this.lb_doctores.TabIndex = 6;
            this.lb_doctores.Text = "Doctores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_doctores);
            this.Controls.Add(this.lb_pacientes);
            this.Controls.Add(this.dtgv_doctores);
            this.Controls.Add(this.btn_Atender);
            this.Controls.Add(this.btnPacienteHardcodeado);
            this.Controls.Add(this.btn_noatender);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_doctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_noatender;
        private System.Windows.Forms.Button btn_Atender;
        private System.Windows.Forms.Button btnPacienteHardcodeado;
        private System.Windows.Forms.DataGridView dtgv_doctores;
        private System.Windows.Forms.Label lb_pacientes;
        private System.Windows.Forms.Label lb_doctores;
        private System.Windows.Forms.Button button1;
    }
}

