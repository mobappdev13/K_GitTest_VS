using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class Program
    {
        private static object object1, object2, object3;

        static void Main(string[] args)
        {
            //single dimensional int 32 array dicchiarazione e Inizializzazione
            int[] singleDimArray1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] singleDimArray2 = { 0, 2, 4, 6, 8 };
            //or
            string[] singleDimArrayStrings1 = new string[3] { "Hola", "Ciao", "Hello" };
            string[] singleDimArrayString2 = { "Hola", "Ciao", "Hello" };

            object[] singleDimArrayObject1 = { object1, object2, object3 };
            object[] singleDimArrayObject2 = new object[] { object1, object2, object3 };
            //
            Console.WriteLine();
            Console.WriteLine("****************************** arrays  single dimension****************");
            Console.WriteLine();
            //percorrere un array
            foreach (var item in (singleDimArray1))
            {
                System.Console.WriteLine("array of int, {0} ", item);

            }
            System.Console.WriteLine("The array has {0} dimensions.", singleDimArray1.Rank);
            for (var i = 0; i < singleDimArray2.Length; i++)
            {
                System.Console.Write(" first array: iessimo value:{0}", singleDimArray1[i]);
                System.Console.WriteLine(" second array: iessimo value:{0}", singleDimArray2[i]);
            }


            for (var i = 0; i < singleDimArrayString2.Length; i++)
            {
                Console.WriteLine("string {0}", singleDimArrayString2[i]);
            }

            foreach (object myobject1 in singleDimArrayObject1)
            {
                //non stampa niente ,,,,
                Console.WriteLine("object :  {0}", myobject1);
            }


            Console.WriteLine();
            Console.WriteLine("****************************** arrays  MULTI DIMENSIONAL ****************");
            Console.WriteLine();

            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 25 }, { 13, 34 }, { 51, 64 }, { 77, 888 } };
            int[,] arayMulti2 = new int[,] { { 1, 3 }, { 4, 5 }, { 56, 78 } };
            //rayMulti2 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error !!!
            //
            foreach (var valore in array2D)
            {
                Console.WriteLine(" valore: {0}", valore);
            }

            // two for
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            // 4 copie da 2
            int[,] myArray = new int[4, 2] { { 14, 56 }, { 22, 4 }, { -171, 1 }, { 167, 61 } };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    try
                    {
                        //Console.WriteLine("matrix :{0}{1} ", matrix[i, j]);
                        Console.WriteLine("myArraY[i, j] value {0 } indiceIessimo {1 } indiceJtessimo {2}", myArray[i, j], i, j);
                    }
                    catch (Exception e)
                    {
                        //
                        Console.WriteLine("error {0} ", e.Message);
                        i = myArray.GetLength(0);
                        j = myArray.GetLength(1);
                        //forza two break
                    }

                }
            }
            // Display the array elements.

            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
            Console.ReadLine();

        }

        private static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
    }
  }
//end end
    //loop infinito error 
    ////for (;;)
    //{
    //    // ...
    //}
   