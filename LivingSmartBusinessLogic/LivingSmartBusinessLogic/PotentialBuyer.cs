﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PotentialBuyer
    {
        private Customer PotBuyer;

        #region Private Fields

        private DateTime _date;

        #endregion

        #region Properties

        public DateTime Date { get { return _date; } set { _date = value; } }

        #endregion
    }
}
