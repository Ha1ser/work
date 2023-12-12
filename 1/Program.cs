int[] MassNums(int size, int from, int to) {
    int[] arr = new int[size];

    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void Print(int[] arr){
    int size = arr.Length;
    for (int i = 0; i < size; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int quantity(int[] arr) {
    int size = arr.Length;
    int s = 0;
    for(int i = 0; i < size; i++) {
        if(arr[i] > 20 && arr[i] < 90) {
            s++;
        }  
    } return s;
}

Console.Write("обозначте длину масcива: ");
int k = int.Parse(Console.ReadLine()!);
Console.Write("минимальное число в масcиве: ");
int nach = int.Parse(Console.ReadLine()!);
Console.Write("максимальное число в масcиве: ");
int kon = int.Parse(Console.ReadLine()!);
int[] array = MassNums(k, nach, kon);

Console.Write("вывод элементов масcива: ");
Print(array);

Console.Write("итог: ");
Console.Write(quantity(array));