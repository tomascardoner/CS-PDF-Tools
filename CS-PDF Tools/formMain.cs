using System;
using System.Windows.Forms;

namespace CS_PDF_Tools
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonPathAndFileName1_Click(object sender, EventArgs e)
        {
            openfiledialogPDFFile.FileName = textboxPathAndFileName1.Text;
            if (openfiledialogPDFFile.ShowDialog(this) == DialogResult.OK)
            {
                textboxPathAndFileName1.Text = openfiledialogPDFFile.FileName;
            }
        }

        private void buttonPathAndFileName2_Click(object sender, EventArgs e)
        {
            openfiledialogPDFFile.FileName = textboxPathAndFileName2.Text;
            if (openfiledialogPDFFile.ShowDialog(this) == DialogResult.OK)
            {
                textboxPathAndFileName2.Text = openfiledialogPDFFile.FileName;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (!radiobuttonPagesOrderInvert.Checked & !radiobuttonMergeFiles.Checked)
            {
                MessageBox.Show("You must specify the Process type.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textboxPathAndFileName1.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must specify the PDF file - 1.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (System.IO.File.Exists(textboxPathAndFileName1.Text.Trim()) == false)
            {
                MessageBox.Show("The PDF file - 1 specified doesn't exists.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (radiobuttonMergeFiles.Checked)
            {
                if (textboxPathAndFileName2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You must specify the PDF file - 2.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (System.IO.File.Exists(textboxPathAndFileName1.Text.Trim()) == false)
                {
                    MessageBox.Show("The PDF file - 2 specified doesn't exists.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            PdfSharp.Pdf.PdfDocument pdfDocument;

            if (checkboxPDFFileBackup.Checked)
            {
                try
                {
                    // Backup the PDF file
                    string backupFilePrefix = "._bak_" + DateTime.Now.ToString("yyyymmddHHMM");

                    System.IO.File.Copy(textboxPathAndFileName1.Text.Trim(), textboxPathAndFileName1.Text.Trim() + backupFilePrefix);
                }
                catch (Exception ex)
                {
                    CardonerSistemas.Error.ProcessError(ref ex, "Error backing up the PDF file.");
                    return;
                }
            }

            try
            {
                // Open the PDF file
                pdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(textboxPathAndFileName1.Text.Trim(), PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify);
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, "Error opening PDF file.");
                return;
            }

            if (radiobuttonPagesOrderInvert.Checked)
            {
                int indiceUltimaPagina = pdfDocument.Pages.Count - 1;

                for (int indiceActual = indiceUltimaPagina - 1; indiceActual >= 0; indiceActual--)
                {
                    pdfDocument.Pages.MovePage(indiceActual, indiceUltimaPagina);
                }

                try
                {
                    pdfDocument.Save(textboxPathAndFileName1.Text.Trim());
                }
                catch (Exception ex)
                {
                    CardonerSistemas.Error.ProcessError(ref ex, "Error saving PDF file.");
                    return;
                }

                pdfDocument.Close();
                pdfDocument.Dispose();
                pdfDocument = null;

                MessageBox.Show("Process finished succesfully.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
