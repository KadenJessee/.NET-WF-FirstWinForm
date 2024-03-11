namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Third button (press), displays what they typed, messagebox, and cancel/try/continue buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            //displays message box
            MyResult = MessageBox.Show("You're back again?", "Oh here's what you entered: " + textBox3.Text, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Question);

            //returns what user clicked onto form
            lblDisplayTxt3.Text = MyResult.ToString();
        }
        /// <summary>
        /// First button (Click), shows typed message and can choose between yes and no, sends result to label1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            //displays message box
            MyResult = MessageBox.Show("What path do you take?", "Congrats, you know how to type: " + textBox1.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //returns what user clicked onto form
            lblDisplayTxt.Text =  MyResult.ToString();
        }
        /// <summary>
        /// Second button (Tap), displays typed message, allows for clicking cancel or retry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            //displays message box, has buttons and shows what user typed
            MyResult = MessageBox.Show("What will you do next?", textBox2.Text + " is the powerhouse of the cell", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);

            //returns what user clicked onto form
            lblDisplayTxt2.Text = MyResult.ToString();
        }
    }
}