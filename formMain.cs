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

        private void ProcessTypeChanged(object sender, EventArgs e)
        {
            labelPathAndFileName2.Visible = radiobuttonProcessTypeMergeFiles.Checked;
            textboxPathAndFileName2.Visible = radiobuttonProcessTypeMergeFiles.Checked;
            buttonPathAndFileName2.Visible = radiobuttonProcessTypeMergeFiles.Checked;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (!radiobuttonProcessTypePagesOrderInvert.Checked & !radiobuttonProcessTypeMergeFiles.Checked)
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

            if (radiobuttonProcessTypeMergeFiles.Checked)
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

            if (radiobuttonProcessTypePagesOrderInvert.Checked)
            {
                if (ProcessPagesOrderInvert())
                {
                    MessageBox.Show("Process finished succesfully.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            else
            {

            }
        }


        private bool ProcessPagesOrderInvert()
        {
            PdfSharp.Pdf.PdfDocument pdfDocument;

            try
            {
                // Open the PDF file
                pdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(textboxPathAndFileName1.Text.Trim(), PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify);
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, "Error opening PDF file.");
                return false;
            }

            int indexLastPage = pdfDocument.Pages.Count - 1;

            for (int indexCurrent = indexLastPage - 1; indexCurrent >= 0; indexCurrent--)
            {
                pdfDocument.Pages.MovePage(indexCurrent, indexLastPage);
            }

            try
            {
                pdfDocument.Save(textboxPathAndFileName1.Text.Trim());
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, "Error saving PDF file.");
                return false;
            }

            pdfDocument.Close();
            pdfDocument.Dispose();
            pdfDocument = null;

            return true;
        }


        private bool ProcessMergeFiles()
        {
            PdfSharp.Pdf.PdfDocument pdfDocument1;
            PdfSharp.Pdf.PdfDocument pdfDocument2;

            try
            {
                // Open the PDF file - 1
                pdfDocument1 = PdfSharp.Pdf.IO.PdfReader.Open(textboxPathAndFileName1.Text.Trim(), PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify);
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, "Error opening PDF file - 1.");
                return false;
            }

            try
            {
                // Open the PDF file - 2
                pdfDocument2 = PdfSharp.Pdf.IO.PdfReader.Open(textboxPathAndFileName2.Text.Trim(), PdfSharp.Pdf.IO.PdfDocumentOpenMode.ReadOnly);
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, "Error opening PDF file - 2.");
                return false;
            }

            int indexLastPage1 = pdfDocument1.Pages.Count - 1;
            int indexLastPage2 = pdfDocument2.Pages.Count - 1;
            int indexCurrent2 = 0;

            for (int indexInsertationPoint1 = 1; indexInsertationPoint1 <= indexLastPage1; indexInsertationPoint1++ 2)
            {
                if (indexCurrent2 > indexLastPage2)
                {
                    break;
                }

                pdfDocument1.Pages.Insert(indexInsertationPoint1, pdfDocument2.Pages[indexCurrent2]);

                indexCurrent2++;
            }

            for (int indiceActual = 1; indiceActual >= 0; indiceActual--)
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
                return false;
            }

            pdfDocument.Close();
            pdfDocument.Dispose();
            pdfDocument = null;

            return true;
        }

    }
}
