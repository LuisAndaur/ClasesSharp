using CoreClinica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIClinica
{
    public partial class Form1 : Form
    {

        Task tareaMostrarMensaje;
        Task tareaMostrarMensaje2;
        Task tareaMostrarMensaje3;

        public void EjemploRun()
        {

            Task.Run(() => MessageBox.Show("Hola mundo"));

        }


        public void EjemploStart()
        {
            MessageBox.Show("TAREA START");
            Thread.Sleep(1000);
        }

        public Form1()  // main thread
        {
            InitializeComponent();
            tareaMostrarMensaje = new Task(EjemploStart);

        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            this.lb_doctores.Text = "Cargando lista de doctores...";
            this.dtgv_doctores.Visible = false;

           await Task.Run(() =>
                               {

                                   Hospital.Doctores = JsonSerializer.Deserialize<List<Doctor>>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Doctores.json"));

                                   Thread.Sleep(10000);
                                   if (this.dtgv_doctores.InvokeRequired) // DA TRUE CUANDO NO ES DEL HILO PRINCIPAL 
                                   {
                                       this.dtgv_doctores.BeginInvoke((MethodInvoker)delegate ()
                                       {
                                           this.lb_doctores.Text = "Doctores";
                                           dtgv_doctores.DataSource = null;
                                           dtgv_doctores.DataSource = Hospital.Doctores;
                                           dtgv_doctores.Visible = true;
                                       });

                                   }

                               });

            #region codigo para crear doctores hardcodeados 
            //List<Doctor> doctores = new List<Doctor>();

            //doctores.Add(new Doctor(1, "Pepe"));
            //doctores.Add(new Doctor(2, "Romeo"));
            //doctores.Add(new Doctor(3, "Carola"));
            //doctores.Add(new Doctor(4, "Jazmin"));
            //doctores.Add(new Doctor(5, "Juana"));
            //doctores.Add(new Doctor(6, "Carmela"));
            //doctores.Add(new Doctor(7, "Avril"));
            //doctores.Add(new Doctor(8, "Morena"));
            //doctores.Add(new Doctor(9, "Benji"));



            //string nombreArchivo = AppDomain.CurrentDomain.BaseDirectory + "Doctores.json";
            //JsonSerializerOptions opciones = new JsonSerializerOptions();
            //opciones.WriteIndented = true;
            //File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(doctores, opciones));
            #endregion

        }

        private void ActualizarDatagrid(CancellationToken cts)
        {
            while (true)
            {
                if (cts.IsCancellationRequested) // FALSE   -> .CANCEL() == TRUE 
                    return;

                else if (this.dataGridView1.InvokeRequired) // DA TRUE CUANDO NO ES DEL HILO PRINCIPAL 
                {
                    this.dataGridView1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ConexionDB.TraerPacientes().ToList();
                    });

                    Thread.Sleep(2000);
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ConexionDB.TraerPacientes().ToList();
                }
            }
        }

        private void btn_noatender_Click(object sender, EventArgs e)
        {
            Hospital.Cts.Cancel();
            btn_Atender.Enabled = true;
        }

        private void btn_Atender_Click(object sender, EventArgs e)
        { 
            Task.Run(() => ActualizarDatagrid(Hospital.Cts.Token));
            btn_Atender.Enabled = false;

        }

        private void btnPacienteHardcodeado_Click(object sender, EventArgs e)
        {
            Paciente aux = Hardcodeo.SimularCargaPaciente();
            if (aux != null)
                Hospital.PacientesNuevos.Add(aux);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tareaMostrarMensaje.Start();

            tareaMostrarMensaje.Wait();

            MessageBox.Show("QUE BUEN MENSAJE");

        }
    }
}
