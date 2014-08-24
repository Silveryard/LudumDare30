using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureTagging : Feature{
    private static FeatureTagging _instance;
    public static FeatureTagging GetInstance(){
        return _instance ?? (_instance = new FeatureTagging());
    }

    public int initialCost { get { return 800; } }
    public int income { get { return -10; } }
    public float SatisfactionModifier { get { return 0.015f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
