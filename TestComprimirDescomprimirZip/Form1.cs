using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestComprimirDescomprimirZip
{

    public partial class Form1 : Form
    {


        private GestionFTP _controlador;


        public Form1()
        {
            InitializeComponent();
        }


        private void BT_BAJAR_BOLETIN_Click(object sender, EventArgs e)
        {
            BajarBoletin();
        }

        private void BajarBoletin()
        {
            _controlador.BajarBoletin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L_DEBUG.Text = "";
            BT_ENVIAR_BOLETIN.Enabled = _controlador.IsMaster;
            BT_BAJAR_CIERRE.Enabled = _controlador.IsMaster;

            BT_BAJAR_BOLETIN.Enabled = !_controlador.IsMaster;
            BT_SUBIR_CIERRE.Enabled = !_controlador.IsMaster;
            L_VERSION.Text = "Ver. " + Application.ProductVersion;
        }

        private void BT_SUBIR_CIERRE_Click(object sender, EventArgs e)
        {
            SubirCierreAlFtp();
        }

        private void SubirCierreAlFtp()
        {
            _controlador.SubirCierreAlFtp();
        }

        private void BT_ENVIAR_BOLETIN_Click(object sender, EventArgs e)
        {
            EnviarBoletin();
        }

        private void EnviarBoletin()
        {
            _controlador.EnviarBoletin();
        }

        private void BT_BAJAR_CIERRE_Click(object sender, EventArgs e)
        {
            BajarCierres();
        }

        private void BajarCierres()
        {
            _controlador.BajarCierres();
        }

        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            Salida();
        }

        private void Salida()
        {
            this.Close();
        }

        public void setControlador(GestionFTP ctr)
        {
            _controlador = ctr;
        }

        public void MuestraMensaje(string msg)
        {
            L_DEBUG.Text = msg ;
            this.Refresh();
        }

    }

}