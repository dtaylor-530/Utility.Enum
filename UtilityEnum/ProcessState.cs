﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityEnum
{
    //https://en.wikipedia.org/wiki/Process_state
    public enum  ProcessState : byte
    {
        None,
     Created,
     Ready,
     Running,
     Blocked,
     Terminated,

    }
}
