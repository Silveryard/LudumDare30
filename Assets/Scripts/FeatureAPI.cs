using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureAPI : Feature{
    private static FeatureAPI _instance;
    public static FeatureAPI GetInstance(){
        return _instance ?? (_instance = new FeatureAPI());
    }

    public int initialCost { get { return 2500; } }
    public int income { get { return -20; } }
    public float SatisfactionModifier { get { return 0.012f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
