using System;
using System.Collections.Generic;
using System.Text;

namespace YT_Master.MyCode
{
    public class LinksReader
    {

        public List<string> GetLinkList()
        {
            string body = System.IO.File.ReadAllText(@"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\Stuff\FireFoxZoombie\YT_Master\Files\LinkList-html.txt");

            List<string> ret = new List<string>();
            int index = 0;
            while (index < body.Length-10)
            {
                string tmp = _getParamVal(ref body, ref index);
                if (tmp != "")
                {
                    ret.Add(tmp);
                }
                else
                {
                    break;
                }
            }


            return ret;
        }

        private string _getParamVal(ref string body, ref int startIndex)
        {
            string ret = "";
            char critic = '"';
            string hrf = "href=\"";
            if (isNext(ref body, ref startIndex, hrf))
            {
                startIndex += hrf.Length;
                while (body[startIndex] != critic)
                {
                    ret += body[startIndex];
                    startIndex++;
                }
                startIndex += ret.Length;
            }
            return ret;
        }

        protected bool isNext(ref string body, ref int startIndex, string nextString)
        {
            for (int i = startIndex; i < body.Length; i++)
            {
                bool notOk = false;
                for (int j = 0; j < nextString.Length; j++)
                {
                    if (body[(i + j)] != nextString[j])
                    {
                        notOk = true;
                        break;
                    }
                }
                if (!notOk)
                {
                    startIndex = i;
                    return true;
                }
            }
            return false;
        }
    }
}
