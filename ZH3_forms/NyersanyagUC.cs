using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_forms.ReceptModels;

namespace ZH3_forms
{
    public partial class NyersanyagUC : UserControl
    {
        ReceptContext context = new ReceptContext();


        public NyersanyagUC()
        {
            InitializeComponent();
            ListNyersanyag();

            Dock = DockStyle.Fill;
        }

        private void ListNyersanyag()
        {
            var items = from x in context.Nyersanyagoks
                        where x.NyersanyagNev.Contains(textBox1.Text)
                        select x;
            dataGridView1.DataSource = items.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListNyersanyag();
        }
    }
}
