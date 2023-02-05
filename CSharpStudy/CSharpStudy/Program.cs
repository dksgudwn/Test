using System;

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
            /*
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
                        _lang[2] = "C#";*/

            //식당에 음식이 떡볶이, 김밥, 라면, 라뽁이가 있다.
            //이중에 숫자를 입력받으면
            //입력받은 값은 비어있게 된다.
            //최초 음식들과
            //숫자를 입력받았을때 음식을 출력하고
            //비어있게 되었다라는 결과값도 출력하라

            /*string[] food = new string[7] { "떡복이", "김밥", "라면", "라뽁이", "", "", "" };

            Console.WriteLine("1번: 떡복이, 2번: 김밥, 3번: 라면, 4번: 라뽁이");
            int input = int.Parse(Console.ReadLine());
            food[input - 1] = "";
            Console.WriteLine("음식5 입력");
            food[4] = Console.ReadLine();
            Console.WriteLine("음식6 입력");
            food[5] = Console.ReadLine();
            Console.WriteLine("음식7 입력");
            food[6] = Console.ReadLine();
            Console.WriteLine($"1번: {food[0]}, 2번: {food[1]}, 3번: {food[2]}, 4번: {food[3]}, 5번: {food[4]}, 6번: {food[5]}, 7번: {food[6]}");*/
            /*string name;
            string year;
            string info;

            name = Console.ReadLine();
            year = Console.ReadLine();
            info = Console.ReadLine();

            Console.WriteLine($"{name}");
            Console.WriteLine($"{2023 - Convert.ToInt32(year)}");
            Console.WriteLine($"{info}");
            Console.WriteLine(@"ㅁ");
            string[] arr = new string[] { name, year, info };*/


            /*
                        int number11 = 123;
                        int number21 = 532;
                        number21 += number11;
                        Console.WriteLine(number21);

                        int value = 0;
                        Console.WriteLine(value++);
                        Console.WriteLine(value);
                        Console.WriteLine(++value);
                        Console.WriteLine(value);
                        Console.WriteLine(value++);
                        Console.WriteLine(value);
                        Console.WriteLine(++value);
                        Console.WriteLine(value);*/



            /*bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);


            int number1 = 3 + 2;
            int number2 = 3 + 2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            int number = number1 + number2;
            Console.WriteLine(number);

            if(number1 % 2 == 0 && number2 < 0) {
                Console.WriteLine("a가짝수이고b가0보다작음");
            }
            else if(number1 % 2 == 0 && number2 < 3) {
                Console.WriteLine("a가짝수이고b가3보다작음");
            }
            else if(number1 % 2 == 1 && number2 < 5) {
                Console.WriteLine("a가홀수이고b가5보다작음");
            }
            else {
                Console.WriteLine("else");
            }*/


            /* int input = 1;
             input = int.Parse(Console.ReadLine());*/
            /*while(input>=0) {
                Console.WriteLine("0");
                input--;
            }*/

            //for(int i = 1; i <= 5; i++) {
            //    for(int j = 1; j <= i; j++) {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("\n");

            //for(int i = 5; i >= 1; i--) {
            //    for(int j = i; j >0; j--) {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("\n");

            //for(int i = 1; i <= 5; i++) {
            //    for(int j = 1; j <= 5 - i; j++) {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= i; k++) {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("\n");

            //for(int i = 1; i <= 5; i++) {

            //    for(int j = 0; j < i; j++) {
            //        Console.Write(" ");
            //    }
            //    for(int k = 5; k >= i; k--) {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("\n");

            //for(int i = 1; i < 11; i += 2) {
            //    for(int j = 1; j <= i; j++) {
            //        Console.Write("*");
            //    }
            //    for(int k = 0; k < 4; k++) {

            //    }
            //    Console.Write("\n");
            //}

            //OddOrEven(5);
            //Console.WriteLine(OddOrEven(5) ? "짝수" : "홀수");
            //int number1 = int.Parse(Console.ReadLine());
            //string str = Console.ReadLine();
            //int number2 = int.Parse(Console.ReadLine());
            //int result = 0;
            //if(str == "+") {
            //    result = add(number1, number2);
            //    Console.WriteLine($"{number1} {str} {number2} = {result}");
            //}
            //else if(str == "-") {
            //    result = sub(number1, number2);
            //    Console.WriteLine($"{number1} {str} {number2} = {result}");
            //}
            //else if(str == "*") {
            //    result = mul(number1, number2);
            //    Console.WriteLine($"{number1} {str} {number2} = {result}");
            //}
            //else if(str == "/") {
            //    result = dev(number1, number2);
            //    Console.WriteLine($"{number1} {str} {number2} = {result}");
            //}
            //else {
            //    Console.WriteLine("기호를 잘못입력");
            //}

            int a = int.Parse(Console.ReadLine());
            repeat(a);
        }

        private static void one(int a) {
            Console.WriteLine(a + 2);

        }
        private static void two(int a) {
            Console.WriteLine(a - 2);
        }
        private static void three(int a) {
            Console.WriteLine(a * 2);
        }
        private static void four(int a) {
            Console.WriteLine(a / 2);
        }
        private static bool OddOrEven(int a) {
            if(a % 2 == 0) {
                return true;
            }
            else {
                return false;
            }
        }
        private static int add(int a, int b) {
            return a + b;
        }
        private static int sub(int a, int b) {
            return a - b;
        }
        private static int mul(int a, int b) {
            return a * b;
        }
        private static int dev(int a, int b) {
            return a / b;
        }
        private static void repeat(int a) {
            for(int i = 0; i < a; i++) {
                Console.WriteLine("mmm");
            }
        }
    }
}
