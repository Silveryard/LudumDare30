using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

    public void Reload(){
        Network.CleanUpEvents();
        Clickable.OnClickCommand = null;
        Economy.CleanUpEvents();
        Network.Features = new List<Feature>();
        Server.costs = 50;
        Server.Capacity = 1000;
        Application.LoadLevel(Application.loadedLevel);
    }
}
