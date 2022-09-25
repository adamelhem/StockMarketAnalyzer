// See https://aka.ms/new-console-template for more information
public class StockMarketAnalizer
{ 

    public StockMarketAnalizer( )
    {
    }

    public (int, int) analyze(int[] input)
    {
        var len = input.Length;
        int index_min = 0;
        int index_max = len-1;
        int min = int.MaxValue;
        int max = 0;

        // Big O = n
        for (int i = 0; i < input.Length; i++ )
        {
            if (input[i]<min)
            {
                min = input[i];
                index_min = i;
            }

            if (input[i] > max && index_max > index_min)
            {
                max = input[i];
                index_max = i;
            }
        }

        var result = (max , min);
        return result;
    }

}