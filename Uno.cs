using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_of_Games
{
    public partial class Uno : Form
    {
        public static List<PictureBox> computer_Boxes = new List<PictureBox>();
        public static List<PictureBox> player_Boxes = new List<PictureBox>();
        public static List<Image> temp_List = new List<Image>();
        public static List<String> valueofCard = new List<String>();
        public static Image faceCard = null;
        public static List<bool> selections = new List<bool>();

        Player RM_player1 = new Player();

        public Uno()
        {

            InitializeComponent();
            RM_addBoxes();
            YEA_gameStart();

            while (!RM_player1.gameWon())
            {

            }

        }

        private void Uno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RM_addBoxes()
        {
            computer_Boxes.Add(Comp_Box1);
            computer_Boxes.Add(Comp_Box2);
            computer_Boxes.Add(Comp_Box3);
            computer_Boxes.Add(Comp_Box4);
            computer_Boxes.Add(Comp_Box5);
            computer_Boxes.Add(Comp_Box6);
            computer_Boxes.Add(Comp_Box7);

            player_Boxes.Add(Player_Box1);
            player_Boxes.Add(Player_Box2);
            player_Boxes.Add(Player_Box3);
            player_Boxes.Add(Player_Box4);
            player_Boxes.Add(Player_Box5);
            player_Boxes.Add(Player_Box6);
            player_Boxes.Add(Player_Box7);

        }
        //10 = +2
        //11 = reverse
        //12 = skip
        //13 = wild color
        //14 = +4
        private void YEA_gameStart()
        {
            Random rand = new Random();
            for (int i = 0; i < computer_Boxes.Count; i++)
            {
                //get random image for the computer
                int x = rand.Next(Uno_Cards.Images.Count);
                computer_Boxes[i].Image = Uno_Cards.Images[x];
                temp_List.Add(Uno_Cards.Images[x]);
                Uno_Cards.Images.RemoveAt(x);

                //get random card for the player
                int y = rand.Next(Uno_Cards.Images.Count);
                player_Boxes[i].Image = Uno_Cards.Images[y];
                temp_List.Add(Uno_Cards.Images[y]);
                Uno_Cards.Images.RemoveAt(y);

            }
            int next = rand.Next(Uno_Cards.Images.Count);
            Middle_Box.Image = Uno_Cards.Images[(next)];
            faceCard = Uno_Cards.Images[(next)];
            temp_List.Add(Uno_Cards.Images[next]);
            Uno_Cards.Images.RemoveAt(next);
        }

        private void Player_Box1_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box1, 1);
        }

        private void Player_Box2_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box2, 2);
        }

        private void Player_Box3_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box3, 3);
        }

        private void Player_Box4_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box4, 4);
        }

        private void Player_Box5_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box5, 5);
        }

        private void Player_Box6_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box6, 6);
        }

        private void Player_Box7_Click(object sender, EventArgs e)
        {
            checkClick(Player_Box7, 7);
        }

        private void Uno_Load_1(object sender, EventArgs e)
        {

        }

        private void checkClick(PictureBox x, int y)
        {
            if(x.BorderStyle == BorderStyle.FixedSingle)
            {
                x.BorderStyle = BorderStyle.None;
                selections[y] = false;
            }
            else
            {
                x.BorderStyle = BorderStyle.FixedSingle;
                selections[y] = true;
            }
        }

        
    }
}
