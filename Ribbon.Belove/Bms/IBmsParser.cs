using System;
using System.Collections.Generic;
using System.Text;
using Ribbon.Belove.Bms.Model;

namespace Ribbon.Belove.Bms
{
    public interface IBmsParser
    {
        BmsFile Parse(string fileName);
    }
}
