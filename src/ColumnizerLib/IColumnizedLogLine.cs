﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColumnizerLib
{
    public interface IColumnizedLogLine
    {
        #region Properties

        ILogLine LogLine { get; }


        IColumn[] ColumnValues { get; }

        #endregion
    }
}