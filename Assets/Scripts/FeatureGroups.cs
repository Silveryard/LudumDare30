using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureGroups : Feature{
    private static FeatureGroups _instance;

    public static FeatureGroups GetInstance(){
        return _instance ?? (_instance = new FeatureGroups());
    }

    public int initialCost { get { return 70; } }
    public int income { get { return -30; } }
    public float SatisfactionModifier { get { return 0.008f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
