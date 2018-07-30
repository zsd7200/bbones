using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace bbone
{
    public partial class Form1 : Form
    {
        #region Global Variables
        // rng
        Random rgen = new Random();

        int currentPlayer;
        bool back;

        // arrays and lists to hold dice, labels, player scores and names, and rolls
        Button[] dice;
        Label[] scoreLabels;
        Label[] nameLabels;
        int[] scores;
        String[] names;
        List<int[]> rolls;
        #endregion

        // used to mark rolls in the rolls list and to validate dice rolls
        private int[] CountDice()
        {
            int[] diceCount = new int[6] { 0, 0, 0, 0, 0, 0 };         

            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i].Text == "1" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[0]++;
                else if (dice[i].Text == "2" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[1]++;
                else if (dice[i].Text == "3" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[2]++;
                else if (dice[i].Text == "4" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[3]++;
                else if (dice[i].Text == "5" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[4]++;
                else if (dice[i].Text == "6" && dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    diceCount[5]++;
            }

            return diceCount;
        }

        // make sure the dies selected are valid
        private bool DieSelectValidation()
        {
            int[] count = CountDice();

            if (count[1] == 2 || count[1] == 1)
                return false;

            if (count[2] == 2 || count[2] == 1)
                return false;

            if (count[3] == 2 || count[3] == 1)
                return false;

            if (count[5] == 2 || count[5] == 1)
                return false;

            if (count[0] == 0 && count[1] == 0 && count[2] == 0 && count[3] == 0 && count[4] == 0 && count[5] == 0)
                return false;

            rolls.Add(count);

            return true;
        }

        // calculate score
        private int ScoreCalc()
        {
            back = false;

            int score = 0;

            int[] count = CountDice();
            rolls.Add(count);

            for (int i = 0; i < rolls.Count; i++)
                score += ScoreAdd(rolls[i]);

            rolls.Clear();

            if (back == true)
                return -100;

            return score;
        }

        // all score values are here
        private int ScoreAdd(int[] count)
        {
            int score = 0;

            switch (count[0])
            {
                case 1: score += 100; break;
                case 2: score += 200; break;
                case 3: score += 1000; break;
                case 4: score += 2000; break;
                case 5: score += 4000; break;
                case 6: score += 8000; break;
            }

            switch (count[1])
            {
                case 3: score += 200; break;
                case 4: score += 400; break;
                case 5: score += 800; break;
                case 6: score += 1600; break;
            }

            switch (count[2])
            {
                case 3: score += 300; break;
                case 4: score += 600; break;
                case 5: score += 1200; break;
                case 6: score += 2400; break;
            }

            switch (count[3])
            {
                case 3: score += 400; break;
                case 4: score += 800; break;
                case 5: score += 1600; break;
                case 6: score += 3200; break;
            }

            switch (count[4])
            {
                case 1: score += 50; break;
                case 2: score += 100; break;
                case 3: score += 500; break;
                case 4: score += 1000; break;
                case 5: score += 2000; break;
                case 6: score += 4000; break;
            }

            switch (count[5])
            {
                case 3: score += 600; break;
                case 4: score += 1200; break;
                case 5: score += 2400; break;
                case 6: score += 4800; break;
            }

            if (score == 0)
                back = true;

            return score;
        }

        // initialize the form
        public Form1()
        {
            InitializeComponent();

            // initialize arrays and rolls list
            nameLabels = new Label[12] { p1_score, p2_score, p3_score, p4_score, p5_score, p6_score, p7_score, p8_score, p9_score, p10_score, p11_score, p12_score };
            scoreLabels = new Label[12] { p1_num, p2_num, p3_num, p4_num, p5_num, p6_num, p7_num, p8_num, p9_num, p10_num, p11_num, p12_num };
            dice = new Button[6] { die1, die2, die3, die4, die5, die6 };
            rolls = new List<int[]>();

            currentPlayer = 0;

            // hide labels until they're needed
            for (int i = 0; i < nameLabels.Length; i++)
            {
                nameLabels[i].Visible = false;
                scoreLabels[i].Visible = false;
                scoreLabels[i].AutoSize = false;
                scoreLabels[i].TextAlign = ContentAlignment.MiddleRight;
            }

            error_msg.Visible = false;

            // big font size
            Font font = new Font(die1.Font.FontFamily, 72);

            // get dice ready
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].BackColor = Color.White;
                dice[i].Font = font;
                dice[i].Text = "👍🏻";
                dice[i].Enabled = false;
            }

            // disable other buttons
            roll_button.Enabled = false;
            endTurn_butt.Enabled = false;

        }

        #region Dice Clicking
        private void die1_Click(object sender, EventArgs e)
        {
            if (die1.BackColor == Color.White)
                die1.BackColor = Color.DarkGreen;
            else
                die1.BackColor = Color.White;
        }
        private void die2_Click(object sender, EventArgs e)
        {
            if (die2.BackColor == Color.White)
                die2.BackColor = Color.DarkGreen;
            else
                die2.BackColor = Color.White;
        }
        private void die3_Click(object sender, EventArgs e)
        {
            if (die3.BackColor == Color.White)
                die3.BackColor = Color.DarkGreen;
            else
                die3.BackColor = Color.White;
        }
        private void die4_Click(object sender, EventArgs e)
        {
            if (die4.BackColor == Color.White)
                die4.BackColor = Color.DarkGreen;
            else
                die4.BackColor = Color.White;
        }
        private void die5_Click(object sender, EventArgs e)
        {
            if (die5.BackColor == Color.White)
                die5.BackColor = Color.DarkGreen;
            else
                die5.BackColor = Color.White;
        }
        private void die6_Click(object sender, EventArgs e)
        {
            if (die6.BackColor == Color.White)
                die6.BackColor = Color.DarkGreen;
            else
                die6.BackColor = Color.White;
        }
        #endregion

        #region Roll Buttons
        // roll dice that are not green
        private void roll_button_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;

            if (DieSelectValidation() == true)
            {
                for (int i = 0; i < dice.Length; i++)
                {
                    if (dice[i].BackColor == Color.DarkGreen && dice[i].Enabled == true)
                        dice[i].Enabled = false;

                    if (dice[i].BackColor == Color.White)
                    {
                        int roll = rgen.Next(1, 7);
                        dice[i].Text = "" + roll;
                    }
                }


            }

            // display "invalid dice" message if selection does not pass through dieselect
            else
                error_msg.Visible = true;
        }

        // rerolling function
        private void reroll_all_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;

            for (int i = 0; i < dice.Length; i++)
            {
                int roll = rgen.Next(1, 7);
                dice[i].Text = "" + roll;
                dice[i].BackColor = Color.White;
                dice[i].Enabled = true;
            }
        }

        // end turn, finalize score calculation
        private void endTurn_butt_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;

            Console.WriteLine(ScoreCalc());

            // add to score (if player has appropriate points, of course)
            if (scores[currentPlayer] == 0)
                if (ScoreCalc() < 1000) { }
                else
                    scores[currentPlayer] += ScoreCalc();
            else
                scores[currentPlayer] += ScoreCalc();

            if (scores[currentPlayer] <= 950)
            {
                scores[currentPlayer] = 0;
                scoreLabels[currentPlayer].Text = "" + scores[currentPlayer];
            }

            // change label score, increment current player
            scoreLabels[currentPlayer].Text = "" + scores[currentPlayer];
            currentPlayer++;

            // rollover current player
            if (currentPlayer >= scores.Length)
                currentPlayer = 0;

            // end turn by rerolling all dice
            reroll_all_Click(sender, e);
        }

        // start/new game button
        private void startButt_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;

            // start the game
            if (numPlayers.Enabled == true)
            {
                numPlayers.Enabled = false;

                // initialize the scores and names array with the number of players
                scores = new int[(int)numPlayers.Value];
                names = new String[(int)numPlayers.Value];

                for (int i = 0; i < numPlayers.Value; i++)
                {
                    names[i] = Microsoft.VisualBasic.Interaction.InputBox("Enter name of Player " + (i + 1) + ":", "bBones Name Entry", "enter name here");

                    if (names[i] == "" || names[i] == "enter name here")
                        names[i] = "Player " + (i + 1);

                    nameLabels[i].Text = names[i] + ":";
                    scoreLabels[i].Text = "0";
                    nameLabels[i].Visible = true;
                    scoreLabels[i].Visible = true;
                }

                startButt.Text = "New Game";

                roll_button.Enabled = true;
                endTurn_butt.Enabled = true;
                for (int i = 0; i < dice.Length; i++)
                    dice[i].Enabled = true;

                // officially start game by rerolling all dice
                reroll_all_Click(sender, e);
            }

            // reset conditions
            else
            {
                numPlayers.Enabled = true;
                startButt.Text = "Start Game";

                for (int i = 0; i < scores.Length; i++)
                {
                    nameLabels[i].Visible = false;
                    scoreLabels[i].Visible = false;
                    scores[i] = 0;
                }

                for (int i = 0; i < dice.Length; i++)
                {
                    dice[i].BackColor = Color.White;
                    dice[i].Text = "👍🏻";
                    dice[i].Enabled = false;
                }

                roll_button.Enabled = false;
                endTurn_butt.Enabled = false;
            }
        }
        #endregion
    }
}
