﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SegurosBeLife
{
    public class Logger
    {
        public static void Mensaje(String msg) {
            msg = DateTime.Now + "|" + msg + Environment.NewLine;
            File.AppendAllText(@"D:\Log.txt", msg);
        }
    }
}
