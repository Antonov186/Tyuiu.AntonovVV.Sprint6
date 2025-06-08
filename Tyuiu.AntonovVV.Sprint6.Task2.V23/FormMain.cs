using Tyuiu.AntonovVV.Sprint6.Task2.V23.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerform_AVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_AVV.Text);
                int stopStep = Convert.ToInt32(textBoxInputEnd_AVV.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_AVV.Titles.Add("График функции");
                this.chartFunction_AVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AVV.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_AVV.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartFunction_AVV.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPerform_AVV_MouseEnter(object sender, EventArgs e)
        {
            buttonPerform_AVV.BackColor = Color.Gold;
        }

        private void buttonReference_AVV_MouseEnter(object sender, EventArgs e)
        {
            buttonReference_AVV.BackColor = Color.Chartreuse;
        }

        private void buttonPerform_AVV_MouseLeave(object sender, EventArgs e)
        {
            buttonPerform_AVV.BackColor = Color.Green;
        }

        private void buttonPerform_AVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPerform_AVV.BackColor = Color.Purple;
        }

        private void buttonReference_AVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 1 выполнил Антонов В. В.", "Сообщение", MessageBoxButtons.OK);
        }
    }
}