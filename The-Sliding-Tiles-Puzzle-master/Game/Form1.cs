using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Game
{
    public partial class Form1 : MetroForm
    {
        public Button CurrentBlank;
       
        int StepCount;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadGame()
        {
         
            StepCount = 0;
            label5.Text = "Steps : " + StepCount;
           
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Random rand = new Random();
            int[] RandNum = num.OrderBy(x => rand.Next()).ToArray();
            b1.Text = RandNum[0].ToString();
            b2.Text = RandNum[1].ToString();
            b3.Text = RandNum[2].ToString();
            b4.Text = RandNum[3].ToString();
            b5.Text = RandNum[4].ToString();
            b6.Text = RandNum[5].ToString();   
            b7.Text = RandNum[6].ToString();
            b8.Text = RandNum[7].ToString();
            b9.Text = "";
            b9.Focus();

            try
            {
                CurrentBlank.BackColor = Color.White;
            }
            catch (Exception e) { }
            CurrentBlank = b9;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGame();
        }
        public void changeTile(Button valued, Button blank)
        {
            if(blank.Text == "")
            {
                blank.Text = valued.Text;
                blank.BackColor = Color.White;
                valued.Text = "";        
                StepCount += 1;
                label5.Text = "steps : " + StepCount;
                CurrentBlank = valued;
            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            changeTile(b1, b2);
            changeTile(b1, b4);
        }
        private void b2_Click(object sender, EventArgs e)
        {      
            changeTile(b2, b1);
            changeTile(b2, b3);
            changeTile(b2, b5);
        }
        private void b3_Click(object sender, EventArgs e)
        {
            changeTile(b3, b2);
            changeTile(b3, b6);
        }
        private void b4_Click(object sender, EventArgs e)
        {       
            changeTile(b4, b1);
            changeTile(b4, b5);
            changeTile(b4, b7);
        }
        private void b5_Click(object sender, EventArgs e)
        {         
            changeTile(b5, b2);
            changeTile(b5, b4);
            changeTile(b5, b6);
            changeTile(b5, b8);
        }
        private void b6_Click(object sender, EventArgs e)
        {         
            changeTile(b6, b3);
            changeTile(b6, b5);
            changeTile(b6, b9);          
        }
        private void b7_Click(object sender, EventArgs e)
        {      
            changeTile(b7, b4);
            changeTile(b7, b8);         
        }
        private void b8_Click(object sender, EventArgs e)
        {    
            changeTile(b8, b5);
            changeTile(b8, b7);
            changeTile(b8, b9);

        }
        private void b9_Click(object sender, EventArgs e)
        {     
            changeTile(b9, b6);
            changeTile(b9, b8);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] resultSet = new string[8];
            resultSet[0] = b1.Text;
            resultSet[1] = b2.Text;
            resultSet[2] = b3.Text;          
            resultSet[3] = b4.Text;
            resultSet[4] = b5.Text;
            resultSet[5] = b6.Text;
            resultSet[6] = b7.Text;
            resultSet[7] = b8.Text;
     
            int count = 1;
            foreach (string s in resultSet)
            {
                try
                {
                    if (Convert.ToInt32(s) == count)
                        count += 1;
                    else
                        label1.Text = "Status: You Loose !";
                }
                catch (Exception exc) { }
            }
            if (count == 8)
                label1.Text = "Status: You Win !";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadGame();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
