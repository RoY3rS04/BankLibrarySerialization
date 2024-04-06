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

namespace ReadClientFile
{
    public partial class ReadClientFileForm : BankUIForm
    {
        private FileRepository? _repository;

        public ReadClientFileForm()
        {
            InitializeComponent();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result != DialogResult.OK)
            {
                return;
            }

            if (String.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid filename!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _repository = new FileRepository(fileName);
                _repository.OpenOrCreateFile();
                fileBtn.Enabled = false;

                StreamReader? reader = _repository.GetReader();
                ISerializer serializer;

                if (reader == null)
                {
                    return;
                }

                serializer = reader.ReadLine().Contains("xml")
                    ? new XmlObjSerializer()
                    : new JsonSerializer();

                Record? record = serializer.Deserialize<Record>(_repository);

                if (record != null)
                {
                    string[] data = [
                        record.Account.ToString(),
                        record.FirstName,
                        record.LastName,
                        record.Balance.ToString()
                    ];

                    setTextValues(data);
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _repository?.CloseFile();
            }catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }
    }
}
