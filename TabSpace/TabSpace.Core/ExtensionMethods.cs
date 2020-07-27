using System;
using System.Collections.Generic;
using System.Linq;

namespace TabSpace.Core
{
    public static class ExtensionMethods
    {
        public static string[] ToNewlineArray(this string value) => value.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        public static string ToSpaces(this string value, int group)
        {
            var tmpList = new List<string>();
            while (value.Length != 0)
            {
                var charsToRemove = 0;
                
                if (value.Length < group) group = value.Length;

                var charGroup = value.ToCharArray(0, group);

                if (charGroup.Contains('\t'))
                {
                    var tGroup = "";
                    foreach (var c in value.ToCharArray(0, group))
                    {
                        if (!c.Equals('\t'))
                        {
                            charsToRemove += 1;
                            tGroup += c;
                        }
                        else
                        {
                            charsToRemove += 1;
                            tGroup = tGroup.PadRight(4, ' ');
                            break;
                        }
                    }
                    tmpList.Add(tGroup);
                }
                else
                {
                    tmpList.Add(new string(charGroup));
                    charsToRemove = group;
                }

                value = value.Remove(0, charsToRemove);
            }

            return string.Join("", tmpList);            
        }
    }
}
