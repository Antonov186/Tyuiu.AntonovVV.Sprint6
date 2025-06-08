using Tyuiu.AntonovVV.Sprint6.Task6.V29.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_AVV_Click(object sender, EventArgs e)
        {
            textBoxOutput_AVV.Text = ds.CollectTextFromFile(path);
        }

        private void buttonLoad_AVV_Click(object sender, EventArgs e)
        {
            openFileDialog_AVV.ShowDialog();
            path = openFileDialog_AVV.FileName;
            textBoxInput_AVV.Text = File.ReadAllText(path);
            groupBoxInput_AVV.Text = groupBoxInput_AVV.Text + " " + path;
            buttonStart_AVV.Enabled = true;
        }



        private void textBoxOutput_AVV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}