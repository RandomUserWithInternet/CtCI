using NUnit.Framework;
using System;
using System.Collections;

namespace Three_Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            int stackSize = 10;
            int[] buffer = new int[stackSize * 3];
            int[] stackPointer = { -1,-1,-1 };

            void push(int stackNum, int value) 
            {
                if (stackPointer[stackNum] + 1 >= stackSize)
                {
                    Console.WriteLine("Error: Stack Overflow (Exceeds stackSize)");
                }
                else
                {
                    /* Increment stack pointer and then update top value */
                    stackPointer[stackNum]++;
                    buffer[absTopOfStack(stackNum)] = value;
                }
            }
            int pop(int stackNum) 
            {
                if (isEmpty(stackNum))
                {
                    Console.WriteLine("Error: Stack empty");
                    return -1;
                }
                else
                {
                    int value = buffer[absTopOfStack(stackNum)];
                    buffer[absTopOfStack(stackNum)] = 0;
                    stackPointer[stackNum]--;
                    return value;
                    
                }
            }

            int peek(int stackNum)
            {
                if (isEmpty(stackNum))
                {
                    Console.WriteLine("Nothing here to see");
                    return -1;
                }
                else
                {
                    int index = absTopOfStack(stackNum);
                    return buffer[index];
                }
            }

            bool isEmpty(int stackNum)
            {
                if (stackPointer[stackNum] == -1) {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int absTopOfStack(int stackNum)
            {
                return stackNum * stackSize + stackPointer[stackNum];
            }
            
            Console.WriteLine(peek(0));
            Console.WriteLine(peek(1));
            Console.WriteLine(peek(2));
            int x = 0;
            while (x == 0) {
                Console.WriteLine("Type any of the following options: \"peek\", \"pop\", \"push\", or \"exit\". ");
                string answer = Console.ReadLine();
                if (answer == "peek")
                {
                    Console.WriteLine("Select a stack (0-2)");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(peek(num));
                } else if (answer == "pop")
                {
                    Console.WriteLine("Select a stack (0-2)");
                    int num = Convert.ToInt32(Console.ReadLine());
                    pop(num);
                } else if (answer == "push")
                {
                    Console.WriteLine("Select a stack (0-2)");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a integer value");
                    int val = Convert.ToInt32(Console.ReadLine());
                    push(num, val);
                } else if (answer == "exit")
                {
                    x = 1;
                } 
            }
        }
    }
}

