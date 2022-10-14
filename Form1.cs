using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Start;
        }

        public void Start(object sender, EventArgs e)
        {
            DialogResult result;
            int numDialog = 1;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Загадайте число від 1 до 2000", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Кільлість запитів{numDialog}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    result = MessageBox.Show($"Продовжити ?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;
            }
            }


        }
}
