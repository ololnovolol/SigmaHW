﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal interface ICassGenerator
    {
        List<Cassa> GenerateCasses(int count);
    }
}
