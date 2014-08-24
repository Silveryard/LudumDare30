using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdAmountUpdater : MonoBehaviour {

    public void Updated(){
        FeatureAds.GetInstance().Amount = (int)GetComponent<Slider>().value;
        Economy.RecalcIncome();
    }

}
