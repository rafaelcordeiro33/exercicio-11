namespace exercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void amareloToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //ya
        private void cordotextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}