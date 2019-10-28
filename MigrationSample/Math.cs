using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationSample.SomeFolder;
using Newtonsoft.Json;

namespace MigrationSample
{
    public class Math
    {
        public int LastResult { get; private set; }
        public int Add(int a, int b)
        {
            LastResult =  a + b;
            return LastResult;
        }

        public string AsJson()
        {
            string output = JsonConvert.SerializeObject(this);
            return output;
        }

        public Result AsResult()
        {
            return new Result(LastResult);
        }
    }
}
