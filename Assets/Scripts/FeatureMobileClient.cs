using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureMobileClient : Feature{
    private static FeatureMobileClient _instance;

    public static FeatureMobileClient GetInstance(){
        return _instance ?? (_instance = new FeatureMobileClient());
    }

    public int initialCost { get { return 1000; } }
    public int income { get { return -50; } }
    public float SatisfactionModifier { get { return 0.03f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
