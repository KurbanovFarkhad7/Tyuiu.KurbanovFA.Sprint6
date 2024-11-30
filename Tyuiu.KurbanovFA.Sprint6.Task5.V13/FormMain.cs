using Tyuiu.KurbanovFA.Sprint6.Task5.V13.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_KFA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            double[] matrix = new double[20];
            string path = @"C:\Users\Cruise\AppData\Local\Temp\InPutDataFileTask5V13.txt";
            matrix = ds.LoadFromDataFile(path);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_KFA.ColumnCount = columns;
            dataGridViewResult_KFA.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KFA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KFA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i]);
                }
            }
        }
    }
}
