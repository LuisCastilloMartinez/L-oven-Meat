using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace L_oven_Meat
{
    public partial class Principal : Form
    {
        Login_code reservacion;
        public Principal()
        {
            InitializeComponent();
            reservacion = new Login_code();
            InitializeComponent();
            for (int i = 0; i < reservacion.mesasDisponibles.Length; i++)
            {
                reservacion.mesasDisponibles[i] = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Reservacion 
            reservacion.NomC = txtNombreCliente.Text;
            reservacion.NumT = txtNumTel.Text;
            reservacion.Correo = txtCorreo.Text;
            reservacion.hora = cbhora.Text;
            switch (reservacion.hora)
            {
                case "4:00 p.m":

                    break;
                case "4:30 p.m":
                    break;
                case "5:00 p.m":

                    break;
                case "5:30 p.m":

                    break;
                case "6:00 p.m":

                    break;
                case "6:30 p.m":

                    break;
                case "7:00 p.m":

                    break;
                case "7:30 p.m":

                    break;
                case "8:00 p.m":

                    break;
                case "8:30 p.m":

                    break;
                case "9:00 p.m":

                    break;
                case "9:30 p.m":

                    break;
                case "10:00 p.m":

                    break;
                case "10:30 p.m":

                    break;

            }
            reservacion1();
        }

        private void ttransaccion_Tick(object sender, EventArgs e)
        {
            //Timer para la trasnsaccion


            Random codigo = new Random();
            Timer timer = (Timer)sender; // Obtén el temporizador que desencadenó el evento
            timer.Stop(); // Detén el temporizador
            MessageBox.Show("Transaccion exitosa " +
                "\nTu codigo de verificacion es:" + codigo.Next(12345, 23456)
                + "\nEste codigo te servirá a la hora de llegar al restaurant"
                , "Pago realizado");
            listBox1.Items.Clear();
            txtCorreo.Text = "";
            txtNombreCliente.Text = "";
            txtNumTel.Text = "";
            cbhora.Text = "";
        }
        private void contador()
        {
            Timer timer = new Timer();
            timer.Interval = 5050; // Establece el intervalo del temporizador en milisegundos (5 segundos)
            timer.Tick += ttransaccion_Tick; // Asigna el controlador de eventos Tick al temporizador
            timer.Start(); // Inicia el temporizador

        }
        private void Pago()
        {
            
            
           reservacion. MESA[0] = 800;
           reservacion. MESA[1] = 1000;
           reservacion. MESA[2] = 1200;
           reservacion. MESA[3] = 1400;

            string nip;



            int cobroazar = reservacion.PagoMesa.Next(reservacion.MESA.Length);
            string pagoazar = reservacion.MESA[cobroazar].ToString();
            MessageBox.Show("Tu total es:" + " " +pagoazar // Genera un índice aleatorio entre la longitud del arreglo 'mesa'
, "COBRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            do
            {
                reservacion.claveB = Interaction.InputBox("Ingresa tu numero de tarjeta");

                if (reservacion.claveB.Length != 16)
                {
                    MessageBox.Show("El número de tarjeta debe tener 16 dígitos. Por favor, inténtalo de nuevo.", "Error Num.Tarjeta");
                }

            } while (reservacion.claveB.Length != 16);

            do
            {

                MaskedTextBox NIP = new MaskedTextBox();

                nip = (Interaction.InputBox("Ingresa tu NIP", "COBRO"));
                if (nip.Length != 4)
                {
                    MessageBox.Show("NIP  invalido.Revisa tu NIP e inenta de nuevo", "ERROR");

                }
            } while (nip.Length != 4);
            contador();
        }
     

        private void reservacion1()
        {


            listBox1.Items.Add("Para confirmar la realizacion de tu rerservacion, revisa que los datos sean correctos");
            listBox1.Items.Add("Nombre:" + reservacion.NomC);
            listBox1.Items.Add("Numero de telefono " + reservacion.NumT);
            listBox1.Items.Add("Correo electronico" + reservacion.Correo);

            azar();
            Pago();
        }
        private void azar()
        {
            Random rnd = new Random();
            int mesaSeleccionada;

            do
            {
                mesaSeleccionada = rnd.Next(1, 21); // Generar número aleatorio entre 1 y 20

                // Verificar si la mesa está disponible
                if (reservacion.mesasDisponibles[mesaSeleccionada - 1]) // Restamos 1 para ajustar el índice del array
                {
                    listBox1.Items.Add($"¡La mesa {mesaSeleccionada} está disponible!");
                    // Marcar la mesa como no disponible
                    reservacion.mesasDisponibles[mesaSeleccionada - 1] = false;
                    break; // Salir del bucle una vez que se encuentra una mesa disponible
                }
            } while (true);

        }

        private void btpedidoadomicilio_Click(object sender, EventArgs e)
        {
            //Pedio a domicilio

        }
    }
}
