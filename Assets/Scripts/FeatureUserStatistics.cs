using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureUserStatistics : Feature{
    private static FeatureUserStatistics _instance;

    public static FeatureUserStatistics GetInstance(){
        return _instance ?? (_instance = new FeatureUserStatistics());
    }

    public int initialCost { get { return 100; } }
    public int income { get { return 200; } }
    public float SatisfactionModifier { get { return -0.03f; } }
    
    public void Equip(){

    }

    public void Unequip(){
    }
}
