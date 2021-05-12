using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Chap16library;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private List<Button> myButtons = new List<Button>(); // 버튼을 담을 리스트 생성
        private int cntBtn = 0; // 현재 화면에 동적 생성한 버튼 수 초기화 

        GetTypeClass getTypeClass; //클래스의 Type 정보를 저장할 인스턴스 생성
        string[] tbList = { "", "" }; //파라미터 값을 저장할 배열 생성
        public Form2()
        {
            InitializeComponent();
        }
        private void listBox_getType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_getMethod.Items.Clear(); //클래스를 선택할때마다 기존에 쓰여진 Text 제거 (갱신용)
            resultBox.Text = "";
            string selected = listBox_getType.SelectedItem.ToString(); //클래스 선택
            selectedTypeBox.Text = selected; //선택한 클래스 출력

            //선택한 클래스의 Type 정보를 저장할 인스턴스 생성
            getTypeClass = new GetTypeClass(selected);

            //생성한 인스턴스(getTypeClass)를 통해 attribute를 적용한 클래스의 메소드 이름들을 배열로 반환
            MethodInfo[] selectedMethods = getTypeClass.selectMethod();
            int len = selectedMethods.Length;

            if (selected == "Profile") //선택한 클래스에따라 파라미터 및 메소드 리스트의 라벨 값 생성
            {
                param1.Text = "Player Name";
                param2.Text = "Phone";
                methodList.Text = "Methods of Profile";
            }
            else if (selected == "Team")
            {
                param1.Text = "Team";
                param2.Text = "Location";
                methodList.Text = "Methods of Team";
            }

            //selectedMethod에 저장된 메소드 이름들을 listBox_getMethod 목록에 하나씩 추가
            for (int i = 0; i < len; i++)
            {
                listBox_getMethod.Items.Add(selectedMethods[i].Name);
                if (myButtons.Count > 0)
                    myButtons[i].Text = selectedMethods[i].Name.ToString();
            }
        }
        private void button_Create_Click(object sender, EventArgs e)
        {
            int cnt = listBox_getMethod.Items.Count; //listBox_getMethod로 가져온 method들  카운트

            if (cnt == 0) //0이면 무시하고 돌아감
            {
                MessageBox.Show("클래스를 먼저 선택하세요!!", "알림 메세지", default, MessageBoxIcon.Exclamation);
                return;
            }


            if (cntBtn > 0)  //현재 존재하는 버튼이 있으면 화면과 리스트에서 삭제함
                delListBtn();

            // 새로운 버튼을 생성하여 리스트에 추가하고, 속성을 설정함.
            for (int i = 0; i < cnt; i++)
            {
                myButtons.Add(new Button()); //버튼 생성
                myButtons[i].Size = new Size(125, 57);
                myButtons[i].Location = new Point(494, 241 + 64 * i);
                myButtons[i].Name = "myButton" + i.ToString(); //버튼 이름
                myButtons[i].Text = listBox_getMethod.Items[i].ToString(); //생성한 버튼 속 텍스트
                myButtons[i].UseVisualStyleBackColor = true;
                myButtons[i].Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
                myButtons[i].ForeColor = Color.Black;
                myButtons[i].Tag = 0;

                //버튼을 클릭할 때 처리할 이벤트 처리기 등록
                myButtons[i].Click += new EventHandler(btnClick);
                //생성한 버튼을 화면 컨트롤에 추가해서 출력
                this.Controls.Add(myButtons[i]);
            }
            cntBtn = cnt; //현재 화면에 새로 생성한 버튼 수를 저장
        }

        public void btnClick(object sender, EventArgs e)
        {
            //입력한 파라미터 값 저장
            tbList[0] = paramBox1.Text;
            tbList[1] = paramBox2.Text;

            //파라미터 입력박스 초기화
            paramBox1.Text = "";
            paramBox2.Text = "";

            Button btn = sender as Button; //현재 버튼 객체
            string method = btn.Text; //버튼의 Text값==method 이름

            object profile = getTypeClass.makeInstance_App(); //선택한 클래스의 인스턴스를 동적으로 생성
            MethodInfo methodInfos = getTypeClass.type.GetMethod(method); //메소드 정보 추출
            ParameterInfo[] arguments = methodInfos.GetParameters(); // 파라미터 Type 추출
            string[] paramethres = null;

            if (arguments.Length > 0)
            {
                if (tbList[0] != "" && tbList[1] != "")
                {
                    paramethres = new string[arguments.Length];
                    for (int i = 0; i < arguments.Length; i++)
                    {
                        paramethres[i] = tbList[i];
                    }
                }
                else 
                {
                    MessageBox.Show("파라미터 값을 입력하세요!!", "알림 메세지", default, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //동적으로 생성한 인스턴스에서 선택한 메소드 호출(반환값 저장)
            var returnValue = methodInfos.Invoke(profile, paramethres);

            //반환값을 문자열로 변환해 resultBox에 출력
            resultBox.Text = method + " 버튼 클릭!!\r\n"; //\r\n => 줄바꿈
            resultBox.Text += returnValue.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            delListBtn(); //생성한 버튼 삭제

            //listBox_getType(클래스 리스트)을 제외한 모든 리스트, 텍스트박스 목록 및 라벨 초기화
            param1.Text = "";
            param2.Text = "";
            methodList.Text = "";
            paramBox1.Text = "";
            paramBox2.Text = "";
            selectedTypeBox.Text = "";
            resultBox.Text = "";
            listBox_getMethod.Items.Clear();
        }

        private void delListBtn()
        {
            int cnt = myButtons.Count; //생성한 버튼 카운트

            //등록된 컨트롤 정보 삭제
            for (int i = 0; i < cnt; i++)
                this.Controls.Remove(myButtons[i]);

            //동적 생성한 버튼 수를 0으로 초기화
            cntBtn = 0;
        }
    }//end class
}