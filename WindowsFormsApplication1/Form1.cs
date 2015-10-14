using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int cc = 0xff - 0xb;
            int bb = 255 - 11;
            string cc0xxx = System.Convert.ToString(cc, 16);
            string BB0xxx = System.Convert.ToString(bb, 16);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int[] index = new int[20];
            for (int i = 0; i < 20; i++)
                index[i] = i+1;
            Random r = new Random();
            //用来保存随机生成的不重复的10个数 
            int[] result = new int[20];
            int site = 20;//设置上限 
            int id;
            for (int j = 0; j < 20; j++)
            {
                if (site > 1)
                {
                    id = r.Next(1, site - 1);
                    //test git

                    //在随机位置取出一个数，保存到结果数组 
                    result[j] = index[id];
                    //最后一个数复制到当前位置 
                    index[id] = index[site - 1];
                    //位置的上限减少一 
                    site--;
                    Debug.Print(result[j].ToString());
                }
                else
                {
                    result[j] = index[0];
                }
            }
        }
    }
}
