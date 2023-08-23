using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var decryptedNumbers = cryptedNumbers.Select(cryptedNumber =>
            {
                var result = cryptedNumber.Select(c =>
                {
                    return c switch
                    {
                        '!' => '1',
                        '@' => '2',
                        '#' => '3',
                        '$' => '4',
                        '%' => '5',
                        '^' => '6',
                        '&' => '7',
                        '*' => '8',
                        '(' => '9',
                        ')' => '0',
                        _ => c
                    };
                });

                return new string(result.ToArray());
            });

            Console.WriteLine(string.Join(Environment.NewLine, decryptedNumbers));
        }
    }
}
