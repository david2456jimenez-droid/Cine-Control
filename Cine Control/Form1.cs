using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cine_Control
{
    public partial class Form1 : Form
    {
        int cantidad = 0;
        int total = 0;
        int numeroFactura = 0;

        Color colorDisponible = Color.Lime;
        Color colorSeleccionado = Color.Blue;

        public Form1()
        {
            InitializeComponent();

            this.listBox1 = new System.Windows.Forms.ListBox();

            // lleno los combobox de peliculas y funciones
            cmbPelicula.Items.Clear();
            cmbFuncion.Items.Clear();
            cmbPelicula.Items.Add("Intensamente 2");
            cmbPelicula.Items.Add("Deadpool y Wolverine");
            cmbPelicula.Items.Add("Moana 2");
            cmbFuncion.Items.Add("3:00 p. m.");
            cmbFuncion.Items.Add("5:30 p. m.");
            cmbFuncion.Items.Add("7:30 p. m.");

            // se deja la primera opcion seleccionada
            cmbPelicula.SelectedIndex = 0;
            cmbFuncion.SelectedIndex = 0;

            ActualizarResumen(); // Al abrir, el contador esta en cero
        }

        int ObtenerPrecio(string asiento)
        {
            string fila = asiento.Substring(0, 1);

            if (fila == "A" || fila == "B")
            {
                return 12000;
            }
            else
            {
                return 18000;
            }
        }

        string ObtenerTipo(string asiento)
        {
            string fila = asiento.Substring(0, 1);

            if (fila == "A" || fila == "B")
            {
                return "General";
            }
            else
            {
                return "Preferencial";
            }
        }

        string FormatoPeso(int valor)
        {
            return "$" + valor.ToString("N0");
        }

        void ActualizarResumen()
        {
            lblCantidad.Text = "Asientos: " + cantidad;
            lblTotal.Text = "Total: " + FormatoPeso(total);
        }

        // Este método lo usan los 20 asientos
        private void btnA1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            int precio = ObtenerPrecio(boton.Text);

            if (boton.BackColor == colorSeleccionado)
            {
                // estaba seleccionado: lo desmarcamos
                boton.BackColor = colorDisponible;
                listBox1.Items.Remove(boton.Text);
                cantidad = cantidad - 1;
                total = total - precio;
            }
            else
            {
                // estaba disponible: lo seleccionamos
                boton.BackColor = colorSeleccionado;
                listBox1.Items.Add(boton.Text);
                cantidad = cantidad + 1;
                total = total + precio;
            }

            ActualizarResumen();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // asientos que estan directamente en el formulario
                if (control is Button && control.BackColor == colorSeleccionado)
                {
                    control.BackColor = colorDisponible;
                }

                // asientos que estan dentro de un panel o grupo
                foreach (Control hijo in control.Controls)
                {
                    if (hijo is Button && hijo.BackColor == colorSeleccionado)
                    {
                        hijo.BackColor = colorDisponible;
                    }
                }
            }

            listBox1.Items.Clear(); // se vacia la lista de los asientos
            cantidad = 0;
            total = 0;
            ActualizarResumen();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Escribe el nombre del cliente");
                return;
            }

            if (cantidad == 0)
            {
                MessageBox.Show("Selecciona al menos un asiento");
                return;
            }

            numeroFactura = numeroFactura + 1;

            int cantGeneral = 0;
            int cantPreferencial = 0;
            string detalle = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string asiento = listBox1.Items[i].ToString();

                detalle = detalle + asiento + " - " + ObtenerTipo(asiento) + " - " + FormatoPeso(ObtenerPrecio(asiento)) + Environment.NewLine;

                if (ObtenerTipo(asiento) == "General")
                {
                    cantGeneral++;
                }
                else
                {
                    cantPreferencial++;
                }
            }

            // Armamos el texto completo de la factura.
            string factura = "CINE CONTROL - FACTURA" + Environment.NewLine
                + "Factura N°: " + numeroFactura + Environment.NewLine
                + "Fecha y hora: " + DateTime.Now + Environment.NewLine
                + "Cliente: " + txtCliente.Text + Environment.NewLine
                + "Pelicula: " + cmbPelicula.Text + Environment.NewLine
                + "Funcion: " + cmbFuncion.Text + Environment.NewLine
                + Environment.NewLine
                + "Asientos (precio unitario):" + Environment.NewLine
                + detalle
                + Environment.NewLine
                + "Subtotal General (" + cantGeneral + " x $12.000): "
                + FormatoPeso(cantGeneral * 12000) + Environment.NewLine
                + "Subtotal Preferencial (" + cantPreferencial + " x $18.000): "
                + FormatoPeso(cantPreferencial * 18000) + Environment.NewLine
                + Environment.NewLine
                + "TOTAL A PAGAR: " + FormatoPeso(total) + " COP";

            // Mostramos la factura en el área de texto.
            rtbFactura.Text = factura;
        }

    }
}
