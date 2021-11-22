using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form3 : Form
    {
        private GameController game;
        public Form3(GameController game)
        {

            InitializeComponent();
            this.game = game;
            this.game.getPlayer(0).selected();
            this.onChange();
            if(game.getNumberOfPlayes() == 2)
            {
                panel2.Enabled = false;
                panel4.Enabled = false;
            }
            if (game.getNumberOfPlayes() == 3)
            {
                panel4.Enabled = false;
            }
            //avatar
            avatar1.ImageLocation = this.game.getPlayer(0).getAvatar();
            avatar2.ImageLocation = this.game.getPlayer(1).getAvatar();
            if(this.game.checkIndex(2)) avatar3.ImageLocation = this.game.getPlayer(2).getAvatar();
            if(this.game.checkIndex(3)) avatar4.ImageLocation = this.game.getPlayer(3).getAvatar();
        }
        public void onChange()
        {
            panel1.BackColor = this.game.getPlayer(0).getColor();
            panel3.BackColor = this.game.getPlayer(1).getColor();
            if(this.game.checkIndex(2)) panel2.BackColor = this.game.getPlayer(2).getColor();
            if (this.game.checkIndex(3)) panel4.BackColor = this.game.getPlayer(3).getColor();

            //Names
            lblPlayer1.Text = this.game.getPlayer(0).getName();
            lblPlayer2.Text = this.game.getPlayer(1).getName();
            if(this.game.checkIndex(2))lblPlayer3.Text = this.game.getPlayer(2).getName();
            if (this.game.checkIndex(3)) lblPlayer4.Text = this.game.getPlayer(3).getName();

            //points
            player1Points.Text = this.game.getPlayer(0).getPoints().ToString();
            player2Points.Text = this.game.getPlayer(1).getPoints().ToString();
            if(this.game.checkIndex(2))player3Points.Text = this.game.getPlayer(2).getPoints().ToString();
            if (this.game.checkIndex(3)) player4Points.Text = this.game.getPlayer(3).getPoints().ToString();
            //Banks
            player1Bank.Text = this.game.getPlayer(0).getBank().ToString();
            player2Bank.Text = this.game.getPlayer(1).getBank().ToString();
            if(this.game.checkIndex(2))player3Bank.Text = this.game.getPlayer(2).getBank().ToString();
            if (this.game.checkIndex(3)) player4Bank.Text = this.game.getPlayer(3).getBank().ToString();
            

        }

        private void lblPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Boolean playing = this.game.RollDice();
            this.onChange();
            if (!playing)
            {
                this.Close();
                MessageBox.Show(this.game.getWinner().getName(), "GameOver");
                this.onChange();

            }
        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void player3Points_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
