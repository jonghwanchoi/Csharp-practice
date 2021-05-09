using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15library
{
    class Profiles
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    public class GroupByClass
    {
        public void exam()
        {
            Profiles[] arrProfile =
            {
                new Profiles() { Name = "정우성", Height = 186 },
                new Profiles() { Name = "김태희", Height = 158 },
                new Profiles() { Name = "고현정", Height = 172 },
                new Profiles() { Name = "이문세", Height = 178 },
                new Profiles() { Name = "하하", Height = 171 }
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };
            foreach(var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}"); //True or False
                foreach(var profile in Group.Profiles) // 그룹 변수 g
                {
                    Console.WriteLine(($">>> {profile.Name}, {profile.Height} "));
                }
            }
        }
    }
}
