         //Печатает одномерный массив
            void Print1DArr (int[] arr)
            {
                for (int i=0; i<arr.Length-1; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.WriteLine(arr[arr.Length-1]);
            }
        int positivSam = 0;
        int negotivSum = 0;

        int[] testArr = GenArray(12,-9,9);

        NegotivPositivSum(testArr);
        Print1DArr (testArr);
        PrintData("Сумма положительных чисел в массиве: ",positivSam);
        PrintData("Сумма отрицательных чисел в массиве: ",negotivSum);
        int[] GenArray(int len, int minValue, int maxValue)
        {
            Random rnd =new Random(); //создали массив
            int[] arr = new int[len]; //Создали массив 
            for (int i = 0; i < arr.Length; i++)  //Мин макс значение
            {                                              //Проходим по массиву заполняем его 
                arr[i] = rnd.Next(minValue, maxValue +1);
            }
            return arr; //Выдаем результат
        }

        void PrintData(string res, int value)
        {
            Console.WriteLine(res+value);
        }

        void NegotivPositivSum(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>0)
                {
                positivSam+= arr[i];
                }
            else
                {
                negotivSum+=arr[i];
                }
            }
            
        }