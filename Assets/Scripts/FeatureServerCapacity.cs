using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureServerCapacity : Feature{
    private static FeatureServerCapacity _instance;

    public static FeatureServerCapacity GetInstance(){
        return _instance ?? (_instance = new FeatureServerCapacity());
    }
    
    public int initialCost { get { return 10000; } }
    public int income { get { return -10; } }
    public float SatisfactionModifier { get { return 0; } }
    public void Equip(){
        Server.Capacity += 500;
    }

    public void Unequip(){
    }
}
