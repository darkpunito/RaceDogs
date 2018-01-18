using RaceDogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDogs
{
    public partial class Form1 : Form
    {
        Guy[] guys;

        Dog[] dogs;
       
        public Form1()
        {
           

            
            InitializeComponent();
            guys = new Guy[3];
            guys[0] = new Guy();
            guys[1] = new Guy();
            guys[2] = new Guy();
            dogs = new Dog[4];
            dogs[0] = new Dog();
            dogs[1] = new Dog();
            dogs[2] = new Dog();
            dogs[3] = new Dog();
            guys[0].MyRadioButton = radioButton1;
            guys[1].MyRadioButton = radioButton2;
            guys[2].MyRadioButton = radioButton3;
            guys[0].name = "Janek";
            guys[1].name = "Bartek";
            guys[2].name = "Antek";
            guys[0].MyLabel = label1;
            guys[1].MyLabel = label2;
            guys[2].MyLabel = label3;
            guys[0].cash = 100;
            guys[1].cash = 123;
            guys[2].cash = 546;
            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }

      
        private void Bet_Click(object sender, EventArgs e)
        {
            RadioButton ctrl = new RadioButton();
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked == true)
                    ctrl = rb;
            }
            int whichguy = groupBox1.Controls.IndexOf(ctrl);
            //MessageBox.Show(whichguy.ToString());
            guys[whichguy].PlaceBet((int)amountBet.Value, (int)dogBet.Value);
        }
    }
}
