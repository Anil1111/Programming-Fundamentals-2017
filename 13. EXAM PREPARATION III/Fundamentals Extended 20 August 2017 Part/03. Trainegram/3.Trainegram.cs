using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^(?<locomotive>\<\[[^A-Za-z0-9]*\][\.]{1})+(?<wagoons>[\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";
            var input = "<[(_#/}$)$]..[GO5A]..[G5]..[3W4].";
            var matches = Regex.Matches(input,regex);

            List<char> train = new List<char>();
            foreach (Match item in matches)
            {
                train.Add(item.Groups["locomotive"].Value);
            }
            
        }
    }
}
