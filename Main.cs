using Gandi;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moble
{
    public partial class Main : Form
    {

        List<St> ids = new List<St>();

        public struct St
        {
            public string id;
            public int score;
        }

        NumGame numGame;

        public Main()
        {
            InitializeComponent();

            
            ids.Add(new St()); // Add at least one object to the "ids" list
            int count = 0;

            textID.Text = "";

        }
        //각 게임 연결버튼
        private void btn_Pi_Click(object sender, EventArgs e)
        {

        }

        private void btn_The_Click(object sender, EventArgs e)
        {

        }

        private void btn_Soon_Click(object sender, EventArgs e)
        {
            //버튼을 클릭하면 폼2를 연다.
            NumGame form2 = new NumGame();
            //폼 2에 이벤트를 달아둔다..
            form2.FormSendEvent += new NumGame.FormSendDataHandler(DieaseUpdateEventMethod);
            form2.ShowDialog();

        }
        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            label4.Text = sender.ToString();
        }
        public void SetText(string data)
        {
            label4.Text = data;
        }

        private void btn_Joa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Same_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bang_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ga_Click(object sender, EventArgs e)
        {
            RSPGame rspGame = new RSPGame();
            rspGame.Show();
        }

        private void btn_Ja_Click(object sender, EventArgs e)
        {

        }

        //각 게임 좋아요 개수
        private void btn_PiLike_Click(object sender, EventArgs e)
        {
            lb_PiLike.Text = (int.Parse(lb_PiLike.Text) + 1).ToString();
        }
        private void btn_TheLike_Click(object sender, EventArgs e)
        {
            lb_TheLike.Text = (int.Parse(lb_TheLike.Text) + 1).ToString();
        }
        private void btn_SoonLike_Click(object sender, EventArgs e)
        {
            lb_SoonLike.Text = (int.Parse(lb_SoonLike.Text) + 1).ToString();
        }
        private void btn_JoaLike_Click(object sender, EventArgs e)
        {
            lb_JoaLike.Text = (int.Parse(lb_JoaLike.Text) + 1).ToString();
        }
        private void btn_SameLike_Click(object sender, EventArgs e)
        {
            lb_SameLike.Text = (int.Parse(lb_SameLike.Text) + 1).ToString();
        }
        private void btn_BangLike_Click(object sender, EventArgs e)
        {
            lb_BangLike.Text = (int.Parse(lb_BangLike.Text) + 1).ToString();
        }
        private void btn_BuLike_Click(object sender, EventArgs e)
        {
            lb_BuLike.Text = (int.Parse(lb_BuLike.Text) + 1).ToString();
        }
        private void btn_GaLike_Click(object sender, EventArgs e)
        {
            lb_GaLike.Text = (int.Parse(lb_JaLike.Text) + 1).ToString();
        }
        private void btn_JaLike_Click(object sender, EventArgs e)
        {
            lb_JaLike.Text = (int.Parse(lb_JaLike.Text) + 1).ToString();
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                
                MessageBox.Show( "등록되었습니다.");
                textID.Text = "";
            }
            else
            {
                MessageBox.Show("이름을 입력해주세요");
            }
        }
    }

    public class CircularButton : System.Windows.Forms.Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
