using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FeatureFlashGames : Feature{
    private static FeatureFlashGames _instance;

    public static FeatureFlashGames GetInstance(){
        return _instance ?? (_instance = new FeatureFlashGames());
    }

    public int initialCost { get { return 6500; }}
    public int income { get { return 100; } }
    public float SatisfactionModifier { get { return 0.0005f; } }
    public void Equip(){
    }

    public void Unequip(){
    }
}
