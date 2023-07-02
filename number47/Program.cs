int InputNumber(string message){
    Console.Write("Введите {0} : " , message);
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
double GetRandDouble(){
    Random rnd = new Random();
    return (Math.Round((rnd.Next(-9 , 9) + rnd.NextDouble()),1));
}
double[,] ArrayGen(int m , int n){
    double[,] matrix = new double[m,n];
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < n ; j++){
            matrix[i,j] = GetRandDouble();
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matr){
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(ArrayGen(InputNumber("m"), InputNumber("n")));