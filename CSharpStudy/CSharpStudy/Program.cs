using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy {
    class Program {
        static void Main(string[] args) {
            //String Name, myAge, myJob;
            //Name = "안형주";
            //myAge = "18살";
            //myJob = "학생";
            ////write쓰는법
            //System.Console.Write("Hello World");
            ////writeline쓰는법
            //System.Console.WriteLine(Name);
            //System.Console.Write(myAge);
            //System.Console.WriteLine(myJob);
            //System.Console.Write("경기게임마이스터고");
            //System.Console.WriteLine("인천");
            //System.Console.Write("2006년6월20일");
            //System.Console.WriteLine(".");
            //System.Console.Write(".");
            //System.Console.WriteLine(".");

            //데이터 형 - string
            /*String name, address, age, gender;

            Console.Write("이름을 입력해 주세요: ");
            name = Console.ReadLine();

            Console.Write("주소을 입력해 주세요: ");
            address = Console.ReadLine();

            Console.Write("나이을 입력해 주세요: ");
            age = Console.ReadLine();

            Console.Write("성별을 입력해 주세요: ");
            gender = Console.ReadLine();

            Console.WriteLine($"당신의 이름은: {name}");
            Console.WriteLine($"당신의 이름은: {address}");
            Console.WriteLine("당신의 이름은: " + age);
            Console.WriteLine("당신의 이름은: " + gender);
            Console.WriteLine("당신의 이름은 {0}이고 당신의 나이는{1}",name,age);*/
            /*
                        int myAge = 3;
                        string myName = "dksgudwn";
                        string dd = "dksgudwn";
                        string ddd = "dksgudwn";
                        myName = dd + ddd;
                        Console.WriteLine(myName);
                        Console.WriteLine("\"dksgudwn");*/


            /*string myAge;
            Console.Write("나이입력: ");
            myAge = Console.ReadLine();
            int myAgeNumber = Convert.ToInt32(myAge);
            int nowYear = Convert.ToInt32(DateTime.Now.Year);
            string nowAge = (nowYear - myAgeNumber).ToString();
            Console.WriteLine(nowAge);*/

            /*         Console.WriteLine(@"
                                 *
                                ***
                               *****
                              *******
                             *********
                            ***********
                           *************
                          ***************
                         *****************
                        *******************
                       *********************
                      ***********************
                     *************************
                    ***************************
                   *****************************
                  *******************************
                 *********************************
                ***********************************
               *************************************
              ***************************************
             *****************************************
            *******************************************
           *********************************************
          ***********************************************
         ");*/

            /*
                        //1.변수형 종류 주석으로 작성후, 각 변수형들의 최대값 최소값 출력하기
                        //int, float, char, string
                        Console.WriteLine(int.MaxValue);
                        Console.WriteLine(int.MinValue);
                        Console.WriteLine(float.MaxValue);
                        Console.WriteLine(float.MinValue);
                        Console.WriteLine(char.MaxValue);
                        Console.WriteLine(char.MinValue);
                        //2.string으로 이름 나이 입력받고, 출력하기
                        //나이는 출생년도만 입력받기
                        string name = Console.ReadLine();
                        string age = Console.ReadLine();
                        int nowAge = DateTime.Now.Year - Convert.ToInt32(age);
                        Console.WriteLine($"이름: {name} 나이: {nowAge}");
                        //3.@사용해서 별 그리기
                        Console.WriteLine(@"
                                    *
                                   ***
                                  *****
                                 *******
                           *******************
                            *****************
                             ***************
                            *****************
                           *******************
                                 *******
                                  *****
                                   ***
                                    *
            ");
                        //4.int 값을 double로 캐스팅하기
                        int change = Convert.ToInt32(3.12);*/
            /*
                        //이름을 입력받는다.
                        //입력받은 이름의 길이를 숫자를 바꾸고
                        //받은 숫자를 출력한다.
                        string name;
                        name = Console.ReadLine();
                        Console.WriteLine(name.Length);*/

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            int[] arr4 = new int[5];
            int[] arr5 = new int[5];

            string[] str1 = new string[5];
            string[] str2 = new string[5];
            string[] str3 = new string[5];
            string[] str4 = new string[5];
            string[] str5 = new string[5];

            int[] LaterArray;

            Console.WriteLine("배열의 크키는?");
            int ArraySize = int.Parse(Console.ReadLine());
            LaterArray = new int[ArraySize];

            string[] _lang = new string[3];
            _lang[0] = "C";
            _lang[1] = "C++";
            _lang[2] = "C#";

        }
    }
}
