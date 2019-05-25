using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ThreeManBlueMarble
{
    public partial class SinglePlayForm : Form
    {
        int user1;
        int user2;
        int user3;

        bool turnFlag = false;

        int userturn = 1; // 유저 턴

        int user1position = 1; // 유저의 도착위치
        int userTmpposition = 1; // 유저의 출발위치

        int lastposition = 24;

        int goup;
        int godown;
        int goleft;
        int goright;


        int x, y; // 픽쳐박스의 위치
        Point p; // 포인트 객체

        int DiceNum; // 주사위 변수

        public static Random rnd = new Random();

        public SinglePlayForm()
        {
            InitializeComponent();
            x = Player1.Location.X;
            y = Player1.Location.Y;

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            userTmpposition = user1position;
            user1position += (DiceNum);





            // 말 움직임 실행

            for (int i = userTmpposition; i < user1position; i++)
            {
                if (i < 7) // goup
                {
                    y = y - 101;
                    p = new Point(x, y);
                    Player1.Location = p;
                }
                else if (i < 13) // goright
                {
                    x = x + 120;
                    p = new Point(x, y);
                    Player1.Location = p;
                }
                else if (i < 19) // godown
                {
                    y = y + 101;
                    p = new Point(x, y);
                    Player1.Location = p;
                }
                else if (i < 25) // goleft
                {
                    x = x - 120;
                    p = new Point(x, y);
                    Player1.Location = p;
                }
                else
                {
                    i = 0;
                    user1position = user1position - lastposition;
                    userTmpposition = user1position;
                }
                Thread.Sleep(50);
            }

            // 테스트용 라벨
            label1.Text = user1position.ToString();
            label2.Text = DiceNum.ToString();
            turnFlag = true;
            timer1.Stop();








        }

        private void DiceRoll(object sender, EventArgs e)
        {
            DiceNum = rnd.Next(1, 7);
            if (DiceNum == 1)
            {
                DIceBox.Image = Properties.Resources.Dice1;
            }
            if (DiceNum == 2)
            {
                DIceBox.Image = Properties.Resources.Dice2;
            }
            if (DiceNum == 3)
            {
                DIceBox.Image = Properties.Resources.Dice3;
            }
            if (DiceNum == 4)
            {
                DIceBox.Image = Properties.Resources.Dice4;
            }
            if (DiceNum == 5)
            {
                DIceBox.Image = Properties.Resources.Dice5;
            }
            if (DiceNum == 6)
            {
                DIceBox.Image = Properties.Resources.Dice6;
            }
        }

        public void TrunChange()
        {
            userturn++;
            if (userturn == 4)
                userturn = 1;
        }

        private void StopBtn_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
