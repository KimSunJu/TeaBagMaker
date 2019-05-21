using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; //입력값이 숫자인지를 확인

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        //콤보박스 데이터 
        string[] list = new string[] {"홍차","녹차","루이보스차","국화차"};
        int countnum = 0;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb.Text != "")
            {
                result = cb.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<list.Length; i++)
            {
                this.cb.Items.Add(list[i]);
                //배열의 첫번째인 차 이름을 화면에 먼저 보여주기
                if (cb.Items.Count > 0)
                {
                    this.cb.SelectedIndex = 0;
                }
            }
        }

        private void but_Click(object sender, EventArgs e)
        {
         
        }

        private void timer_Tick(object sender, EventArgs e)
        {
       
        }

    }
}
