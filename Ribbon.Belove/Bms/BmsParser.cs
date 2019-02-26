using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Text;
using Ribbon.Belove.Bms.Model;

namespace Ribbon.Belove.Bms
{
    public class BmsParser : IBmsParser
    {
        private readonly IFileSystem _iosys;

        public BmsParser(IFileSystem iosys)
        {
            _iosys = iosys;
        }
        public BmsFile Parse(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
