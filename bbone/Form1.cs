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
        Image[] diceImgs;
        Button[] dice;
        Label[] scoreLabels;
        Label[] nameLabels;
        int[] scores;
        String[] names;
        List<int[]> rolls;
        #endregion

        #region Die Selection and Marking
        // used to mark rolls in the rolls list and to validate dice rolls
        private int[] CountDice()
        {
            int[] diceCount = new int[6] { 0, 0, 0, 0, 0, 0 };         

            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i].Enabled == true && dice[i].BackColor == Color.DarkGreen)
                    switch(dice[i].Text)
                    {
                        case "1":
                            diceCount[0]++; break;
                        case "2":
                            diceCount[1]++; break;
                        case "3":
                            diceCount[2]++; break;
                        case "4":
                            diceCount[3]++; break;
                        case "5":
                            diceCount[4]++; break;
                        case "6":
                            diceCount[5]++; break;
                    }
            }

            return diceCount;
        }

        // make sure the dice selected are valid
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
            updateScoreText();

            return true;
        }

        // helper method to check for straights
        private bool StraightChecker()
        {
            int[] count = CountDice();

            // reset stuff if it's already visible
            if (straightLabel.Visible == true)
            {
                straightLabel.Visible = false;
                roll_button.Enabled = true;
            }

            if (count[0] == 1 && count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1 && count[5] == 1)
            {
                straightLabel.Visible = true;
                roll_button.Enabled = false;
                error_msg.Visible = false;
                return true;
            }

            return false;
        }
        #endregion

        #region Score Updating/Calculation
        // calculate score
        private int ScoreCalc()
        {
            back = false;

            int score = 0;

            rolls.Add(CountDice());

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

            // condition for a straight
            if (count[0] == 1 && count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1 && count[5] == 1)
                return 1000;

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

        // update roll score text
        private void updateScoreText()
        {
            int score = 0;
            for (int i = 0; i < rolls.Count; i++)
                score += ScoreAdd(rolls[i]);
            currScore.Text = "Current Roll Score: " + score;
        }
        #endregion

        // initialize the form
        public Form1()
        {
            InitializeComponent();

            // initialize arrays and rolls list
            nameLabels = new Label[12] { p1_score, p2_score, p3_score, p4_score, p5_score, p6_score, p7_score, p8_score, p9_score, p10_score, p11_score, p12_score };
            scoreLabels = new Label[12] { p1_num, p2_num, p3_num, p4_num, p5_num, p6_num, p7_num, p8_num, p9_num, p10_num, p11_num, p12_num };
            dice = new Button[6] { die1, die2, die3, die4, die5, die6 };
            diceImgs = new Image[6] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6 };
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

            currScore.Visible = false;
            error_msg.Visible = false;
            straightLabel.Visible = false;

            // big font size
            Font font = new Font(die1.Font.FontFamily, 1);

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
            allSelectLabel.Visible = false;

            if (DieSelectValidation() == true)
            {
                // if all dice are selected, reroll all
                if (dice[0].BackColor == Color.DarkGreen && dice[1].BackColor == Color.DarkGreen && dice[2].BackColor == Color.DarkGreen && dice[3].BackColor == Color.DarkGreen && dice[4].BackColor == Color.DarkGreen && dice[5].BackColor == Color.DarkGreen)
                    reroll_all_Click(sender, e);

                // otherwise, only roll non-selected dice and disable pre-selected dice
                else
                {
                    for (int i = 0; i < dice.Length; i++)
                    {
                        if (dice[i].BackColor == Color.DarkGreen && dice[i].Enabled == true)
                            dice[i].Enabled = false;

                        if (dice[i].BackColor == Color.White)
                        {
                            int roll = rgen.Next(1, 7);
                            dice[i].BackgroundImage = diceImgs[roll - 1];
                            dice[i].Text = "" + roll;
                        }
                    }
                }
            }

            // display "invalid dice" message if selection does not pass through dieselect
            else
                error_msg.Visible = true;

            StraightChecker();
        }

        // end turn, finalize score calculation
        private void endTurn_butt_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            allSelectLabel.Visible = false;

            if (dice[0].BackColor == Color.DarkGreen && dice[1].BackColor == Color.DarkGreen && dice[2].BackColor == Color.DarkGreen && dice[3].BackColor == Color.DarkGreen && dice[4].BackColor == Color.DarkGreen && dice[5].BackColor == Color.DarkGreen)
                allSelectLabel.Visible = true;
            else
            {
                int score = ScoreCalc();

                // add to score (if player has appropriate points, of course)
                if (scores[currentPlayer] == 0)
                    if (score < 1000) { }
                    else
                        scores[currentPlayer] += score;
                else
                    scores[currentPlayer] += score;

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

                // reset current score label
                currScore.Text = "Current Roll Score: 0";

                // end turn by rerolling all dice
                reroll_all_Click(sender, e);
            }
        }

        // start/new game button
        private void startButt_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            straightLabel.Visible = false;
            allSelectLabel.Visible = false;

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

                currScore.Text = "Current Roll Score: 0";
                currScore.Visible = true;

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
                currScore.Visible = false;
                currScore.Text = "Current Roll Score: 0";
            }
        }

        // rerolling all dice function
        private void reroll_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                int roll = rgen.Next(1, 7);
                dice[i].BackgroundImage = diceImgs[roll - 1];
                dice[i].Text = "" + roll;
                dice[i].BackColor = Color.White;
                dice[i].Enabled = true;
            }

            StraightChecker();
        }

        // debug roll a straight
        private void roll_straight_Click(object sender, EventArgs e)
        {
            dice[0].Text = "1";
            dice[1].Text = "2";
            dice[2].Text = "3";
            dice[3].Text = "4";
            dice[4].Text = "5";
            dice[5].Text = "6";

            StraightChecker();
        }
        #endregion
    }
}
