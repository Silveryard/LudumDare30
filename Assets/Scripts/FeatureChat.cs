using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureChat : Feature{

    private static FeatureChat _instance;

    public static FeatureChat GetInstance(){
        return _instance ?? (_instance = new FeatureChat());
    }

    public int initialCost { get { return 200; } }
    public int income { get { return -20; } }
    public float SatisfactionModifier { get { return 0.01f; } }
    
    public void Equip(){
    }

    public void Unequip(){
    }
}
