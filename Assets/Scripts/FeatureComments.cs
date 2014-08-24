using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureComments : Feature{
    private static FeatureComments _instance;

    public static FeatureComments GetInstance(){
        return _instance ?? (_instance = new FeatureComments());
    }
    
    public int initialCost { get { return 1000; } }
    public int income { get { return -20; } }
    public float SatisfactionModifier { get { return 0.012f; } }
    
    
    public void Equip(){
    }

    public void Unequip(){
    }
}
