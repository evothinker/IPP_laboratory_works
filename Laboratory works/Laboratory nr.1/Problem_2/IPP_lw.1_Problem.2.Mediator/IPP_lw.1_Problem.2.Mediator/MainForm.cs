using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPP_lw._1_Problem._2.Mediator
{
    public partial class MainForm : Form
    {
        Mediator mediator;

        public MainForm()
        {
            InitializeComponent();

            //instantiate the mediator with 2 players
            mediator = new Mediator(2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            mediator.StartGame();
        }

        private void btnPressPlayer1_Click(object sender, EventArgs e)
        {
            mediator.AddPoint(1);
            textBoxScoarboardPlayer1.Text = Convert.ToString(mediator.GetPoints(1));
        }

        private void btnPressPlayer2_Click(object sender, EventArgs e)
        {
            mediator.AddPoint(2);
            textBoxPlayer2.Text = Convert.ToString(mediator.GetPoints(2));
        }

        private void textBoxScoarboardPlayer1_TextChanged(object sender, EventArgs e){}

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e){}

    }
}
