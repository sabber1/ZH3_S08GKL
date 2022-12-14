namespace ZH3_forms
{
    public partial class Form1 : Form
    {
        NyersanyagUC nyersanyag = new NyersanyagUC();
        ReceptekUC receptek = new ReceptekUC();

        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(nyersanyag);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(nyersanyag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(receptek);
        }
    }
}