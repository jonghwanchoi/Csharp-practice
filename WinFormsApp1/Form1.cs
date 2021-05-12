using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chap16library;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] tbList= { "","" };
        GetTypeClass getTypeClass;
        object profile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string method = textBox1.Text;
            profile = getTypeClass.makeInstance_App(); //인스턴스 생성
            MethodInfo methodInfo = getTypeClass.type.GetMethod(method);
            ParameterInfo[] arguments = methodInfo.GetParameters();
            string[] paramethres = null;

            if(arguments.Length > 0)
            {
                paramethres = new string[2];
                for (int i = 0; i < arguments.Length; i++)
                {
                    paramethres[i] = tbList[i];
                }
            }

            var returnValue = methodInfo.Invoke(profile, paramethres);
            textBox4.Text = returnValue.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox_Methods.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tbList[0] = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tbList[1] = textBox3.Text;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = listBox2.SelectedItem.ToString();
            getTypeClass = new GetTypeClass(textBox5.Text); //Type 정보 얻기
        }
    }//end class
}
