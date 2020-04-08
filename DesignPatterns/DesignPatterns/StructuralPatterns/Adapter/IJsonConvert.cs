using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //interface for making compatibility that takes input as xml and return output as json
    public interface IJsonConvert
    {
        string ConvertToJson(string xml);
    }
}
