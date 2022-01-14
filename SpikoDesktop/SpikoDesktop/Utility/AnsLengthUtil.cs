using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Utility
{
    class AnsLengthUtil
    {
        static AnsLengthUtil _instance;
        private AnsLengthUtil() { }

        public static AnsLengthUtil GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AnsLengthUtil();
            }
            return _instance;
        }
        public int WordsLength { get; set; }
        public String Word { get; set; }

        public bool CheckWords(string ans, int len)
        {
            WordsLength = 0;
            if (ans.Trim() != "")
            {
                WordsLength = 1;
            }
            for (int i = 0; i < ans.Length; i++)
            {
                if (i >= 0 && i < ans.Length - 1)
                {
                    if (ans[i] == 32 && ans[i + 1] != 32)
                    {
                        WordsLength++;
                    }
                }
            }
            if (WordsLength <= len)
            {
                return true;
            }
            else if (WordsLength > len)
            {
                GetMaxWords(ans, len);
                return true;
            }
            return false;
        }

        public void GetMaxWords(string ans, int len)
        {
            Word = "";
            int length = 0;
            int l = 0;
            for (int i = 0; i < ans.Length && length < len; i++)
            {
                if (i >= 0 && i < ans.Length - 1)
                {
                    if (ans[i] == 32 && ans[i + 1] != 32)
                    {
                        length++;
                    }
                }
                if (ans[i] == 32)
                {
                    for (int j = l; j < i; j++)
                    {
                        Word = Word + ans[j];
                    }
                    l = i;
                }
            }
            Word += " ";
        }
    }
}
