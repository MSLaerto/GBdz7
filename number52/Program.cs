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
void PrintArray(double[] result){
    Console.Write("Среднее по столбцам: ");
    for (int i = 0 ; i < result.GetLength(0) ; i++ ){
        Console.Write(Math.Round(result[i],3));
        if ( i != (result.GetLength(0)-1)){
            Console.Write(", ");
        }
    }
};
double[] FindAverageCol(int[,] matr){
    double[] arr = new double[matr.GetLength(1)];
    for (int i = 0 ; i < matr.GetLength(1) ; i++){
        for (int j = 0 ; j < matr.GetLength(0) ; j++){
            arr[i] = arr[i] + matr[j,i];
        }
        arr[i] = arr[i]/matr.GetLength(0);   
    }
    return arr;
}
int m = InputNumber("m");
int n = InputNumber("n");
int[,] matrix = new int[m,n];
matrix = ArrayGen(m,n);
PrintMatrix(matrix);
PrintArray(FindAverageCol(matrix));