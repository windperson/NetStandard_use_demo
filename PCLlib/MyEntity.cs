﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCLlib
{
    public class MyEntity : NetStandardClassLibrary.IContract
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
