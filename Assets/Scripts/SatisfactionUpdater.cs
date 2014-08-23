using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SatisfactionUpdater : MonoBehaviour {

    protected void Awake(){
        Network.OnSatisfactionChange += OnSatisfactionChange;
    }

    protected void OnSatisfactionChange(int x){
        GetComponent<Text>().text = "" + x;
    }
	
}
