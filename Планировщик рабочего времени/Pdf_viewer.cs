using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планировщик_рабочего_времени
{
    public partial class Pdf_viewer : Form
    {
        public Pdf_viewer()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile(txtFilePath.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile(string filePath)
        {
            using(Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(filePath).Extension;

                string query = "INSERT INTO CTP_main(doc_file, Name_number, Designation_doc, date_affirmation, review, date_review)VALUES(@doc_file, @Name_number, @Designation_doc, @date_affirmation, @review, @date_review)";

                

                using (SqlConnection cn = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@doc_file", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@Name_number", SqlDbType.NVarChar).Value = namenumberDataGridViewTextBoxColumn;
                    cmd.Parameters.Add("@Designation_doc", SqlDbType.NVarChar).Value = designationdocDataGridViewTextBoxColumn;
                    cmd.Parameters.Add("@date_affirmation", SqlDbType.Date).Value = dateaffirmationDataGridViewTextBoxColumn;
                    cmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = reviewDataGridViewTextBoxColumn;
                    cmd.Parameters.Add("@date_review", SqlDbType.Date).Value = datereviewDataGridViewTextBoxColumn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=HOME-PC;Initial Catalog=WorkTime;Integrated Security=True");
        }

        private void Pdf_viewer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cTP_main_dt.CTP_main". При необходимости она может быть перемещена или удалена.
            this.cTP_mainTableAdapter.Fill(this.cTP_main_dt.CTP_main);

        }
    }
}
