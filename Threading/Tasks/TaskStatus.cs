﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UEx.Threading.Tasks
{
    public enum TaskStatus
    {
        Canceled,
        Created,
        Faulted,
        RanToCompletion,
        Running,
        WaitingForActivation,
        WaitingForChildrenToComplete,
        WaitingToRun,
    }
}