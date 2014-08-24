using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

    protected void Awake(){
        Network.Features = new List<Feature>();
    }

    protected void Start(){
        Network.Satisfaction = 50;
        Economy.Money = 1000;
        Clickable.OnClickCommand = new FirstServer();
    }
	
}
