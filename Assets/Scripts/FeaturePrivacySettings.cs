using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeaturePrivacySettings : Feature{
    private static FeaturePrivacySettings _instance;

    public static FeaturePrivacySettings GetInstance(){
        return _instance ?? (_instance = new FeaturePrivacySettings());
    }


    public int initialCost { get { return 1500; } }
    public int income { get { return -10; } }
    public float SatisfactionModifier { get { return 0.025f; } }
    public void Equip(){
        
    }

    public void Unequip(){
    }
}
