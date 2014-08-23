﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Economy{

    public delegate void IntegerDelegate(int x);

    public static event IntegerDelegate OnMoneyChange;
    public static event IntegerDelegate OnIncomeChange;

    private static int _money;
    private static int _income;

    public static int Money{
        get { return _money; }
        set{
            _money = value;
            if (OnMoneyChange != null)
                OnMoneyChange(value);
        }
    }

    public static int Income{
        get { return _income; }
        set{
            _income = value;
            if (OnIncomeChange != null)
                OnIncomeChange(value);
        }
    }
}