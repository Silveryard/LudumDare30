using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureEmbeddedVideos : Feature{
    private static FeatureEmbeddedVideos _instance;

    public static FeatureEmbeddedVideos GetInstance(){
        return _instance ?? (_instance = new FeatureEmbeddedVideos());
    }
    public int initialCost { get { return 1000; } }
    public int income { get { return -20; } }
    public float SatisfactionModifier { get { return 0.015f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
