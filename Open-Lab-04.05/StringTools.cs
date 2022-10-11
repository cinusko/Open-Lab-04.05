using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string fin = string.Empty;
                foreach (char x in orig)
                {
                    for (int j = 0; j < n; j++)
                    {
                        fin = fin + x;
                    }
                }
            return fin;

        }
    }
}
