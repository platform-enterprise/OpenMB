﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMOFGameEngine.Core
{
    public class GameVersion
    {
        private static int main = 0;
        private static int sub = 1;
        private static int modify = 5;

        public static string Current
        {
            get
            {
                return string.Format("{0}.{1}.{2}", main, sub, modify);
            }
        }
    }
}
