using Tyuiu.AntonovVV.Sprint6.Task1.V25.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_AVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСПб-24-1 Антонов В.В.", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();

        private void buttonDone_AVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_AVV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AVV.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_AVV.Text = "";
                textBoxResult_AVV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_AVV.AppendText("|      x   |    f(x)  | " + Environment.NewLine);
                textBoxResult_AVV.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_AVV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_AVV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_AVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartValue_AVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopValue_AVV_TextChanged(object sender, EventArgs e)
        {

        }
    }