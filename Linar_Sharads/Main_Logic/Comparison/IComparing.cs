﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Logic
{
    interface IComparing<T>
    {
        T Compare(List<float> listOfKoefs);
    }
}
