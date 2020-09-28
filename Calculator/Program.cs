using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //계산기 ㄱㄱ
            //난수 구하기
            int fnum; //퍼스트넘버
            int snum; //세컨드넘버
            Calc op1 = new Calc();

            string[] arrOp = new string[4] { "+", "-", "*", "/" }; //연산자 배열
            Random rand = new Random();
            Calc c1 = new Calc();
            while (true)
            {   
                fnum = rand.Next(10, 99);
                snum = rand.Next(10, 99);
                
                op1.Op = arrOp[rand.Next(0, 3)]; // 연산자 난수로다가 정함!
                Console.WriteLine("========랜덤문제!========");
                Console.WriteLine($"{fnum} {op1.Op} {snum} = ");
                if(op1.Op == "/")                
                    Console.WriteLine("나누기는 몫만 구하세요!");
                int result;
                while (true)
                {
                    Console.Write("정답은? : ");
                    if (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("다시 입력하세요");                        
                    }
                    if (op1.Operation(result, fnum, snum))
                    {
                        Console.Write("정답입니다 계속하시겠습니까?(y/n) : ");
                        string q = Console.ReadLine();
                        if (q.ToUpper() == "N")
                        {
                            Console.WriteLine("계산기 프로그램을 종료합니다");
                            return;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("땡 틀렸습니다 다시 입력하세용");
                        Console.WriteLine($"{fnum} {op1.Op} {snum} = ");
                    }
                }
               
            }
            
            


        }
    }
}
