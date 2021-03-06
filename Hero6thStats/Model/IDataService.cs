﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero6thStats.Model
{
    public interface IDataService
    {
        void GetData(Action<Stats, Exception> callback);
        Stats LoadDefaults();
    }
}
