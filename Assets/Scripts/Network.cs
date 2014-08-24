using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Network{

    public delegate void IntegerDelegate(int x);

    public static event IntegerDelegate OnSatisfactionChange;

    public static List<Feature> Features; 

    private static float _satisfaction;

    public static float Satisfaction{
        get { return _satisfaction; }
        set{
            _satisfaction = value;
            if (OnSatisfactionChange != null)
                OnSatisfactionChange((int)value);
        }
    }

    public static void CleanUpEvents(){
        OnSatisfactionChange = null;
    }

}
