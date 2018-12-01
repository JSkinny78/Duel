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
        //initialize player
        Player p = new Player("Player");
        //initialize computer
        Player c = new Player("Computer");
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
            p.setState(brain1.Action(playerStats));
            string pstat = string.Join(", ", playerStats.ToArray());
            //Computer Stats
            List<double> computerStats = new List<Double>();
            computerStats.Add(Convert.ToDouble(c.getHP()));
            computerStats.Add(Convert.ToDouble(c.getPotions()));
            computerStats.Add(Convert.ToDouble(p.getHP()));
            computerStats.Add(Convert.ToDouble(p.getPotions()));
            c.setState(brain2.Action(playerStats));
            string cstat = string.Join(", ", computerStats.ToArray());
            outputRTB.AppendText(pstat + "\n" + cstat + "\n");

            //Check if players alive
            if (p.getPulse() == false && c.getPulse() == false)
            {
                outputRTB.AppendText("\n" + "Tie!" + "\n" + "Thank you for playing");
            }
            else if(c.getPulse() == false)
            {
                outputRTB.AppendText("\n" + p.getName() + " Wins!" + "\n" + "Thank you for playing");
                outputRTB.AppendText("Game Restarting");
                restart();
                Random n = new Random(Environment.TickCount);
                brain1 = new NeuralNetwork(15, new int[] { 4, 4, 3 },0);
            }
            else if (p.getPulse() == false)
            {
                Random n = new Random(Environment.TickCount);
                outputRTB.AppendText("\n" + c.getName() + " Wins!" + "\n" + "Thank you for playing");
                outputRTB.AppendText("Game Restarting");
                restart();
                brain2 = new NeuralNetwork(15, new int[] { 4, 4, 3 },0);
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
                p.endTurn(playerStatsRTB, outputRTB);
                //call c.EndTurn(p)
                c.endTurn(compStatRTB, outputRTB);
            }
            outputRTB.SelectionStart = outputRTB.Text.Length;
            outputRTB.ScrollToCaret();
        }

        private void restart(){
            p = new Player("Player");
            c = new Player("Computer");
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
    }
}
