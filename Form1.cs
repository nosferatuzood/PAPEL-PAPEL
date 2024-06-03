using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPEL_PAPEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          



        }
        string playerchoice = "";
        string compchoice = "";
        int round = 1;
        int wins = 0;

        private void rockbtn_Click(object sender, EventArgs e)
        {
            playerchoice = "rock";
            getrandomnumber();

            if (compchoice == playerchoice)
            {
                tie();
            }
            if (compchoice == "scissors")
            {
                win();
            }
            if (compchoice == "paper")
            {
                lose();
            }
            round++;
            Roundstxt.Text = "Rounds: " + round;

        }

        private void Paperbtn_Click(object sender, EventArgs e)
        {
            playerchoice = "paper";
            getrandomnumber();

            if (compchoice == playerchoice)
            {
                tie();
            }
            if (compchoice == "scissors")
            {
                lose();
            }
            if (compchoice == "rock")
            {
                win();
            }
            round++;
            Roundstxt.Text = "Rounds: " + round;
        }

        private void Scissorsbtn_Click(object sender, EventArgs e)
        {
            playerchoice = "scissor";
            getrandomnumber();

            if (compchoice == playerchoice)
            {
                tie();
            }
            if (compchoice == "paper")
            {
                win();
            }
            if (compchoice == "rock")
            {
                lose();
            }
            round++;
            Roundstxt.Text = "Rounds: " + round;
        }


        //////
        /// random nr generator
        /// 

        void getrandomnumber()
        {
            Random random = new Random();
            int randomnumber = random.Next(0, 3);

            if (randomnumber == 0)
            {
                compchoice = "Rock";


            }
            else if (randomnumber == 1)
            {
                compchoice = "paper";
            }
            else if (randomnumber == 2)
            {
                compchoice = "scissors";
            }
        }

        ////
        ///win lose tie
        ///

        void lose()
        {
            MessageBox.Show("you lost!!");
        }

        void win()
        {
            MessageBox.Show("you win!!");
            wins++;
            wintxt.Text = "Wins: " + wins;
        }
        void tie()
        {
            MessageBox.Show("Its a tie!!!");
        }

    }
}
