using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguages
{
    public class Language
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string ChiefDeveloper { get; set; }
        public string Predecessor { get; set; }

        /// <summary>
        /// Creates a <see cref="Language"/> object from a tab-separated string.
        /// </summary>
        /// <param name="tsvLine">The tab-separated string containing language information.</param>
        /// <returns>A <see cref="Language"/> object representing the parsed data.</returns>
        /// <exception cref="ArgumentException">Thrown when the input string has an invalid format.</exception>
        public static Language FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Language lang = new Language(
              Convert.ToInt32(values[0]),
              Convert.ToString(values[1]),
              Convert.ToString(values[2]),
              Convert.ToString(values[3]));
            return lang;
        }

        /// <summary>
        /// Creates a <see cref="Language"/> object from a tab-separated string.
        /// </summary>
        /// <param name="year">The year when the language was introduced.</param>
        /// <param name="name">The name of the language.</param>
        /// <param name="chiefDeveloper">The chief developer(s) of the language.</param>
        /// <param name="predecessors">The predecessor(s) of the language.</param>
        public Language(int year, string name, string chiefDeveloper, string predecessor)
        {
            this.Year = year;
            this.Name = name;
            this.ChiefDeveloper = chiefDeveloper;
            this.Predecessor = predecessor;
        }

        /// <summary>
        /// Returns a string that represents the current <see cref="Language"/> object.
        /// </summary>
        /// <returns>A string that represents the current <see cref="Language"/> object.</returns>
        public override string ToString()
        {
            return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessor}";
        }
    }
}
