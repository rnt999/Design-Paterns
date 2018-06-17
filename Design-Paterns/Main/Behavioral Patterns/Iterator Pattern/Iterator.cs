﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Iterator_Pattern
{
    public interface Iterator
    {
        object Current { get; }
        bool Next();
    }
}
