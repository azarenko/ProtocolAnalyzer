using System;
using System.Collections.Generic;
using System.Text;

namespace ProtocolAnalyzer
{
    public static class Utilites
    {
        public static void CopyToByteArray(byte[] dst, byte[] src, int startdst, int startsrc, int count)
        {
            for(int i=0; i<count ;i++)
            {
                dst[startdst + i] = src[startsrc + i];
            }
        }
    }
}
