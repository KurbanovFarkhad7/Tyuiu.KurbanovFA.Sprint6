using Tyuiu.KurbanovFA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task2.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_KFA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartStep_KFA.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_KFA.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewResult_KFA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                startStep++;
            }
        }
    }
}
