using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duel
{
    public partial class Form1 : Form
    {
        int train = 0;
        //initialize player
        Player p = new Player("Player");
        int pWins = 0;
        //initialize computer
        Player c = new Player("Computer");
        int cWins = 0;
        
        //initialize computer brain
        //Layers
        //input: 4(my.hp, my.potions, notmy.hp, notmy.potions)
        //2: 
        //output: 3(my.attack, my.block, my.heal)
        NeuralNetwork brain1 = new NeuralNetwork(15, new int[] { 4, 4, 3 });
        NeuralNetwork brain2 = new NeuralNetwork(15, new int[] { 4, 4, 3 });
        NeuralNetwork ajax = new NeuralNetwork("Ajax.txt");
        NeuralNetwork burtha = new NeuralNetwork("Burtha.txt");
       
        public Form1()
        {
            InitializeComponent();
        }
        //Computer Start Button
        
        private void fightButton_Click(object sender, EventArgs e)
        {
            //Add computer training to this loop
            //See Who Wins
            //Define a way of telling who wins
            //Setting the input values
            List<double> playerStats = new List<Double>();
            playerStats.Add(Convert.ToDouble(p.getHP()));
            playerStats.Add(Convert.ToDouble(p.getPotions()));
            playerStats.Add(Convert.ToDouble(c.getHP()));
            playerStats.Add(Convert.ToDouble(c.getPotions()));
            //p.setState(brain1.Action(playerStats));
            //string pstat = string.Join(", ", playerStats.ToArray());
            //Computer Stats
            List<double> computerStats = new List<Double>();
            computerStats.Add(Convert.ToDouble(c.getHP()));
            computerStats.Add(Convert.ToDouble(c.getPotions()));
            computerStats.Add(Convert.ToDouble(p.getHP()));
            computerStats.Add(Convert.ToDouble(p.getPotions()));
            c.setState(burtha.Action(playerStats));
            //string cstat = string.Join(", ", computerStats.ToArray());
            //outputRTB.AppendText(pstat + "\n" + cstat + "\n");

            //Check if players alive
            if (p.getPulse() == false && c.getPulse() == false)
            {
                outputRTB.AppendText("\n" + "******Tie!******" );
                restart();
            }
            else if(c.getPulse() == false)//Computer Dead
            {
                outputRTB.AppendText("\n" + p.getName() + " Wins!" + "\n" + "Thank you for playing");
                restart();
                regenNN(burtha, computerStats);
            }
            else if (p.getPulse() == false)//Player Dead
            {
                Random n = new Random(Environment.TickCount);
                outputRTB.AppendText("\n" + c.getName() + " Wins!" + "\n" + "Thank you for playing");
                restart();
                //burtha.saveNetwork();
            }
            else
            {
                //Computer Decides what to do
                //c.setstate(brain.choice(p.getHP(), p.getPotions())
                //call p.TakeTurn(c)
                p.takeTurn(c, outputRTB);
                //Call c.TakeTurn(p)
                c.takeTurn(p, outputRTB);
                //call p.EndTurn()
                p.endTurn(playerStatsRTB, outputRTB, playerProgress);
                //call c.EndTurn(p)
                c.endTurn(compStatRTB, outputRTB, ComputerProgress);
            }
            outputRTB.SelectionStart = outputRTB.Text.Length;
            outputRTB.ScrollToCaret();
        }

        private void restart(){
            train++;
            if(train == 100)
            {
                outputRTB.AppendText("\n" + "Training Over" + "\n");
            }
            else
            {
                p = new Player("Player");
                c = new Player("Computer");
            }
            outputRTB.AppendText("\n" + "Game Restarting" + "\n");
            

        }
        //Player Attack Button
        private void attackButton_Click(object sender, EventArgs e)
        {
            //Set player state to a
            p.setState('a');
            
        }

        //Player Block Button
        private void blockButton_Click(object sender, EventArgs e)
        {
            //Set player state to b
            p.setState('b');
            
        }

        //Player Heal Button
        private void healButton_Click(object sender, EventArgs e)
        {
            //Set player state to h
            p.setState('h');
            
        }

        private void compAttack_Click(object sender, EventArgs e)
        {
            //Set computer to a
            c.setState('a');
        }

        private void compBlock_Click(object sender, EventArgs e)
        {
            //Set computer to b
            c.setState('b');
        }

        private void compHeal_Click(object sender, EventArgs e)
        {
            //Set computer to h
            c.setState('h');
        }


        private void trainBtn_Click(object sender, EventArgs e)
        {
            //Add computer training to this loop
            //See Who Wins
            //Define a way of telling who wins
            //Setting the input values
            
            
            while(train<1000)
            {
                List<double> playerStats = new List<Double>();
                playerStats.Add(Convert.ToDouble(p.getHP()));
                playerStats.Add(Convert.ToDouble(p.getPotions()));
                playerStats.Add(Convert.ToDouble(c.getHP()));
                playerStats.Add(Convert.ToDouble(c.getPotions()));
                //p.setState(ajax.Action(playerStats));
                p.setState(randomChar());
                string pstat = string.Join(", ", playerStats.ToArray());
                //Computer Stats
                List<double> computerStats = new List<Double>();
                computerStats.Add(Convert.ToDouble(c.getHP()));
                computerStats.Add(Convert.ToDouble(c.getPotions()));
                computerStats.Add(Convert.ToDouble(p.getHP()));
                computerStats.Add(Convert.ToDouble(p.getPotions()));
                c.setState(burtha.Action(computerStats));
                //Console.WriteLine(c.getState());
                string cstat = string.Join(", ", computerStats.ToArray());
                //outputRTB.AppendText(pstat + "\n" + cstat + "\n");
                
                //Check if players alive
                if (p.getPulse() == false && c.getPulse() == false)
                {
                    outputRTB.AppendText("\n" + "******Tie!******");
                    outputRTB.AppendText("\n" + "P Wins: " + pWins + "  C Wins: " + cWins);
                    restart();
                    //regenNN(ajax,playerStats);
                    regenNN(burtha, computerStats);
                }
                else if (c.getPulse() == false) //Computer Dead
                {
                    outputRTB.AppendText("\n" + p.getName() + " Wins!");
                    outputRTB.AppendText("\n" + "P Wins: " + pWins + "  C Wins: " + cWins);
                    restart();
                    regenNN(burtha, computerStats);
                    //ajax.saveNetwork();
                    pWins++;
                    pWinsRTB.Text = ("Wins: " + pWins);
                }
                else if (p.getPulse() == false) //Player Dead
                {
                    Random n = new Random(Environment.TickCount);
                    outputRTB.AppendText("\n" + c.getName() + " Wins!");
                    outputRTB.AppendText("\n" + "P Wins: " + pWins + "  C Wins: " + cWins);
                    restart();
                    //burtha.saveNetwork();
                    regenNN(ajax,playerStats);
                    cWins++;
                    cWinsRTB.Text = ("Wins: " + cWins);
                }
                else
                {
                    //Computer Decides what to do
                    //c.setstate(brain.choice(p.getHP(), p.getPotions())
                    //call p.TakeTurn(c)
                    p.takeTurn(c, outputRTB);
                    //Call c.TakeTurn(p)
                    c.takeTurn(p, outputRTB);
                    //call p.EndTurn()
                    p.endTurn(playerStatsRTB, outputRTB, playerProgress);
                    //call c.EndTurn(p)
                    c.endTurn(compStatRTB, outputRTB, ComputerProgress);
                }
                outputRTB.SelectionStart = outputRTB.Text.Length;
                outputRTB.ScrollToCaret();
            }

        }
        private Double getNextRand(double x, double y)
        {
            Random rnd = new Random(Environment.TickCount);
            double next = rnd.NextDouble();
            //Console.WriteLine(next);
            return x + (next * (y - x));
        }
        private void regenNN(NeuralNetwork n, List<Double> input)
        {
            List<Double> output = new List<Double>();
            Double change;
            change = getNextRand(0, 1);
            output.Add(change);
            change = getNextRand(0, 1);
            output.Add(change);
            change = getNextRand(0, 1);
            output.Add(change);
            burtha.Train(input, output);
        }
        private char randomChar()
        {
            Random rnd = new Random(Environment.TickCount);
            int d = rnd.Next(0, 3);
            //Console.WriteLine(d);
            if (d == 0){
                return 'h';
            }else if (d == 1){
                return 'b';
            }else{
                return 'a';
            }
        }

        private void saveAndCloseBTN_Click(object sender, EventArgs e)
        {
            ajax.saveNetwork();
            burtha.saveNetwork();
            this.Close();
        }
    }
}
