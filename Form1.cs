using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab4Var1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseInputFileButton_Click(object sender, System.EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePathTextbox.Text = openFileDialog.FileName;
                runButton.Enabled = true;
            }
        }

        private void runButton_Click(object sender, System.EventArgs e)
        {
            string inputFileContents;
            using (var streamReader = new StreamReader(inputFilePathTextbox.Text))
            {
                inputFileContents = streamReader.ReadToEnd();
            }

            using var streamWriter = new StreamWriter(inputFilePathTextbox.Text + ".out");
            streamWriter.Write(inputFileContents.Split(", ").GroupBy(character => character).Max(grouping => grouping.Count()));

            MessageBox.Show("Success");
        }
    }
}
