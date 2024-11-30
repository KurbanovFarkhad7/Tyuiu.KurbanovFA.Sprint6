using Tyuiu.KurbanovFA.Sprint6.Task1.V5.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_KFA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartStep_KFA.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_KFA.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            textBoxResult_KFA.Text = "";
            textBoxResult_KFA.AppendText("+---------+----------+" + Environment.NewLine); // переход на новую строку
            textBoxResult_KFA.AppendText("+    X    +    Y     +" + Environment.NewLine);
            textBoxResult_KFA.AppendText("+---------+----------+" + Environment.NewLine);

            string strLine;
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5:d}   |  {1, 5:f2}   | ", startStep, valueArray[i]);
                textBoxResult_KFA.AppendText (strLine + Environment.NewLine);
                startStep++;
            }

            textBoxResult_KFA.AppendText("+---------+----------+" + Environment.NewLine);
        }
    }
}
