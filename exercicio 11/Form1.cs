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
    }
}