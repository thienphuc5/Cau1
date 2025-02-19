using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbclass_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new StudentContext())
                {
                    dataGridView1.DataSource = context.Students.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void Button1_click(object sender, EventArgs e)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    Name = txtten.Text,
                    Age = int.Parse(txtage.Text),
                    Class = txtclass.Text
                };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
