// Вывести на экран сумму элементов двумерного прямоугольного массива которые находятся на обратной 
// диагонали.
Console.WriteLine("Enter the count of rows");
string inputRow = Console.ReadLine();
Console.WriteLine("Enter the count of cells");
string inputCells = Console.ReadLine();


static bool IsImputINT (string input)
    
{
    int value = 0;
    bool isInt = int.TryParse(input, out value);
    return isInt;
}

    while (IsImputINT(inputRow)==false)
    {
        Console.WriteLine("Enter the row count it must be int");
        inputRow = Console.ReadLine();
    }
  
   int rowCount = Convert.ToInt32(inputRow);
    
while (IsImputINT(inputCells)==false)
{
    Console.WriteLine("Enter the count of cells it must be INT");
    inputCells = Console.ReadLine();
}
   int cellCount = Convert.ToInt32(inputCells);


static int[,] FillTableRandomInt(int [,]array )
{
    Random random = new Random();
   
    for (int i = 0; i <array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0,33);
        }
    }
    return array;
}
int[,] myarray = new int[rowCount, cellCount];
myarray = FillTableRandomInt(myarray);
void PrintTable(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintTable(myarray);
 int SumOfDiagonalElements(int[,] array)

{
    int sum = 0;
    
        for (int j = array.GetLength(1) - 1 ,i =0; j >=0 && i<array.GetLength(0) ; j--,i++)
        {
            sum += array[i, j];
        }
    
    return sum;
}
int mysum = SumOfDiagonalElements(myarray);
Console.WriteLine(mysum);
Console.ReadLine();
