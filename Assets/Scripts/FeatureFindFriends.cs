using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureFindFriends : Feature{
    private static FeatureFindFriends _instance;
    public static FeatureFindFriends GetInstance(){
        return _instance ?? (_instance = new FeatureFindFriends());
    }
    
    public int initialCost { get { return 500; } }
    public int income { get { return -15; } }
    public float SatisfactionModifier { get { return 0.005f; } }
    
    
    public void Equip(){
    }

    public void Unequip(){
    }
}
