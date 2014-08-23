using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeButtons : MonoBehaviour{

    public Slider slider;

    public void BtnPause(){
        slider.value = 0;
    }

    public void BtnPlay(){
        slider.value = 1;
    }

}
