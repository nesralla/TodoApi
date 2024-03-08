using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Utils
{
    public enum ProjectTaskStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public enum ProjectTaskPriority
    {
        Low,
        Medium,
        High
    }

}