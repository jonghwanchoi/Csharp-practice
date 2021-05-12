using System;
using Chap16library;
using System.Reflection;

namespace Chap16
{
    class Program
    {
  
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("입력 받을 형식 : Profile / Team : ");
                string input = Console.ReadLine();
                GetTypeClass getTypeClass = new GetTypeClass(input);
                if (input == "Profile")
                {
                    object profile = getTypeClass.makeInstance("손흥민", "557-1118");
                    getTypeClass.PrintMethods(profile, input);
                }
                else if (input == "Team")
                {
                    object teamProfile = getTypeClass.makeInstance("토트넘", "런던");
                    getTypeClass.PrintMethods(teamProfile, input);
                }
                else if (input == "end")
                {
                    Console.WriteLine("프로그램 종료");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력 방식입니다.");
                }
            }


        }//Main method
    }//end class
}

