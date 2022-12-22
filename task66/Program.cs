int rec(int M, int N)
{
    if(N<M) return 0;
    return rec(M, N-1) + N;
}
Console.Clear();
Console.WriteLine("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(M,N));