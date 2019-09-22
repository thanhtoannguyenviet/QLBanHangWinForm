using System;
using System.Windows.Forms;
using DAO;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.DataSource = HoaDonDAO.GetAllHoaDon();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
