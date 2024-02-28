namespace WEEK_2___CLASS_EXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func < int, int, double> sum = delegate (int x, int y) 
            //        { return x + y; };
            //    Console.WriteLine(sum(1, 2));

            Func<int, int, double> sum =
                delegate (int x, int y)   //=> to convert to LAMBDA
                {
                    return x + y;
                };

            static void AddNumbers(Func<int, int, double> sum)
            {
                int x = 6;
                int y = 7;
                sum(x, y);
            }

            AddNumbers(sum);


            //var list = new List<string>
            //{
            //    "Ore",
            //    "Ada",
            //    "Abike"
            //};
            //var f = list.FirstOrDefault(x=> x == "Abike");

            //Func<List<string>, string, string> search = delegate (List<string> list, string term)
            //{
            //    foreach (var item in list)
            //    {
            //        if (item == term)
            //        {
            //            return item;
            //        }
            //    }
            //    return null;
            //};
            //Console.WriteLine((search, list, "Ore"));


        }


    }
}

