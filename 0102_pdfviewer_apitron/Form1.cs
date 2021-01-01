using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

//PDF
using Apitron.PDF.Rasterizer;
//PDF

namespace WindowsFormsApplication_PDFViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get the dialog ready
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "(*.pdf)|*.pdf";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                

                try
                {
                    
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Open);
                    pdfViewer1.Document = new Document(fs);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
