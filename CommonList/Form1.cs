using System;
using System.Data;
using System.Windows.Forms;

namespace CommonList
{
    public partial class Form1 : Form
    {
        //DataTable 정의
        public DataTable dt = new DataTable("Table1");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2(ref dt);
            fm2.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dt.Rows[listBox1.SelectedIndex].Delete();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Column 정의
            DataColumn nameColumn = new DataColumn("내용", typeof(string));
            DataColumn ageColumn = new DataColumn("값", typeof(string));
            dt.Columns.Add(nameColumn);
            dt.Columns.Add(ageColumn);

            //Row 생성
            DataRow row = dt.NewRow();
            row[nameColumn] = "1.테스트";
            row[ageColumn] = "1";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[nameColumn] = "2.확인";
            row[ageColumn] = "2";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[nameColumn] = "3.마지막";
            row[ageColumn] = "3";
            dt.Rows.Add(row);

            listBox1.DisplayMember = "내용";
            listBox1.ValueMember = "값";
            listBox1.DataSource = dt;
        }
    }
}
