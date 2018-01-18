using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDogs
{
    class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = name + "ma " + cash + "zl";
            if (myBet == null)
            {
                MyLabel.Text = name;
            }
            else
            {
                MyLabel.Text = name + "stawia " + myBet.amount + " zl na charta numer " + myBet.dog;
            }
            

        }
        public void ClearBet()
        {
            myBet = null;
            //todo
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount > this.cash)
            {
                return false;
            }
            else
            {
                myBet = new Bet() { amount = Amount, dog = Dog, bettor = this };
                UpdateLabels();

                    
                return true; //todo
            }
            
        }
        public void Collect(int Winner)
        {
            cash += myBet.PayOut(Winner);

            ClearBet();
        
        }

    }
}
