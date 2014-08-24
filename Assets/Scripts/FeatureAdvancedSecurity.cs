using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureAdvancedSecurity : Feature{
    private static FeatureAdvancedSecurity _instance;

    public static FeatureAdvancedSecurity GetInstance(){
        return _instance ?? (_instance = new FeatureAdvancedSecurity());
    }

    public int initialCost { get { return 3000; } }
    public int income { get { return -35; } }
    public float SatisfactionModifier { get { return 0.017f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
