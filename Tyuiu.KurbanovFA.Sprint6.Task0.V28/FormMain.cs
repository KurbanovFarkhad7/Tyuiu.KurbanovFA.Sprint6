using Tyuiu.KurbanovFA.Sprint6.Task0.V28.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        

        private void textBoxResult_KFA_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            textBoxResult_KFA.Text = Convert.ToString(ds.Calculate(x));
        }
    }
}
