using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Net.WebRequestMethods;
using System.IO;
namespace NavegadorWeb1
{
    public partial class Form1 : Form
    {
        private HashSet<string> historial = new HashSet<string>();
        private Dictionary<string, int> contadorVisitas = new Dictionary<string, int>();
        private List<HistorialItem> historialConFecha = new List<HistorialItem>();
        private string nombreArchivo = @"C:\Users\USUARIO\Desktop\Historial.txt";

        public Form1()
        {
            InitializeComponent();
            CargarHistorialDesdeArchivo();
            ActualizarComboBox();
            ActualizarListBoxHistorial();
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            string url = comboBox1.Text.ToString();

            if (string.IsNullOrWhiteSpace(url))
                return;

            if (!url.StartsWith("http"))
                url = "http://" + url;

            webView21.CoreWebView2.Navigate(url);

            
            if (!historial.Contains(url))
            {
                historial.Add(url);
                contadorVisitas[url] = 0;
                historialConFecha.Add(new HistorialItem { Url = url, FechaAcceso = DateTime.Now });
                ActualizarComboBox();
                ActualizarListBoxHistorial();
            }

            contadorVisitas[url]++;
            ActualizarComboBox();

        
            try
            {
                using (FileStream flujo = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write))
                using (StreamWriter guardar = new StreamWriter(flujo))
                {
                    guardar.WriteLine(url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la URL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var url in historial)
            {
                comboBox1.Items.Add(url);
            }
        }

        private void ActualizarListBoxHistorial()
        {
            listBoxHistorial.Items.Clear();
            foreach (var item in historialConFecha.OrderByDescending(item => item.FechaAcceso))
            {
                listBoxHistorial.Items.Add(item.Url + " - " + item.FechaAcceso.ToString());
            }
        }

        private void OrdenarPorVisitas()
        {
            var items = contadorVisitas.OrderByDescending(kv => kv.Value).Select(kv => kv.Key).ToList();
            historial.Clear();
            foreach (var item in items)
            {
                historial.Add(item);
            }
            ActualizarComboBox();
        }

        private void OrdenarPorFechaAcceso()
        {
            historialConFecha = historialConFecha.OrderByDescending(item => item.FechaAcceso).ToList();
            ActualizarListBoxHistorial();
        }

        private void EliminarDelHistorial(string url)
        {
            historial.Remove(url);
            contadorVisitas.Remove(url);
            historialConFecha.RemoveAll(item => item.Url == url);
            ActualizarComboBox();
            ActualizarListBoxHistorial();
        }

        private void CargarHistorialDesdeArchivo()
        {
            try
            {
                if (System.IO.File.Exists(nombreArchivo))
                {
                    using (StreamReader lector = new StreamReader(nombreArchivo))
                    {
                        while (!lector.EndOfStream)
                        {
                            string linea = lector.ReadLine();
                            historial.Add(linea);
                            contadorVisitas[linea] = 0;
                            historialConFecha.Add(new HistorialItem { Url = linea, FechaAcceso = DateTime.Now });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial desde el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string home = "https://www.google.com";
            webView21.CoreWebView2.Navigate(home);
        }

        private void hacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void listBoxHistorial_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxHistorial.SelectedItem != null)
            {
                string[] partes = listBoxHistorial.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                string url = partes[0];
                webView21.CoreWebView2.Navigate(url);
            }
        }

        private void eliminarDelHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxHistorial.SelectedItem != null)
            {
                string[] partes = listBoxHistorial.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                string url = partes[0];
                EliminarDelHistorial(url);
            }
        }

        
        private class HistorialItem
        {
            public string Url { get; set; }
            public DateTime FechaAcceso { get; set; }
        }

        private void buttonOrdenarAscendente_Click(object sender, EventArgs e)
        {
            OrdenarPorVisitas();
        }

        private void buttonOrdenarDescendente_Click(object sender, EventArgs e)
        {
            OrdenarPorFechaAcceso();
        }
    }
}
