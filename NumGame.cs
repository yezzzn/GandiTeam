using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Gandi
{
    public partial class NumGame : Form
    {
        int totalScore = 0; // 점수 
        int count = 1; // 순서 확인할 수

        int remainingSeconds;


        Random random;




        // 초기화면
        public NumGame()
        {
            InitializeComponent();


            /// 라벨 - 픽쳐박스 배경 투명하게

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(20, 25);

            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 25);

            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(20, 25);

            label4.Parent = pictureBox4;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(20, 25);

            label5.Parent = pictureBox5;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(20, 25);

            label6.Parent = pictureBox6;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(20, 25);

            label7.Parent = pictureBox7;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(20, 25);

            label8.Parent = pictureBox8;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(20, 25);

            label9.Parent = pictureBox9;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(20, 25);

            label10.Parent = pictureBox10;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(20, 25);

            label11.Parent = pictureBox11;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(20, 25);

            label12.Parent = pictureBox12;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(20, 25);

            label13.Parent = pictureBox13;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(20, 25);

            label14.Parent = pictureBox14;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(20, 25);

            label15.Parent = pictureBox15;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(20, 25);

            label16.Parent = pictureBox16;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(20, 25);
            ///


            lbcnt.BackColor = Color.Transparent;



            // 눌렀을 때 픽쳐박스 안 보이게
            picNo1.Visible = false;
            picNo2.Visible = false;
            picNo3.Visible = false;
            picNo4.Visible = false;
            picNo5.Visible = false;
            picNo6.Visible = false;
            picNo7.Visible = false;
            picNo8.Visible = false;
            picNo9.Visible = false;
            picNo10.Visible = false;
            picNo11.Visible = false;
            picNo12.Visible = false;
            picNo13.Visible = false;
            picNo14.Visible = false;
            picNo15.Visible = false;
            picNo16.Visible = false;



            random = new Random();

            // 라벨 - 랜덤하게
            lbArr();

            // 라벨에 이벤트 추가
            label1.Click += label_Click;
            label2.Click += label_Click;
            label3.Click += label_Click;
            label4.Click += label_Click;
            label5.Click += label_Click;
            label6.Click += label_Click;
            label7.Click += label_Click;
            label8.Click += label_Click;
            label9.Click += label_Click;
            label10.Click += label_Click;
            label11.Click += label_Click;
            label12.Click += label_Click;
            label13.Click += label_Click;
            label14.Click += label_Click;
            label15.Click += label_Click;
            label16.Click += label_Click;

            // 값들 초기화
            score.Text = "  0"; // 점수 표시 라벨
            totalScore = 0; // 전체 점수 초기화
            proBar.Value = 0; // 프로그래스바 초기화
            lbEndScore.Visible = false; // 최종 점수 미표시

            lbcnt.Visible = true;

            timer2.Interval = 1000; // 1초마다 타이머 이벤트 발생
            timer2.Tick += timer2_Tick;

            remainingSeconds = 4;

            // 타이머추가 - 프로그래스바 이동
            timer2.Start();


        }

        // 라벨 - 랜덤으로
        void lbArr()
        {
            Random random = new Random();
            int[] arr = new int[16];

            for (int i = 0; i < 16; i++)
            {
                arr[i] = random.Next(1, 17);
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j] && j != i)
                    {
                        i = i - 1;
                    }
                }
            }

            // 라벨 텍스트값으로 랜덤한 값 넣어주기
            label1.Text = arr[0].ToString();
            label2.Text = arr[1].ToString();
            label3.Text = arr[2].ToString();
            label4.Text = arr[3].ToString();
            label5.Text = arr[4].ToString();
            label6.Text = arr[5].ToString();
            label7.Text = arr[6].ToString();
            label8.Text = arr[7].ToString();
            label9.Text = arr[8].ToString();
            label10.Text = arr[9].ToString();
            label11.Text = arr[10].ToString();
            label12.Text = arr[11].ToString();
            label13.Text = arr[12].ToString();
            label14.Text = arr[13].ToString();
            label15.Text = arr[14].ToString();
            label16.Text = arr[15].ToString();

        }

        private void Reloadf()
        {
            count = 1;
            lbArr();

            picNo1.Visible = false;
            picNo2.Visible = false;
            picNo3.Visible = false;
            picNo4.Visible = false;
            picNo5.Visible = false;
            picNo6.Visible = false;
            picNo7.Visible = false;
            picNo8.Visible = false;
            picNo9.Visible = false;
            picNo10.Visible = false;
            picNo11.Visible = false;
            picNo12.Visible = false;
            picNo13.Visible = false;
            picNo14.Visible = false;
            picNo15.Visible = false;
            picNo16.Visible = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;


            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;



        }
        // 클릭 이벤트 발생
        private void label_Click(object sender, EventArgs e)
        {

            // 클릭 이벤트가 발생한 라벨을 가져옴
            Label clickedLabel = sender as Label;

            // 라벨의 텍스트 값을 가져옴
            string labelText = clickedLabel.Text;

            // 라벨 클릭 이벤트가 발생하면
            if (clickedLabel.Enabled == true)
            {
                // 라벨 텍스트가 1인지 먼저 확인 (1부터 누르니까)
                if (labelText == "1")
                {
                    // 1이 맞으면 1 라벨 & 픽쳐박스 숨기기, 눌렸을 때 픽쳐박스 보이게 하기
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo1.Location = clickedLabel.Parent.Location;
                    picNo1.Visible = true;

                    // 맞췄을 경우 점수 +10
                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                    // 1이 눌렸으니 다음 순서는 2여야함. 


                }
                else if (labelText == "2" && count == 2)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo2.Location = clickedLabel.Parent.Location;
                    picNo2.Visible = true;


                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "3" && count == 3)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo3.Location = clickedLabel.Parent.Location;
                    picNo3.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "4" && count == 4)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo4.Location = clickedLabel.Parent.Location;
                    picNo4.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "5" && count == 5)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo5.Location = clickedLabel.Parent.Location;
                    picNo5.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "6" && count == 6)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo6.Location = clickedLabel.Parent.Location;
                    picNo6.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "7" && count == 7)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo7.Location = clickedLabel.Parent.Location;
                    picNo7.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "8" && count == 8)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo8.Location = clickedLabel.Parent.Location;
                    picNo8.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "9" && count == 9)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo9.Location = clickedLabel.Parent.Location;
                    picNo9.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "10" && count == 10)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo10.Location = clickedLabel.Parent.Location;
                    picNo10.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "11" && count == 11)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo11.Location = clickedLabel.Parent.Location;
                    picNo11.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "12" && count == 12)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo12.Location = clickedLabel.Parent.Location;
                    picNo12.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "13" && count == 13)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo13.Location = clickedLabel.Parent.Location;
                    picNo13.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "14" && count == 14)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo14.Location = clickedLabel.Parent.Location;
                    picNo14.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "15" && count == 15)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo15.Location = clickedLabel.Parent.Location;
                    picNo15.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;
                }
                else if (labelText == "16" && count == 16)
                {
                    clickedLabel.Visible = false;
                    clickedLabel.Parent.Visible = false;
                    picNo16.Location = clickedLabel.Parent.Location;
                    picNo16.Visible = true;

                    totalScore += 10;
                    score.Text = totalScore.ToString();
                    count++;


                    Reloadf();


                }
                else // 틀렸으면 -5 점
                {
                    totalScore -= 5;
                    score.Text = totalScore.ToString();

                }
            }
        }

        // 타이머 작동 이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
            EnableControls(true);
            lbcnt.Visible = false;
            proBar.Value++; // 프로그래스바 올라가게

            if (proBar.Value == 200) // 프로그래스바 끝나면
            {
                timer1.Stop(); // 타이머 멈추기

                // 최종 점수 표시
                lbEndScore.Location = new Point(58, 257);
                lbEndScore.Text = "score : " + totalScore.ToString();

                // 라벨 미표시
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;

                // 픽쳐박스 미표시
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

                // 눌렸을 때 픽쳐박스 미표시
                picNo1.Visible = false;
                picNo2.Visible = false;
                picNo3.Visible = false;
                picNo4.Visible = false;
                picNo5.Visible = false;
                picNo6.Visible = false;
                picNo7.Visible = false;
                picNo8.Visible = false;
                picNo9.Visible = false;
                picNo10.Visible = false;
                picNo11.Visible = false;
                picNo12.Visible = false;
                picNo13.Visible = false;
                picNo14.Visible = false;
                picNo15.Visible = false;
                picNo16.Visible = false;

                // 최종점수만 표시
                lbEndScore.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            EnableControls(false);
            remainingSeconds--;

            if (remainingSeconds > 0)
            {
                // 남은 시간을 라벨에 출력
                lbcnt.Text = remainingSeconds.ToString();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void EnableControls(bool enable)
        {
            // 폼의 모든 컨트롤을 활성화 또는 비활성화합니다.
            foreach (Control control in this.Controls)
            {
                control.Enabled = enable;
            }
        }

    }
}
