using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the default constructore
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event Handler for Lab08Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the even handler for the submitButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            // option A
            // UserAge = Convert.ToSingle(AgeTextBox.Text);

            // option B
            UserAge = float.Parse(AgeTextBox.Text);

            // option C
            // float tempFloat;
            // bool result = float.TryParse(AgeTextBox.Text, out tempFloat);
            // UserAge = tempFloat;

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }
    }
}
