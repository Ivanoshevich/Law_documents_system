using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;
using System.Drawing.Printing;


namespace Планировщик_рабочего_времени
{
    public partial class CTP_main : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public CTP_main()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
        }

        private void openPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
            pdfDocument.CreatePrintDocument();

        }
    }
}
