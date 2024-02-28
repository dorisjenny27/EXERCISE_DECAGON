namespace WEEK_2___CLASS_EXERCISE
{
    internal class Class_FOR_WEEK2_DAY1
    {
        string FirstORDefault(Func<List<string>, string, string> search, List<string> list, string term)
        {
            return search(list, term);
            
        
        }
    }
}
