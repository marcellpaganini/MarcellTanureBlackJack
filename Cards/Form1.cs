using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer;
using System.Media;

namespace Cards
{
    public partial class Form1 : Form
    {
        private Deck aDeck;
        private Hand hand1;
        private Hand hand2;
        private SoundPlayer win;
        private SoundPlayer lose;
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.background;
            InitializeComponent();
            win = new SoundPlayer("win.wav");
            lose = new SoundPlayer("fail.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUp();
        }

        private void SetUp()
        {
            try
            {
                aDeck = new Deck();
                aDeck.Shuffle();

                hand1 = aDeck.DealHand(2);

                int firstValue = ((int)hand1.cards[0].FaceValue + 1);

                if (firstValue > 10)
                {
                    firstValue = 10;
                }

                tboScoreDealer.Text = firstValue.ToString();

                hand2 = aDeck.DealHand(2);
                tboScorePlayer.Text = HandSum(hand2).ToString();
                ShowHandDealer(Panel1, hand1);
                ShowHand(Panel2, hand2);

                if (HandSum(hand2) == 21)
                {
                    win.Play();
                    MessageBox.Show("Blackjack!", "You win!");
                    AskToRestart();
                }

                btnHit.Enabled = true;
                btnStand.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ShowHand(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();
            Card aCard;
            PictureBox aPic;

            for (int i = theHand.Count - 1; i >= 0; i--)
            {
                aCard = theHand[i];
                string path = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";
               
                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 70,
                    Height = 100,
                    Left = 15 * i,
                    Tag = aCard
                };

                // aPic.Click += PictureBox_Click;

                thePanel.Controls.Add(aPic);
            }
        }

        private void ShowHandDealer(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();
            Card aCard;
            PictureBox aPic;
            string path;

            for (int i = theHand.Count - 1; i >= 0; i--)
            {
                aCard = theHand[i];

                if (i == 0)
                {
                    path = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";
                }

                else
                {
                    path = @"images\cardback.gif";
                }

                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 70,
                    Height = 100,
                    Left = 15 * i,
                    Tag = aCard
                };

                // aPic.Click += PictureBox_Click;

                thePanel.Controls.Add(aPic);
            }
        }

        /*private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picClicked = (PictureBox)sender;
            int cardPos = Panel1.Controls.IndexOf(picClicked);
            if (cardPos != -1)
            {
                hand1.RemoveCard((Card)picClicked.Tag);
                ShowHand(Panel1, hand1);
            }
            else
            {
                hand2.RemoveCard((Card)picClicked.Tag);
                ShowHand(Panel2, hand2);
            }
        }*/

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetUp();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            hand2.AddCard(aDeck.DealCard());
            ShowHand(Panel2, hand2);
            tboScorePlayer.Text = HandSum(hand2).ToString();

            if (HandSum(hand2) > 21)
            {
                lose.Play();
                MessageBox.Show("You're bust!", "You lose");
                AskToRestart();
            }

            else if (HandSum(hand2) == 21)
            {
                win.Play();
                MessageBox.Show("Blackjack!", "You win");             
                AskToRestart();
            }
        }

        private int HandSum(Hand hand)
        {
            int handValue = 0;
            foreach (Card card in hand.cards)
            {
                int value = (int)card.FaceValue + 1;

                if (value > 10)
                {
                    value = 10;
                }

                if (value == 1)
                {
                    if (handValue + 11 <= 21)
                    {
                        value = 11;
                    }

                    else
                    {
                        value = 1;
                    }
                }
                
                handValue += value;
            }

            return handValue;
        }

        private void AskToRestart()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to restart?", "Restart", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SetUp();
            }

            else
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            ShowHand(Panel1, hand1);
            tboScoreDealer.Text = HandSum(hand1).ToString();
            Refresh();
            Thread.Sleep(1000);

            while (true)
            {
                if (HandSum(hand1) >= HandSum(hand2) || HandSum(hand1) >= 17)
                {
                    break;
                }

                hand1.AddCard(aDeck.DealCard());
                ShowHand(Panel1, hand1);
                tboScoreDealer.Text = HandSum(hand1).ToString();

                Refresh();
                Thread.Sleep(1000);
            }

            if (HandSum(hand1) == 21)
            {
                lose.Play();
                MessageBox.Show("Dealer has blackjack!", "You lose");
                AskToRestart();
            }

            else if (HandSum(hand1) > 21)
            {
                win.Play();
                MessageBox.Show("Dealer's bust!", "You win");
                AskToRestart();
            }

            else
            {
                if (HandSum(hand1) == HandSum(hand2))
                {
                    lose.Play();
                    MessageBox.Show("Dealer wins ties!", "You lose");
                }

                else if (HandSum(hand1) > HandSum(hand2))
                {
                    lose.Play();
                    MessageBox.Show("Dealer is higher!", "You lose");
                    
                }

                else
                {
                    win.Play();
                    MessageBox.Show("Dealer is lower!", "You win");
                }
                AskToRestart();
            }
        }
    }
}
