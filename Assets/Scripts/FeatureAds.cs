using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using UnityEngine;

public class FeatureAds : Feature{
    private static FeatureAds _instance;
    public static FeatureAds GetInstance(){
        return _instance ?? (_instance = new FeatureAds());
    }

    public int Amount;

    public int initialCost { get { return 0; } }
    public int income { get { return Amount * 5; }}
    public float SatisfactionModifier
    {
        get
        {
            return 0 - ((float)Amount / 5000);
    }}

    public FeatureAds(){
        Amount = 20;
    }

    public void Equip(){
        
    }

    public void Unequip(){
        
    }
}
