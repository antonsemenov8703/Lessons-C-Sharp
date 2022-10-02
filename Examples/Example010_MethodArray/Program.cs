int[]array = {1,12,31,4,18,15,16,17,18};

int n = array.Length;   // array.Length - возвращает длину массива
int find = 18;           // задали число, которое мы ищем

int index = 0;           // ставим значение индекса в начало массива

while(index<n)
{
    if(array[index]==find) //
    {
        Console.WriteLine(index);
        break; // если выполнилось условие, то прерви
    }
    // index=index+1
    index++;
}
