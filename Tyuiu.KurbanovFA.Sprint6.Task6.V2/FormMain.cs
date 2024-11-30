using Tyuiu.KurbanovFA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddFile_KFA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonDone_KFA.Enabled = true;
        }

        private void buttonDone_KFA_Click(object sender, EventArgs e)
        {
            /*string str = "**";*/
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
