﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturyA
{
    static class DecimalToWords
    {

        public static String Convert(decimal num)
        {
            string part2 = "0";
            string part1 = ((int)(num))+"";
            char[] wordSet1 = { '0', '1', '2', '5', '6', '7', '8', '9' }; // złotych

            // If the number is 0, return zero.
            if (num == 0) return "zero";
            if (num.ToString().Length > 0 && num.ToString().IndexOf(',') > 0)
            {
                part2 = (num.ToString().Substring(num.ToString().IndexOf(',')+1));
            }

            string[] groups = {"", "tysiący", "milionów", "billion",
        "trillion", "quadrillion", "?", "??", "???", "????"};
            string[] groups2 = { "", "tysiące", "miliony" };
            string result = "";

            // Process the groups, smallest first.
            int group_num = 0;
            while (num > 0)
            {
                // Get the next group of three digits.
                double quotient = (double)Math.Truncate(num / 1000);
                int remainder = (int)(num - (decimal)quotient * 1000);
                num = (decimal)quotient;

                // Convert the group into words.
                if (remainder != 0)
                {
                    var groupName = "";
                    if (Array.IndexOf(wordSet1, (char)remainder) < 0)
                    {
                        groupName = groups[group_num];
                    }
                    else
                    {
                        groupName = groups2[group_num];
                        if (remainder == 1)
                        {
                            groupName = "tysiąc";
                        }
                    }
                    
                        result = GroupToWords(remainder) + " " + groups[group_num] + " " + result;
                }

                // Get ready for the next group.
                group_num++;
            }

            string currencyWord = "złote";
            char lastDigit = part1[part1.Length - 1];
            MessageBox.Show(lastDigit + "");
            if (Array.IndexOf(wordSet1, lastDigit) >= 0)
            {
                currencyWord = "złotych";
            }

            return result.Trim() + " " + currencyWord + " " +  part2 + "/100 groszy";

        }

        private static string GroupToWords(int num)
        {
            string[] one_to_nineteen = {"zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć", "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "pietnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewietnaście"};
            string[] multiples_of_ten = {"dwadzieścia", "trzydzieści", "czterdzieści", "piećdziesiąt", "sześćdziesiąt", "siedemdziesiat", "osiemdziesiąt", "dziewięćdziesiąt"};

            // If the number is 0, return an empty string.
            if (num == 0) return "";

            // Handle the hundreds digit.
            int digit;
            string result = "";
            if (num > 99)
            {
                digit = (int)(num / 100);
                num = num % 100;
                if (digit == 1)
                {
                    result = "sto";
                }
                else if (digit == 2)
                {
                    result = "dwieście";
                }
                else
                {
                    result = one_to_nineteen[digit];
                    result += (digit != 7) ? "sta" : "set";
                }
            }

            // If num = 0, we have hundreds only.
            if (num == 0) return result.Trim();

            // See if the rest is less than 20.
            if (num < 20)
            {
                // Look up the correct name.
                result += " " + one_to_nineteen[num];
            }
            else
            {
                // Handle the tens digit.
                digit = (int)(num / 10);
                num = num % 10;
                result += " " + multiples_of_ten[digit - 2];

                // Handle the final digit.
                if (num > 0)
                    result += " " + one_to_nineteen[num];
            }

            return result.Trim();
        }
    }
}
