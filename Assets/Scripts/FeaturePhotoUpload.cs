using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeaturePhotoUpload : Feature{
    private static FeaturePhotoUpload _instance;

    public static FeaturePhotoUpload GetInstance(){
        return _instance ?? (_instance = new FeaturePhotoUpload());
    }

    public int initialCost { get { return 250; } }
    public int income { get { return -30; } }
    public float SatisfactionModifier { get { return 0.012f; } }
    public void Equip(){
        
    }

    public void Unequip(){
    }
}
