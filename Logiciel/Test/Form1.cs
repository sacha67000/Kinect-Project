using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class SmartTalk : Form
    {
        public SmartTalk()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartRecordingButton.Show();
            BackButton.Show();
            StartButton.Hide();
            OptionButton.Hide();
            Title.Hide();
            CloseButton.Hide();
            Option1.Hide();
            Option2.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButton.Hide();
            StartRecordingButton.Hide();
            Title.Show();
            CloseButton.Show();
            StartButton.Show();
            OptionButton.Show();
            Option1.Hide();
            Option2.Hide();
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Option1.Show();
            Option2.Show();
            BackButton.Show();
            Title.Hide();
            CloseButton.Hide();
            OptionButton.Hide();
            StartButton.Hide();
        }
    }
}
