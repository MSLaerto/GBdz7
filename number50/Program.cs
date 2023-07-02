int InputNumber(string message){
    Console.Write("Введите {0} : " , message);
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
int GetRandInt(){
    Random rnd = new Random();
    return (rnd.Next(0 , 9));
}
int[,] ArrayGen(int m , int n){
    int[,] matrix = new int[m,n];
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < n ; j++){
            matrix[i,j] = GetRandInt();
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr){
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void FindNum(int m , int n , int[,] matr){
    if (m < matr.GetLength(0) && n < matr.GetLength(0)){
        Console.WriteLine("Ваше число: {0}" , matr[m-1,n-1]);
    }else{
        Console.WriteLine("Такого числа в массиве нет");
    }
}
int m = InputNumber("m");
int n = InputNumber("n");
int[,] matrix = new int[m,n];
matrix = ArrayGen(m,n);
PrintMatrix(matrix);
FindNum(InputNumber("m"), InputNumber("n") , matrix); 