Proje 1
[22,27,16,2,18,6] -> Insertion Sort

1. Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
2. Big-O gösterimini yazınız.
3. Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.


[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

1. InSortion dosya adı ile C# dilinde kodladım.
2. Big O Notation: O(n2)
3.  
	Average Case: Ortada ise; n/2 * (n/2+1) /2 = (n2 + 2n) / 8 => O(n2)
	Best Case: Başta ise: O(1)
	Worst Case: Sonda ise: n * ( n+1) / 2 = (n2 + n) / 2 => O(n2)
	
4. Average Case kapsamına girer.

5. 
        public int[] inserSort(int[] input)
        {
            for (int i = 0; i < 4 - 1; i++) // ilk dört adım
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        int temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
