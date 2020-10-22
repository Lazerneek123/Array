using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class CreateArray
    {
        private int[] array;
        public int size_Array = GetSize(0);
        static int k = 0;

        static int GetSize(int size_Array)
        {
            if (k == 0)    // цей if зайвий але там в коді,(Program.cs а саме Main) я викликаю другий раз клас CreateArray тільки вже з параметром, а саме масивом array, то він потрібний щоб не викликать зайвий раз це тіло блоку (частинку коду)!
            {
                size_Array = Int32.Parse(Console.ReadLine());
                
            }
            k++;

            return size_Array;
        }

        public CreateArray(params int[] array)
        {
            this.array = new int[array.Length];

            for (int i = 0; i < array.Length; ++i)
            {
                this[i] = array[i];
            }
                
        }

        
        public int Length
        {
            get
            {
                return array.Length;
            }
        }
        
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < Length)
                {
                   return array[i];
                }
                else
                {
                    return 0;
                }
                    
            }
            set
            {
                if (i >= 0 && i < Length && value >= -10 && value <= 10)
                {
                    array[i] = value;
                } 
            }
        }

       /* public int Size_Check
        {
            get
            {
                return size_Array;
            }
            set
            {
                if (value > 0)
                {
                    size_Array = value;
                }
                else
                {
                    size_Array = 2;
                }

            }
        }

        public CreateArray(int size_Array)
        {
            this.size_Array = size_Array;
        }*/

    }
}
