using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AntonovVV.Sprint6.Task0.V4.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task0.V4
{
    public partial class FormMain_AVV : Form
    {
        public FormMain_AVV()
        {
            InitializeComponent();
        }

        private void buttonGet_AVV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_AVV.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_AVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}