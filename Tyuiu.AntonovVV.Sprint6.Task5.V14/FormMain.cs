using Tyuiu.AntonovVV.Sprint6.Task5.V14.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V14.txt";

        private void buttonDone_AVV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewInPut_AVV.ColumnCount = 2;
                dataGridViewInPut_AVV.Columns[0].Width = 20;
                dataGridViewInPut_AVV.Columns[1].Width = 50;

                this.chartInPut_AVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartInPut_AVV.ChartAreas[0].AxisY.Title = "Ось Y";

                chartInPut_AVV.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewInPut_AVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartInPut_AVV.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_AVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_AVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-24-1 Антонов В. В.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}