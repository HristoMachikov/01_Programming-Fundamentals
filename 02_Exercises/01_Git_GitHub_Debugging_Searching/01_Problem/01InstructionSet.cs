using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 0; i < uint.MaxValue; i++)
            {
                string opCode = Console.ReadLine();

                if (opCode != "END")
                {
                    string[] codeArgs = opCode.Split(' ');
                    long result = 0;
                    switch (codeArgs[0])
                    {
                        case "INC":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                result = operandOne + 1;
                                break;
                            }
                        case "DEC":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                result = operandOne - 1;
                                break;
                            }
                        case "ADD":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                long operandTwo = long.Parse(codeArgs[2]);
                                result = operandOne + operandTwo;
                                break;
                            }
                        case "MLA":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                long operandTwo = long.Parse(codeArgs[2]);
                                result = operandOne * operandTwo;
                                break;
                            }
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
