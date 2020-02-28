using System;
using System.Windows.Forms;

namespace LineDraw.Forms
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void OpenEditor()
        {
            new Editor(textBox_Name.Text).Show();
            Close();
        }
        
        private void Create_Load(object sender, EventArgs e)
        {
            textBox_Name.SelectedText = "NewAnimation";
            textBox_Name.Select();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            button_Create.Enabled = textBox_Name.Text != "";
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            OpenEditor();
        }

        private void textBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            OpenEditor();
        }
    }
}