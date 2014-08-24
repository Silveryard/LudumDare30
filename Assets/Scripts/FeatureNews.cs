using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureNews : Feature{
    private static FeatureNews _instance;
    public static FeatureNews GetInstance(){
        return _instance ?? (_instance = new FeatureNews());
    }
    public int initialCost { get { return 1500; } }
    public int income { get { return -10; } }
    public float SatisfactionModifier { get { return 0.01f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
