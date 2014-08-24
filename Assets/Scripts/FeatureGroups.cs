using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureGroups : Feature{
    private static FeatureGroups _instance;

    public static FeatureGroups GetInstance(){
        return _instance ?? (_instance = new FeatureGroups());
    }

    public int initialCost { get { return 900; } }
    public int income { get { return -20; } }
    public float SatisfactionModifier { get { return 0.01f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
