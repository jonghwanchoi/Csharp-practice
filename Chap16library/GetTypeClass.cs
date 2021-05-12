using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Chap16library
{
    public class GetTypeClass
    {
        public Type type;
        private string param1;
        private string param2;
        public GetTypeClass(string Instance) //생성자
        {
            string path = "Chap16library." + Instance;
            this.type = Type.GetType(path);// type.GetType() ; =>해당 네임스페이스의 클래스 형식을 반환
        }

        public object makeInstance(string param1 , string param2)
        {
            this.param1 = param1;
            this.param2 = param2;
            object a = Activator.CreateInstance(type); //반환 받은 형식으로 객체(인스턴스)를 동적으로 생성
            return a;
        }

        public object makeInstance_App()
        {
            object a = Activator.CreateInstance(type); //반환 받은 형식으로 객체(인스턴스)를 동적으로 생성
            return a;
        }

        public  void PrintMethods(object obj,string title)
        {
            Console.WriteLine($"--------{title}. Methods -------- ");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public); 
           
            foreach (MethodInfo method in methods)
            {
                foreach(var item in method.CustomAttributes)
                {
                    if(item.AttributeType.ToString().Contains("Test")) //attribute 적용
                    {
                        Console.Write($"Name : {method.Name},Parameter : ");
                        ParameterInfo[] args = method.GetParameters();
                        for (int i = 0; i < args.Length; i++)
                        {
                            Console.Write("{0}", args[i].ParameterType.Name);
                            if (i < args.Length - 1)
                                Console.Write(", ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.Write("Print형 메소드 선택 : ");
            string input = Console.ReadLine();
            foreach (MethodInfo method in methods)
            {
                if (method.Name == input)
                {
                    MethodInfo methodInfo = type.GetMethod(input);
                    methodInfo.Invoke(obj, null);
                }
            }

        }//print method

        public MethodInfo[] selectMethod()
        {
            //methods라는 MethodInfo 형식의 배열 객체에 type의 메소드(조건 : public, 인스턴스) 정보 가져오기
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            //myMethods라는 MethodInfo 형식의 리스트 객체 생성
            List<MethodInfo> myMethods = new List<MethodInfo>();

            foreach (MethodInfo method in methods)
            {
                foreach (var item in method.CustomAttributes)
                {
                    if (item.AttributeType.ToString().Contains("Test")) //attribute를 적용해 메소드 선별
                    {
                        myMethods.Add( method); //선별된 메소드들을  myMethods 리스트에 추가
                    }
                }
            }
            //myMethods 리스트를 배열로 변환해 다시 methods 배열에 저장 후 반환
            methods = myMethods.ToArray(); 
            return methods;
        }
    }//End class
}
