using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 4, 9, 11, 18, 7}; //Creates array 
            int LowestIndex = 0; //Set the lowest index
            int currentLowest; 

            while (LowestIndex < arr.Length)
            {
                currentLowest = LowestIndex;

                for (int i = LowestIndex + 1; i < arr.Length; i++)
                {
                    if (arr[currentLowest] > arr[i])
                    {
                        currentLowest = i;
                    }
                }

                //Used swap the current lowest with the lowest index 
                int temp = arr[currentLowest];
                    arr[currentLowest] = arr[LowestIndex];
                    arr[LowestIndex] = temp;
                    LowestIndex++;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ReadKey();
            }
        }
    }

