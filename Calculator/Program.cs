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
            string op;
            string[] arrOp = new string[4] { "+", "-", "*", "/" }; //연산자 배열
            Random rand = new Random();
            Calc c1 = new Calc();
            while (true)
            {   
                fnum = rand.Next(10, 99);
                snum = rand.Next(10, 99);
                op = arrOp[rand.Next(0, 3)]; // 연산자 난수로다가 정함!
                Console.WriteLine("========랜덤문제!========");
                Console.WriteLine($"{fnum} {op} {snum} = ");
                if(op == "/")                
                    Console.WriteLine("나누기는 몫만 구하세요!");
                int result;
                if(!int.TryParse(Console.ReadLine(),out result))
                {
                    Console.WriteLine("다시 입력하세요");
                }

                switch (op)
                {
                    case "+": c1.sum(fnum, snum); break;
                    case "-": break;
                    case "*": break;
                    case "/": break;
                }
            }
            
            


        }
    }
}
