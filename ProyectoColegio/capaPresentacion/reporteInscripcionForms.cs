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
    public partial class reporteInscripcionForms : Form
    {
        gestionReportes gestionReportes = new gestionReportes();
        public reporteInscripcionForms()
        {
            InitializeComponent();
        }

        private void reporteInscripcionForms_Load(object sender, EventArgs e)
        {
            fechaReporteDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaReporteDateTimePicker.CustomFormat = "MMMM yyyy";
            fechaReporteDateTimePicker.ShowUpDown = true;

        }

        private void generarReporteButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = fechaReporteDateTimePicker.Value;
            int mes = fecha.Month;
            int anio = fecha.Year;

            reporteDataGridView.DataSource = gestionReportes.ObtenerInscripcionesPorFecha(mes, anio);
        }

        private void guardarPDFButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;
                    ExportarDataGridViewAPDF(reporteDataGridView, ruta);
                }
            }
        }
        private void ExportarDataGridViewAPDF(DataGridView dgv, string ruta)
        {
            iTextSharp.text.Document documento = new iTextSharp.text.Document();
            iTextSharp.text.pdf.PdfWriter.GetInstance(documento, new FileStream(ruta, FileMode.Create));
            documento.Open();
            iTextSharp.text.pdf.PdfPTable tabla = new iTextSharp.text.pdf.PdfPTable(dgv.Columns.Count);

            // Añadir encabezados
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                tabla.AddCell(new iTextSharp.text.Phrase(columna.HeaderText));
            }

            // Añadir filas
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null)
                    {
                        tabla.AddCell(new iTextSharp.text.Phrase(celda.Value.ToString()));
                    }
                }
            }

            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte guardado en PDF con éxito.");
        }

        private void imprimirReporteButton_Click(object sender, EventArgs e)
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
            Bitmap bm = new Bitmap(reporteDataGridView.Width, reporteDataGridView.Height);
            reporteDataGridView.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, reporteDataGridView.Width, reporteDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
