using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Gandi
{
    public partial class NumForm : Form
    {
        private List<Label> labels;
        private int currentLabelIndex;
        int totalScore = 0;
        const int count = 0;

        Random random;
        // 초기화면
        public NumForm()
        {
            InitializeComponent();


            /// 라벨 - 픽쳐박스 배경 투명하게

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(35, 30);

            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(35, 30);

            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(35, 30);

            label4.Parent = pictureBox4;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(35, 30);

            label5.Parent = pictureBox5;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(35, 30);

            label6.Parent = pictureBox6;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(35, 30);

            label7.Parent = pictureBox7;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(35, 30);

            label8.Parent = pictureBox8;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(35, 30);

            label9.Parent = pictureBox9;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(35, 30);

            label10.Parent = pictureBox10;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(30, 30);

            label11.Parent = pictureBox11;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(30, 30);

            label12.Parent = pictureBox12;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(30, 30);

            label13.Parent = pictureBox13;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(30, 30);

            label14.Parent = pictureBox14;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(30, 30);

            label15.Parent = pictureBox15;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(30, 30);

            label16.Parent = pictureBox16;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(30, 30);
            ///
            
            random = new Random();

            // 라벨 - 랜덤하게
            lbArr();


            //    labels = new List<Label>
            //{
            //    label1, label2, label3, label4, label5, label6,
            //    label7, label8, label9, label10, label11, label12,
            //    label13, label14, label15, label16
            //};

            // 라벨에 클릭 이벤트 연결해주기
            //currentLabelIndex = 0;
            //labels[currentLabelIndex].Click += label_Click;

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
            score.Text = "";
            picNo.Visible = false;
            totalScore = 0;
        }


        private void InitializeRandomNumbers()
        {
            List<int> numbers = Enumerable.Range(1, 16).ToList();
            for (int i = 0; i < 16; i++)
            {
                int randomIndex = random.Next(0, 16);
                int randomNumber = numbers[randomIndex];
                labels[i].Text = randomNumber.ToString();
                numbers.RemoveAt(randomIndex);
            }
        }

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



        private void label_Click(object sender, EventArgs e)
        {
            List<Label> lab = new List<Label> { };

            // 클릭 이벤트가 발생한 라벨을 가져옵니다.
            Label clickedLabel = sender as Label;

            // 라벨의 텍스트 값을 가져옵니다.
            string labelText = clickedLabel.Text;

            // 텍스트 값이 "1"인지 확인합니다.+
            

            if (labelText == "1")
            {
                // 텍스트 값이 "1"이면 원하는 동작을 수행합니다.
                clickedLabel.Visible = false;
                clickedLabel.Parent.Visible = false;

                picNo.Location = clickedLabel.Parent.Location;
                picNo.Visible = true;

                totalScore += 10;
                score.Text = totalScore.ToString();
                //lab.Add(clickedLabel);
                
                

            }
            
            else if(labelText == "2" && count == 2) 
            {
                clickedLabel.Visible = false;
                clickedLabel.Parent.Visible = false;

                picNo.Location = clickedLabel.Parent.Location;
                picNo.Visible = true;

                totalScore += 10;   
                score.Text = totalScore.ToString();

            }

            //else
            //{
            //    // 텍스트 값이 "1"이 아니면 원하는 동작을 수행합니다.
            //    totalScore -= 5;
            //    score.Text = totalScore.ToString();
            //}
        }


    }
}
