namespace area_Quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            RTextBox.Text = (Convert.ToDouble(VLTextBox.Text) * Convert.ToDouble(VLTextBox.Text)).ToString();
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LButton_Click(object sender, EventArgs e)
        {
            RTextBox.Text = " ";
            VLTextBox.Text = " ";
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
