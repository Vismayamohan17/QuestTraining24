using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp
{
    internal class Program
    {
        //private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-GB");
            var price = 100;
            var formattedPrice = price.ToString("c",ci);
            Console.WriteLine(formattedPrice);

        }
    }
}
