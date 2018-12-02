using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Duel
{
    class Player
    {
        private string name;
        private int hp;
        private int potions;
        private Boolean pulse;
        private char state;
        private Random r = new Random();
        //private readonly object sync = new object();

        public Player(string id)
        {
            this.name = id;
            this.hp = 25;
            this.potions = 3;
            this.pulse = true;
        }
        public void takeTurn(Player comp, RichTextBox output )
        {
            //Check State and take turn accordingly
            switch(state)
            {
                //Attack()
                case 'a':
                    attack(comp, output);
                    break;
                //Block()
                case 'b':
                    output.AppendText(name + " Blocking with a Spiked shield" + "\n");
                    break;
                //Heal()
                case 'h':
                    recklessAttack(comp, output);
                    break;
                default:
                    //Change to set to output box
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        private void attack(Player comp, RichTextBox output)
        {
            //Check to see if player has blocked
            int atk;
            r = new Random((int) DateTime.Now.Ticks & 0x0000FFFF);
            atk = r.Next(2,6);
            Thread.Sleep(10);
            
            if(comp.getState() == 'b')
            {
                //FIX THE BLOCK LOOP PROBLEM
                comp.takeDamage(atk/2);
                this.takeDamage(1);
                output.AppendText(this.getName() + " attacks for: " + atk / 2 + "\n");
            }
            //Change Players HP down by a large random
            else
            {
                comp.takeDamage(atk);
                output.AppendText(this.getName() + " attacks for: " + atk + "\n");
            }
        }
        private void recklessAttack(Player comp, RichTextBox output)
        {
            //Check to see if player has blocked
            int atk;
            r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            atk = r.Next(4, 10);
            Thread.Sleep(10);

            if (comp.getState() == 'b')
            {
                //FIX THE BLOCK LOOP PROBLEM
                comp.takeDamage(atk/2);
                this.takeDamage(4);
                output.AppendText(this.getName()+" attacks for: " + atk / 2 + "\n");
            }
            //Change Players HP down by a large random
            else
            {
                comp.takeDamage(atk);
                output.AppendText(this.getName() + " attacks for: " + atk + "\n");
            }
        }
        /*
        private void heal(RichTextBox output)
        {
            int heal = 4;
            //Check if potions left
            if (potions > 0)
            {
                // += hp by small random
                //decrement potions
                hp += heal;
                potions -= 1;
                output.AppendText(getName() + " heals for " + heal + " health" + "\n");
            }
            else
            {
                output.AppendText( "Oh no " + getName() +  " is out of potions, Wastes a turn" + "\n");
            }   
        }
        */
        public void endTurn(RichTextBox pStats, RichTextBox output)
        {
            state = ' ';
            updateStats(pStats);
            if (hp <= 0)
            {
                this.pulse = false;
            }
        }
        
        private void updateStats(RichTextBox pStats)
        {
            pStats.Text = "HP: " + this.hp + "\n";// + "Potions: " + this.potions;
        }
        public void takeDamage(int atk)
        {
            this.hp -= atk;
        }
        //getter and setter methods
        public int getHP()
        {
            return this.hp;
        }
        public int getPotions()
        {
            return this.potions;
        }
        public char getState()
        {
            return this.state;
        }
        
        public string getName()
        {
            return this.name;
        }
        public void setState(char input)
        {
            this.state = input;
        }
        public Boolean getPulse()
        {
            return this.pulse;
        }
        
    }
}
