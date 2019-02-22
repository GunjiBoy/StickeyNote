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
    public partial class Form2 : Form
    {
        private string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public Form2()
        {
            InitializeComponent();
            this.textBox1.Visible = false;
            this.Height = 40;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //フォームを右上に表示
            int windowLeft = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int windowTop = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            DesktopBounds = new Rectangle(windowLeft, 0, this.Width, this.Height);
            Form1.MyData.form2Array[Form1.MyData.nowFormNum].Top = Form1.MyData.nowTop;
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Escキーが押されたらアプリの終了
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BTN_ShowHideTEXT_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Visible == false)
            {
                
                this.textBox1.Visible = true;
                this.Height = 180;
                this.textBox1.Height = 150;
                this.BTN_ShowHideTEXT.Text = "v";
            }
            else {
                
                this.textBox1.Visible = false;
                this.Height = 40;
                this.BTN_ShowHideTEXT.Text = ">";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void 完了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //取り消し線
            this.textBox1.Font = new Font(this.textBox1.Font, FontStyle.Strikeout);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 192);
            this.textBox1.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 192);
            this.textBox1.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 255, 255);
            this.textBox1.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MyData.nowTop -= 40;
            Form1.MyData.nowFormNum--;

            for (int i = 0;  i < Form1.MyData.nowFormNum; i++) {
                //if ( <= i)
                //{
                //    Form1.MyData.formArray[i].Top -= 40;
                //}
            }

            this.Close();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(BTN_Edit, new Point(BTN_Edit.Width / 2, BTN_Edit.Height / 2));
        }
    }
}
