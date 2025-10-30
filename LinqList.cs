namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> place = new List<string>();

            place.Add("Tokyo");
            place.Add("New York");
            place.Add("London");
            place.Add("Paris");


            var destination = place.Where(p => p.StartsWith("T") || p.StartsWith("N"))
                .Select(p => p.ToUpper())
                .OrderBy(p => p);

            foreach (var item in destination)
            {
                               Console.WriteLine(item);
            }

        }

    }
}
