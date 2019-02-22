using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNote
{
    public partial class Form1 : Form
    {

        private string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        int windowLeft = 0;
        int windowTop = 0;
        

        //定数定義
        public static class Constants
        {
            public const int FORM_MAX = 10;

        }

        //全フォーム共有のクラス
        public static class MyData
        {
            public static int nowTop = 0;
            public static int color = 0;
            public static int nowFormNum = 0; //現在のフォームの数
            public static Form2[] form2Array = new Form2[Constants.FORM_MAX];
        }

        public Form1()
        {
            InitializeComponent();
            //this.textBox1.Visible = false;
            this.Height = 40;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //フォームを右上に表示
            windowLeft = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            windowTop = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            DesktopBounds = new Rectangle(windowLeft,0, this.Width,this.Height);

            //Form2の配列をセット
            for (int i = 0; i < Constants.FORM_MAX; i++) {
                MyData.form2Array[i] = new Form2();
            }
        } 
      

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (MyData.nowFormNum >= Constants.FORM_MAX)
            {
                return;
            }
 
            MyData.form2Array[MyData.nowFormNum].Show();
            MyData.form2Array[MyData.nowFormNum].Left = windowLeft;
            MyData.nowTop += 40;

            MyData.nowFormNum++;
           
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
