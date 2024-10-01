using System.Windows.Forms;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace PR5_FORM
{
    public partial class TransferFormDemo : Form
    {
        public TransferFormDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int number))
            {
                label1.Text = PR5_DLL.Transfer.num2Str(number);
            }
            else
            {
                MessageBox.Show("Ошибка преобразования");
            }
        }

        private void TransferFormDemo_Load(object sender, EventArgs e)
        {
        }
    }
}
