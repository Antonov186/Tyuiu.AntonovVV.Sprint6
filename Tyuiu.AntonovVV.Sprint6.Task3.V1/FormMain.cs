using Tyuiu.AntonovVV.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {25, 20, 28, 2, 6},
                          {19, -9, 18, -7, 24},
                          {21, 16, 5, -7, -8},
                          {30, -13, 1, 15, 2},
                          {31, 9, -3, -9, -18} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_AVV.ColumnCount = columns;
            dataGridViewMatrix_AVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_AVV.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_AVV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonToDo_AVV_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_AVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_AVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб 24-1 Антонов В.В.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}