using System;
using System.Collections.Generic;
using System.Text;

namespace ProtocolAnalyzer.DataClasses
{
    class LinDataItem
    {
        public DateTime Time { get; set; }
        public byte Identifier { get; set; }
        public byte[] Data { get; set; }
        public byte CheckSum { get; set; }
    }
}
