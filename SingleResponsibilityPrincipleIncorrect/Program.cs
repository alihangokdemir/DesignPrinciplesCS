﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            BackendDeveloper developer = new BackendDeveloper();
            developer.DevelopWebPage();
            developer.DesignWebPage();
        }
    }
}
