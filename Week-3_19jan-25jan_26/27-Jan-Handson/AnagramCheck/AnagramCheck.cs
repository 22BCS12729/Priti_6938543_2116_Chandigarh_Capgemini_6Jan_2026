using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramCheck
{
    internal class AnagramCheck
    {
               public static bool IsAnagram(string s1, string s2)
                {
                    if (s1.Length != s2.Length)
                        return false;

                    Hashtable map = new Hashtable();

                    foreach (char ch in s1)
                    {
                        if (map.ContainsKey(ch))
                            map[ch] = (int)map[ch] + 1;
                        else
                            map[ch] = 1;
                    }

                    foreach (char ch in s2)
                    {
                        if (!map.ContainsKey(ch))
                            return false;

                        map[ch] = (int)map[ch] - 1;

                        if ((int)map[ch] == 0)
                            map.Remove(ch);
                    }

                    return map.Count == 0;
                     }
    
                    }
                }
