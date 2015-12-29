using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postero.KingOfNumbers.View.WinForms
{
    public partial class frmMain : Form
    {
        private int currentPlayer;
        private int from;
        private Model.Player player1;
        private Model.Player player2;

        public frmMain()
        {
            InitializeComponent();
            player1 = new Model.Player("João");
            player2 = new Model.Player("Caetano");

            currentPlayer = 1;

            lbl1Name.Text = player1.Name;
            lbl2Name.Text = player2.Name;

            Update();
        }

        private void Update()
        {
            if ((player1.LeftHand.Dead && player1.RightHand.Dead))
            {
                MessageBox.Show("O " + player2.Name + " venceu.");
                Application.Restart();
            }
            else if (player2.LeftHand.Dead && player2.RightHand.Dead)
            {
                MessageBox.Show("O "+player1.Name+" venceu.");
                Application.Restart();
            }
            else
            {
                currentPlayer = currentPlayer == 2 ? 1 : 2;
                if (!player1.LeftHand.Dead)
                {
                    lblValue1Left.Text = player1.LeftHand.UsedFingers.ToString();
                }
                else
                    lblValue1Left.Enabled = false;
                if (!player1.RightHand.Dead)
                {
                    lblValue1Right.Text = player1.RightHand.UsedFingers.ToString();
                }
                else
                    lblValue1Right.Enabled = false;
                if (!player2.LeftHand.Dead)
                {
                    lblValue2Left.Text = player2.LeftHand.UsedFingers.ToString();
                }
                else
                    lblValue2Left.Enabled = false;
                if (!player2.RightHand.Dead)
                {
                    lblValue2Right.Text = player2.RightHand.UsedFingers.ToString();
                }
                else
                    lblValue2Right.Enabled = false;
                lbl1Left.ForeColor = Color.Black;
                lbl2Left.ForeColor = Color.Black;
                lbl1Right.ForeColor = Color.Black;
                lbl2Right.ForeColor = Color.Black;
                if (currentPlayer == 1)
                {
                    lbl1Name.ForeColor = Color.Green;
                    lbl2Name.ForeColor = Color.Black;
                }
                else
                {
                    lbl2Name.ForeColor = Color.Green;
                    lbl1Name.ForeColor = Color.Black;
                }
            }
        }

        private void lblValue1Right_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (currentPlayer == 2)
            {
                success = player2.Hit(player1, from, 2);
            }
            else
            {
                if (player1.Split(2))
                {
                    lblValue1Left.Enabled = true;
                    success = true;
                }
            }
            if (success) Update();
        }

        private void lblValue1Left_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (currentPlayer == 2)
            {
                success = player2.Hit(player1, from, 1);
            }
            else
            {
                if (player1.Split(1))
                {
                    lblValue2Right.Enabled = true;
                    success = true;
                }
            }
            if (success) Update();
        }

        private void lblValue2Left_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (currentPlayer == 1)
            {
                success = player1.Hit(player2, from, 1);
            }
            else
            {
                if (player2.Split(1))
                {
                    lblValue2Right.Enabled = true;
                    success = true;
                }
            }
            if (success) Update();
        }

        private void lblValue2Right_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (currentPlayer == 1)
            {
                success = player1.Hit(player2, from, 2);
            }
            else
            {
                if (player2.Split(2))
                {
                    lblValue2Left.Enabled = true;
                    success = true;
                }

            }
            if (success) Update();
        }

        private void lbl1Right_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                from = 2;
                lbl1Right.ForeColor = Color.Red;
            }
        }

        private void lbl1Left_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                from = 1;
                lbl1Left.ForeColor = Color.Red;
            }
        }

        private void lbl2Left_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 2)
            {
                from = 1;
                lbl2Left.ForeColor = Color.Red;
            }
        }

        private void lbl2Right_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 2)
            {
                from = 2;
                lbl2Right.ForeColor = Color.Red;
            }
        }
    }
}
