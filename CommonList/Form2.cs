using System;
using System.Data;
using System.Windows.Forms;

namespace CommonList
{
    public partial class Form2 : Form
    {
        //DataTable 정의
        private DataTable dt2;

        public Form2(ref DataTable al)
        {
            InitializeComponent();
            dt2 = al;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "내용";
            listBox1.ValueMember = "값";
            listBox1.DataSource = dt2;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dt2.Rows[listBox1.SelectedIndex].Delete();
        }
    }
}
