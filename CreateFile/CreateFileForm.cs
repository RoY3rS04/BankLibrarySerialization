using BankLibrarySerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFile
{
    public partial class CreateFileForm : BankUIForm
    {

        private FileRepository? _repository;

        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void CreateFileForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();

                fileName = fileChooser.FileName;
            }

            if (result != DialogResult.OK)
            {
                return;
            }

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _repository = new FileRepository(fileName);
                _repository.OpenOrCreateFile();
                
                saveBtn.Enabled = false;
                saveClientBtn.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveClientBtn_Click(object sender, EventArgs e)
        {
            string[] values = getTextBoxValues();

            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.Account]))
            {
                int accountNumber = int.Parse(values[(int)TextBoxIndices.Account]);

                if (accountNumber > 0)
                {
                    Record record = new Record(
                        accountNumber,
                        values[(int)TextBoxIndices.FirstName],
                        values[(int)TextBoxIndices.LastName],
                        decimal.Parse(values[(int)TextBoxIndices.Balance])
                    );

                    ISerializer serializer;

                    if (jsonRadioBtn.Checked)
                    {
                        serializer = new JsonSerializer();
                    }
                    else if (xmlRadioBtn.Checked)
                    {
                        serializer = new XmlObjSerializer();
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Serialization Option", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (_repository != null)
                    {
                        try
                        {
                            serializer.Serialize(record, _repository);
                            MessageBox.Show("Client saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    return;
                }

                clearTextBoxes();
                MessageBox.Show("Invalid Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _repository?.CloseFile();
            } catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }
    }
}
