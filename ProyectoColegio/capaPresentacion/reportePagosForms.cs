using iTextSharp.text.pdf;
using iTextSharp.text;
using ProyectoColegio.capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ProyectoColegio.capaPresentacion
{
    public partial class reportePagosForms : Form
    {
        gestionReportes gestionReportes = new gestionReportes();
        public reportePagosForms()
        {
            InitializeComponent();
        }

        private void reportePagosForms_Load(object sender, EventArgs e)
        {
            estadoPagoComboBox.Items.Add("Pagado");
            estadoPagoComboBox.Items.Add("No Pagado");
            estadoPagoComboBox.SelectedIndex = 0;

            tipoReporteComboBox.Items.Add("Por Mes");
            tipoReporteComboBox.Items.Add("Por Año");
            tipoReporteComboBox.SelectedIndex = 0;

            fechaPagoDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaPagoDateTimePicker.CustomFormat = "MMMM yyyy";
            fechaPagoDateTimePicker.ShowUpDown = true;
        }

        private void generarReportePagosButton_Click(object sender, EventArgs e)
        {
            bool pagado = estadoPagoComboBox.SelectedItem.ToString() == "Pagado";
            DateTime fecha = fechaPagoDateTimePicker.Value;
            string tipoReporte = tipoReporteComboBox.SelectedItem.ToString();

            if (tipoReporte == "Por Mes")
            {
                int mes = fecha.Month;
                int anio = fecha.Year;
                reportePagosDataGridView.DataSource = gestionReportes.ObtenerPagosPorFecha(mes, anio, pagado);
            }
            else if (tipoReporte == "Por Año")
            {
                int anio = fecha.Year;
                reportePagosDataGridView.DataSource = gestionReportes.ObtenerPagosPorAnio(anio, pagado);
            }

        }

        private void guardarReportePagosPDFButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;
                    ExportarDataGridViewAPDF(reportePagosDataGridView, ruta);
                }
            }
        }

        private void ExportarDataGridViewAPDF(DataGridView dgv, string ruta)
        {
            Document documento = new Document();
            PdfWriter.GetInstance(documento, new FileStream(ruta, FileMode.Create));
            documento.Open();
            PdfPTable tabla = new PdfPTable(dgv.Columns.Count);

            // Añadir encabezados
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                tabla.AddCell(new Phrase(columna.HeaderText));
            }

            // Añadir filas
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null)
                    {
                        tabla.AddCell(new Phrase(celda.Value.ToString()));
                    }
                }
            }

            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte guardado en PDF con éxito.");
        }


        private void imprimirReportePagosButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(reportePagosDataGridView.Width, reportePagosDataGridView.Height);
            reportePagosDataGridView.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, reportePagosDataGridView.Width, reportePagosDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }


    }
}
