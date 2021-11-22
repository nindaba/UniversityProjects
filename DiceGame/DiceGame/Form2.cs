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
    public partial class Form2 : Form
    {
        private GameController gameController;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chooseAvater1(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/1.jpg";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfRounds = Int32.Parse(this.txtRounds.Text);
            int numberOfPlayers = Int32.Parse(this.txtNumbOfPlayers.Text);
            Boolean valid=true;
            if (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                valid = false;
                MessageBox.Show("Number of players must be  more than two and less than 4", "Error");
            }
            if (numberOfRounds < 5 || numberOfRounds > 30)
            {
                valid = false;
                MessageBox.Show("Number of rounds must be  more than 5 and less than 30", "Error");
            }

            this.gameController = new GameController(
               numberOfRounds,
               numberOfPlayers);

            gameController.setPlayer(new Player(0, this.playerOneName.Text, this.playerOneAvatar.ImageLocation));
            gameController.setPlayer(new Player(1, this.playerTwoName.Text, this.playerTwoAvatar.ImageLocation));
            if(this.gameController.checkIndex(2)) gameController.setPlayer(new Player(2, this.playerThreeName.Text, this.playerThreeAvatar.ImageLocation));
            if (this.gameController.checkIndex(3)) gameController.setPlayer(new Player(3, this.playerFourName.Text, this.playerFourAvatar.ImageLocation));
            if (valid) new Form3(this.gameController).ShowDialog();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/2.jpg";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/3.jpg";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/4.jpg";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/5.jpg";
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.playerOneAvatar.ImageLocation = "Avatars/6.jpg";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/1.jpg";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/2.jpg";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/3.jpg";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/4.jpg";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/5.jpg";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.playerTwoAvatar.ImageLocation = "Avatars/6.jpg";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/1.jpg";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/2.jpg";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/3.jpg";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/4.jpg";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/5.jpg";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.playerThreeAvatar.ImageLocation = "Avatars/6.jpg";
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/1.jpg";
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/2.jpg";
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/3.jpg";
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/4.jpg";
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/5.jpg";
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.playerFourAvatar.ImageLocation = "Avatars/6.jpg";
        }
    }
}
