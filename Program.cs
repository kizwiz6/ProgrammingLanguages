namespace ProgrammingLanguages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var lang in languages)
            {
                Console.WriteLine(lang.ToString());
            }

            // Write a query that returns a string for each language. It should include the year, name, and chief developer of each language.
            var basicInfos = languages.Select(x => $"{x.Year}, {x.Name}, {x.ChiefDeveloper}.");

            // foreach(var lang in basicInfos)
            // {
            //   Console.WriteLine(lang);
            // }

            // Find the language(s) with the name "C#". Use the ToString() method to print the results to the console.
            var cSharpLangs = languages.Where(x => x.Name == "C#");

            // foreach(var lang in cSharpLangs)
            // {
            //   Console.WriteLine(lang.ToString());
            // }


            // Find all of the languages which have "Microsoft" included in their ChiefDeveloper property.
            var microsoftLangs = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));

            // foreach(var lang in microsoftLangs)
            // {
            //   Console.WriteLine(lang.ToString());
            // }


            // Find all of the languages that descend from Lisp.
            var lispLangs = languages.Where(x => x.Predecessor.Contains("Lisp"));

            // foreach(var lang in lispLangs)
            // {
            //   Console.WriteLine(lang.ToString());
            // }

            // Find all of the language names that contain the word "Script" (capital S). Make sure the query only selects the name of each language.
            var scriptLangs = languages
            .Where(x => x.Name.Contains("Script"))
            .Select(x => x.Name);

            // foreach (var lang in scriptLangs)
            // {
            //   Console.WriteLine(lang);
            // }


            // How many languages are included in the languages list?
            Console.WriteLine($"Number of languages: {languages.Count}.");


            // How many languages were launched between 1995 and 2005?
            var nearMilleniumLangs = languages.Where(x => x.Year >= 1995 && x.Year <= 2005);

            Console.WriteLine($"Near millenium languages: {nearMilleniumLangs.Count()}.");


            // Print a string for each of those near-millennium languages.

            var nearMilleniumLangs2 = nearMilleniumLangs
            .Select(x => $"{x.Name} was invented in {x.Year}.");

            // foreach (var lang in nearMilleniumLangs2)
            // {
            //   Console.WriteLine(lang);
            // }

            // ToStringPrintAll(lispLangs);

            //ToStringPrintAll(nearMilleniumLangs);


            // Sorts the list alphebetically
            var ordered = languages.OrderBy(x => x.Name);
            //ToStringPrintAll(ordered);

            // Finds the oldest language in the list using Min() method
            var oldest = languages.Min(x => x.Year);

            Console.WriteLine(oldest);
        }

        // Write a method PrettyPrintAll() that handles that for us. It should:
        public static void ToStringPrintAll(IEnumerable<Language> langs)
        {
            foreach (Language lang in langs)
            {
                Console.WriteLine(lang.ToString());
            }
        }

        // You might have also used foreach loops to print every query result in this project. Write a method PrintAll() that handles that for us.
        public static void PrintAll(IEnumerable<Object> sequence)
        {
            foreach (Object obj in sequence)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
