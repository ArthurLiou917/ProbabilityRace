using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5OOPRace
{
    public partial class Form1 : Form
    {
        //declaring global tortise and hare
        tortoise tortoiser;
        hare harer;
        
        public class Contender//parent class for t and h
        {
            //used proptected for race elements
            protected int iPosition;
            protected int iSteps;
            protected int iTotalWins;
            protected int iTotalTies;
            //used public for scoreboard
            public int iWins = 0;
            public int iTies = 0;
            //used for colour
            public Color clr;
            public Contender()//default constructor
            {
                iSteps = 70;
                iPosition = 0;
                clr = Color.Black;
            }
            public Contender(int steps,int position,Color col)//constructor with paramater
            {
                if (iSteps < 0)//if and else to prevent negatives
                {
                    iSteps = -steps;
                }
                else
                {
                    iSteps = steps;
                }
                if (iPosition < 0)//if and else to prevent negatives
                {
                    iPosition = 0;
                }
                else
                {
                    iPosition = position;
                }
                clr = col;
            }
            //setters
            public void setSteps(int steps)
            {
                if (iSteps < 0)//if and else to prevent negatives
                {
                    iSteps = -steps;
                }
                else
                {
                    iSteps = steps;
                }       
            }
            public void setPosition(int position)
            {
                if (iPosition < 0)//if and else to prevent negatives
                {
                    iPosition = -position;
                }
                else
                iPosition = position;
            }
            public void setColor(Color col)
            {
                clr = col;
            }
            public void setWins(int wins)
            {
                iTotalWins = wins;
            }
            public void setTies(int ties)
            {
                iTotalTies = ties;
            }
            //getters
            public int getSteps()
            {
                return iSteps;
            }
            public int getPosition()
            {
                return iPosition;
            }
            public Color getColor()
            {
                return clr;
            }
            public int getTies()
            {
                return iTotalTies;
            }
            public int getWins()
            {
                return iTotalWins;
            }
            //bool used for determining which is winner
            public bool isWinner()
            {
                if(iPosition>=iSteps)
                {
                    return true;
                }
                return false;
            }
            //updating wins method
            public void UpdateWins()
            {
                iTotalWins = iTotalWins + 1;
                iWins = iWins + 1;
            }
            //updating ties method
            public void UpdateTies()
            {
                iTotalTies = iTotalTies + 1;
                
                iTies = iTies + 1;
            }
        }
        public class tortoise : Contender//child class tortoise
        {
            Random rng;//used for generating a random number.
            public tortoise() : base()
            {
                 rng = new Random();
            }
            public tortoise(int steps, int position, Color col):base(steps, position, col)
            {
                 rng = new Random();
            }
            public void UpdatePosition()//update position method to calculate percentages of moves for tortoise
            {
                int percent = rng.Next(0, 100);

                if (percent < 50)
                {
                    iPosition = iPosition + 3;
                }
                else if (percent < 70)
                {
                    iPosition = iPosition - 6;
                    if (iPosition < 0)
                    {
                        iPosition = 0;
                    }
                }
                else
                {
                    iPosition = iPosition + 1;
                }
            }
            public void Draw(Graphics g, int yloc)//draw method for tortoise(circle)
            {
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillEllipse(myBrush, iPosition * 10 + 15, yloc, 10, 10);
            }
        }
        public class hare : Contender//child class hare
        {
            Random rng;//used for generating a random number.
            public hare() : base()
            {
                rng = new Random();
            }
            public hare(int steps, int position, Color col) : base(steps,position, col)
            {
                rng = new Random();
            }
            public void UpdatePosition()//update position method to calculate percentages of moves for hare
            {
                int percent = rng.Next(0, 100);
                if (percent < 20)
                {
                    iPosition = iPosition - 0;
                }
                else if (percent < 40)
                {
                    iPosition = iPosition + 9;
                }
                else if (percent < 50)
                {
                    iPosition = iPosition - 12;
                    if (iPosition < 0)//cant go behind start line
                    {
                        iPosition = 0;
                    }
                }
                else if (percent < 80)
                {
                    iPosition = iPosition + 1;
                }
                else 
                {
                    iPosition = iPosition - 2;
                    if (iPosition<0)//cant go behind start line
                    {
                        iPosition = 0;
                    }
                }
            }
            public void Draw(Graphics g,int yloc)//draw method for hare(rectangle)
            {
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillRectangle(myBrush, iPosition * 10 + 15, yloc, 10, 10);
            }
        }
        public Form1()
        {
            InitializeComponent();
            tortoiser = new tortoise();//initalize with default constructors
            harer = new hare();
            gresults.Titles.Add("Race Results");//adds title for pie chart
            pbH.BackColor = Color.Transparent;
        }
        private void racetimer_Tick(object sender, EventArgs e)//used with timer updates position and stops when a winner is determined or there is a tie
        {
            tortoiser.UpdatePosition();
            harer.UpdatePosition();
            pbRace.Invalidate();
            if (tortoiser.isWinner() && harer.isWinner())//if statement for tie
            {
                racetimer.Enabled = false;
                MessageBox.Show("Tie");
                Reset();
                harer.UpdateTies();

                txtHTies.Text = Convert.ToString(harer.getTies());//updates for stat board
                txtHTies2.Text = Convert.ToString(harer.iTies);//updates for scoreboard

                gresults.Series["Series1"].Points.Clear();//updates pie chart
                UpdateChart();
            }
            else if (tortoiser.isWinner())//if statement for tortoiser win
            {
                racetimer.Enabled = false;
                MessageBox.Show("Tortoise Wins!");
                Reset();
                tortoiser.UpdateWins();

                txtTWins.Text = Convert.ToString(tortoiser.getWins());//updates for stat board
                txtTWins2.Text = Convert.ToString(tortoiser.iWins);//updates for scoreboard

                gresults.Series["Series1"].Points.Clear();//updates pie chart
                UpdateChart();
            }
            else if (harer.isWinner())//if statement for hare win
            {
                racetimer.Enabled = false;
                MessageBox.Show("Hare Wins!");
                Reset();
                harer.UpdateWins();

                txtHWins.Text = Convert.ToString(harer.getWins());//updates for stat board
                txtHWins2.Text = Convert.ToString(harer.iWins);//updates for scoreboard

                gresults.Series["Series1"].Points.Clear();//updates pie chart
                UpdateChart();
            }
            else if (harer.getPosition() == tortoiser.getPosition())
            {
                MessageBox.Show("Ouch!");
            }
        }
        private void pbRace_Paint(object sender, PaintEventArgs e)
        {
            //uses draw mode
            Graphics g = e.Graphics;

            tortoiser.Draw(g, 100);
            harer.Draw(g, 200);

            //uses picture mode if user selects option
            if (rbPicture.Checked == true)
            {
                pbT.Visible = true;
                pbH.Visible = true;
                pbT.Location = new Point(tortoiser.getPosition() * 10 + 15, 100);
                pbH.Location = new Point(harer.getPosition() * 10 + 15, 200);
            }
            else
            {
                pbT.Visible = false;
                pbH.Visible = false;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)//start button
        {
            //Different speed values affect tick interval
            if(cBoxSpeed.Text == "Slow(0.5x)")
            {
                racetimer.Interval = 150;
                racetimer.Enabled = true;
                racetimer.Start();
            }
            else if (cBoxSpeed.Text == "Default")
            {
                racetimer.Interval = 100;
                racetimer.Enabled = true;
                racetimer.Start();
            }
            else if (cBoxSpeed.Text == "Fast(2.0x)")
            {
                racetimer.Interval = 50;
                racetimer.Enabled = true;
                racetimer.Start();
            }
            //need to input speed value
            else
            {
                MessageBox.Show("Please select valid speed input");
                return;
            } 
        }
        private void btnPause_Click(object sender, EventArgs e)//pauses race
        {
            racetimer.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)//reset button
        {
            Reset();
        }
        private void btnHColour_Click(object sender, EventArgs e)//change colour of hare
        {
            ColorDialog colDlg = new ColorDialog();
            if (colDlg.ShowDialog() == DialogResult.OK)
            {
                harer.clr = colDlg.Color;
                pbRace.Invalidate();
            }
        }
        private void btnTColour_Click(object sender, EventArgs e)//change colour of tortoise
        {
            ColorDialog colDlg = new ColorDialog();
            if (colDlg.ShowDialog() == DialogResult.OK)
            {
                tortoiser.clr = colDlg.Color;
                pbRace.Invalidate();
            }
        }
        public void UpdateFiles(int hties, int hwins, int twins)//update save file method
        {
            TextWriter tw = new StreamWriter("Results");//creates txt writer in default location
            tw.Write(hties + ",");//commas splits input
            tw.Write(hwins + ",");
            tw.WriteLine(twins);
            tw.Close();
        }
        public void Reset()//reset button method
        {
            racetimer.Stop();
            pbRace.Invalidate();
            harer.setPosition(0);//reset position to start line
            tortoiser.setPosition(0);
        }
        public void UpdateChart()//update pie chart method
        {
            gresults.Series["Series1"].Points.AddXY("Hare Wins", harer.getWins());
            gresults.Series["Series1"].Points.AddXY("Tortoise Wins", tortoiser.getWins());
            gresults.Series["Series1"].Points.AddXY("Ties", harer.getTies());
            gresults.Invalidate();
        }
        public void UpdateStats()//updates overall statistic board method
        {
            txtHTies.Text = Convert.ToString(harer.getTies());
            txtTWins.Text = Convert.ToString(tortoiser.getWins());
            txtHWins.Text = Convert.ToString(harer.getWins());
        }
        public void ResetScoreBoard()//resets score board method
        {
            txtHTies2.Text = "0";
            txtTWins2.Text = "0";
            txtHWins2.Text = "0";
            harer.iWins = 0;
            tortoiser.iWins = 0;
            harer.iTies = 0;
            harer.iWins = 0;
        }
        private void Form1_Load(object sender, EventArgs e)//form loading
        {
            if (File.Exists(@"Results"))//if previous save file is found update all items based on values of that save file
            {
                string strInput;
                string[] splittedInput;
                TextReader tr = new StreamReader("Results");
                while ((strInput = tr.ReadLine()) != null)
                {
                    splittedInput = strInput.Split(',');
                    harer.setTies(Convert.ToInt32(splittedInput[0]));
                    harer.setWins(Convert.ToInt32(splittedInput[1]));
                    tortoiser.setWins(Convert.ToInt32(splittedInput[2]));
                }
                tr.Close();
                UpdateStats();
                UpdateChart();
            }
            else//else create and read an empty save file
            {
                TextWriter tw = new StreamWriter("Results");
                tw.Write(0 + ",");
                tw.Write(0 + ",");
                tw.WriteLine(0);
                tw.Close();

                string strInput;
                string[] splittedInput;
                TextReader tr = new StreamReader("Results");
                while ((strInput = tr.ReadLine()) != null)
                {
                    splittedInput = strInput.Split(',');
                    harer.setTies(Convert.ToInt32(splittedInput[0]));
                    harer.setWins(Convert.ToInt32(splittedInput[1]));
                    tortoiser.setWins(Convert.ToInt32(splittedInput[2]));
                }
                tr.Close();    
                UpdateStats();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateFiles(harer.getTies(), harer.getWins(), tortoiser.getWins());//automatically saves after closing program
        }
        private void btnResetScore_Click(object sender, EventArgs e)//button that resets the scoreboard
        {
            ResetScoreBoard();
        }
        private void rbPicture_CheckedChanged(object sender, EventArgs e)//shows picture mod when radio button is clicked
        {
            pbT.Visible = true;
            pbH.Visible = true;
        }
        private void rbDraw_CheckedChanged(object sender, EventArgs e)//hides picture if draw radio button is clicked
        {
            pbT.Visible = false;
            pbH.Visible = false;
        }

        private void pbRace_Click(object sender, EventArgs e)
        {

        }
    }
}
