// See https://aka.ms/new-console-template for more information
var input = new int[] {1,4,5,6,9,2,0,3};
var stockMarketAnalizer = new StockMarketAnalizer();
(int,int) result  =  stockMarketAnalizer.analyze(input);
Console.WriteLine($"Rresult:{result}");