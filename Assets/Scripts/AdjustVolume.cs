using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdjustVolume : MonoBehaviour {

    public void VolumeUpdated(float f){
        GetComponent<Text>().text = "" + (int) f  + "%";

        Camera.main.gameObject.GetComponent<AudioSource>().volume = f/100;
    }
}
