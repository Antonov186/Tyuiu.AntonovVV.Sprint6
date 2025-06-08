using Tyuiu.AntonovVV.Sprint6.Task4.V2.Lib;
using System.Windows.Forms.VisualStyles;

namespace Tyuiu.AntonovVV.Sprint6.Task4.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);


                this.chartResult.ChartAreas[0].AxisX.Title = "��� X";
                this.chartResult.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult.Text = "";

                chartResult.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartResult.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������� �. �.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}