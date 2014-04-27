using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3whisky.configuration
{
    public interface IConfiguration
    {
        string ConnectionString
        { 
            get; 
        }
    }
}
