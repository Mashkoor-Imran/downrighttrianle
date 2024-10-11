public class Triangle
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Please Enter the Number");
        int rows = Convert.ToInt16(Console.ReadLine());
        for (int i = rows; i > 0; i--)
        {
            for (int j = rows; j >= i; j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }



        //int n = 5;
        //for (int i = n; i >0; i--)
        //{
        //    for (int j = 5; j >= i; j--)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}


        /*  int row = 5;
          for (int i = row; i > 0; i--)
          {
              for(int j=0; j<i; j++)
              {
                  Console.Write("* ");
              }
              Console.WriteLine();
          }*/
    }

}

