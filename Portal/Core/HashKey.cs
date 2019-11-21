using System;
using System.Linq;
using System.Text;

namespace Portal.Core
{
    public class HashKey
    {
        private readonly string _hash;
        private HashKey(string hash)
        {
            _hash = hash;
        }

        /// <summary>
        /// // Calcula e gera a chave
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static HashKey From(string result)
        {
            var key = new StringBuilder();
            var random = new Random();

            var d = int.Parse(result.Split(",")[1].Split(" ")[1]);

            for (int i = 0; i < 4096; i++)
                key.Append(d * i * random.Next(100, 9999));

            return new HashKey(key.ToString());
        }

        /// <summary>
        /// // Soma números ímpares
        /// </summary>
        public int OddNumbersSum 
            => _hash.ToString().Select(c => c - '0').Where(o => o % 2 != 0).Sum(x => x);

        public string Value => _hash;
    }
}
