using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public enum ScoreItems
    {
        Dummy, Aces, Twos, Threea, Fours, Five, Sixes, SubTotalUpper, Bouns, TotalUpper
    }
    public partial class Form1 : Form
    {
        Die[] dieArray = new Die[6];
        ScoreSheet scoreSheet;
        PictureBox[] picArray = new PictureBox[6];
        CheckBox[] chkArray = new CheckBox[6];
        List<PictureBox> picBoxArrayList = new List<PictureBox>();
        int rolls = 1;
       
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 6; i++)
            {
                dieArray[i] = new Die(6);
            }

            picBoxArrayList.Add(picDie1);
            picBoxArrayList.Add(picDie2);
            picBoxArrayList.Add(picDie3);
            picBoxArrayList.Add(picDie4);
            picBoxArrayList.Add(picDie5);



            picArray[1] = picDie1;
            picArray[2] = picDie2;
            picArray[3] = picDie3;
            picArray[4] = picDie4;
            picArray[5] = picDie5;

            chkArray[1] = checkBox1;
            chkArray[2] = checkBox2;
            chkArray[3] = checkBox3;
            chkArray[4] = checkBox4;
            chkArray[5] = checkBox5;
            scoreSheet = new ScoreSheet(dieArray);         

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
           
            rolls++;
            lblRoll.Text = "Roll #:" + rolls.ToString();
            ArrayList arrayDie1 = new ArrayList();
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.SIde_One_Dice);
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.Side_Two_Dice);
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.Side_Three_Dice);
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.Side_Four_Dice);
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.SIde_One_Dice);
            arrayDie1.Add(this.picDie1.Image = global::Yahtzee.Properties.Resources.SIde_One_Dice);

            for (int i = 1; i < 6; i++)
            {
                int value = 0;
                if (!(chkArray[i].Checked))
                {
                    value = dieArray[i].roll();
                }
                //picArray[i]
                if (value == 1)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.SIde_One_Dice;

                }
                if (value == 2)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Two_Dice;

                }
                if (value == 3)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Three_Dice;

                }
                if (value == 4)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Four_Dice;

                }
                if (value == 5)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Five_Dice;

                }
                if (value == 6)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Six_Dice;

                }
            }
            if (rolls == 3)
            {
                btnRoll.Enabled = false;
            }
            scoreSheet.updateScoreSheet();
            //label1.Text = scoreSheet.possibleScores[(int)ScoreItems.Aces].ToString();
            //label2.Text = scoreSheet.possibleScores[(int)ScoreItems.Twos].ToString();
            Score(label1, ScoreItems.Aces);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strArray = new string[7];
            strArray[1] =  "SIde_One_Dice";
            strArray[2] =  "Side_Two_Dice";
            strArray[3] =  "Side_Three_Dice";
            strArray[4] =  "Side_Four_Dice";
            strArray[5] =  "Side_Five_Dice";
            strArray[6] =  "Side_Six_Dice";
           
            int value = 0;
            for (int i = 1; i < 6; i++)
            {
                
                if (!(chkArray[i].Checked))
                {
                    value = dieArray[i].roll();
                }
                //picArray[i]
              /* if (value == 1)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.SIde_One_Dice;

                }
                if (value == 2)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Two_Dice;

                }
                if (value == 3)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Three_Dice;

                }
                if (value == 4)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Four_Dice;

                }
                if (value == 5)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Five_Dice;

                }
                if (value == 6)
                {
                    this.picArray[i].Image = global::Yahtzee.Properties.Resources.Side_Six_Dice;

                }*/
              
                
            }

            
                
            if (value !=0 && value <= 5)
            {
                    
                picBoxArrayList[value].Image = (Image)global::Yahtzee.Properties.Resources.ResourceManager.GetObject(strArray[Math.Abs(value)]);
                /*Console.WriteLine(picBoxArrayList[0].Name);
                Console.WriteLine(picBoxArrayList[1].Name);
                Console.WriteLine(picBoxArrayList[2].Name);
                Console.WriteLine(picBoxArrayList[3].Name);
                Console.WriteLine(picBoxArrayList[4].Name);*/
                    

            }
            
         

        }

        private void Score(Label label, ScoreItems scoreItems)
        {
            label.Text = scoreSheet.possibleScores[(int)scoreItems].ToString();
        }

    
    }
}
