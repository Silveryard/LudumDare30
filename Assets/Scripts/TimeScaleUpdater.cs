using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScaleUpdater : MonoBehaviour{

    public Button Pause;
    public Button Play;

    public void TimeScaleUpdated(float f){
        GetComponent<Text>().text = "" + f.ToString("0.000") + "x";

        Time.timeScale = f;

        if (f == 0){
            Pause.interactable = false;
            Play.interactable = true;
        }
        else{
            Pause.interactable = true;
            Play.interactable = false;
        }
    }
	
}
