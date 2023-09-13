namespace ArrayListLibray
{
    public class ArrayList
    {
        private int _length { get { return _array.Length; } }
        public int[] _array;
        public int Count { get; private set; }

        public ArrayList()
        {
            _array = new int[7];
            Count = 0;
        }

        public ArrayList(int length)
        {
            _array = new int[length];
            Count = 0;
        }

        public ArrayList(int[] arr)
        {
            int length = (int)(arr.Length * 1.5);
            _array = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i] = arr[i];
            }
            Count = arr.Length;
        }

        public int this[int index]
        {
            get
            {
                if (index > Count - 1)
                {
                    throw new Exception($"row 41, по индексу:{index} нет элемента");
                }
                return _array[index];
            }
            set
            {
                if (index > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Add(int element)
        {
            if (Count >= _array.Length)
            {
                Increathlength();
            }
            _array[Count++] = element;
        }

        private void Increathlength(int countElements = 1)
        {
            int newLength = _length;
            while (newLength <= _length + countElements)
            {
                newLength = (int)(newLength * 1.5 + countElements);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _length); _array = newArray;
        }



        //1)Написать метод добавления по индексу
        //Add(int element, int index){} пример: Я хочу добавить елемент 4 на позицию 3(Другие элементы должны сдвинуться)   1, 2, 3, 5 => 1, 2, 3, 4, 5
        public void Add(int element, int index)
        {

            if (Count >= _array.Length)
            {
                Increathlength();
            }
            int temp = 0;
            for (int i = 0; i < _array.Length; i++)
            {

                if (i >= index)
                {
                    temp = _array[i];
                    _array[i] = element;
                    element = temp;
                }

            }
            Count++;
        }
        //2)Написать метод для уменьшения размера массива(По аналогии с Increathlength)
        public void DecreaseLengthFromMax(int countElements = 1)
        {
            int newLength = _length;

            newLength = (int)(newLength - countElements);

            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, newLength); _array = newArray;
            if (newLength < Count)
            {
                Count = newLength;
            }

        }
        public void DecreaseLengthFromCount(int countElements = 1)
        {
            int a = Count - countElements;


            int[] newArray = new int[a];
            Array.Copy(_array, newArray, a); _array = newArray;
            Count = a;
        }
        //3)Написать удаление элемента по индексу
        public void Del(int index)
        {
            int element = 0;
            int temp = 0;
            for (int i = 0; i < Count;  i++)
            {
                
                if (i >= index && i < Count-1)
                {
                    _array[i] = _array[i+1];
                }
                if (i == Count - 1)
                {
                    _array[i] = 0;
                }

            }
            Count--;

        }
        //4)Написать метод удаления элементов. То есть я хочу удалить из списка все элементы равные 5(название метода Remove(int element)) 1, 5, 2, 3, 5 => 1, 2, 3
        public void DelElement(int element)
        {

            for (int i = 0; i <= Count; i++)
            {

                if (_array[i] == element)
                {
                    Del(i);
                    i--;

                }

            }
        }
        //5)Написать метод нахождения максимального числа
        public int Min()
        {
            int min = 100000;
            for (int i = 0; i < Count; i++)
            {

                if (min > _array[i])
                {
                    min = _array[i];
                }

            }
            return min;
        }
        //6)Написать метод нахождения минимального числа

        public int Max()
        {
            int max = -100000;
            for (int i = 0; i < Count; i++)
            {

                if (max < _array[i])
                {
                    max = _array[i];
                }

            }
            return max;
        }

    }
}