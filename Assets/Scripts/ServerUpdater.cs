using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ServerUpdater : MonoBehaviour{

    public Continent Continent;

    protected void Awake(){
        Continent.OnServerChange += OnServerUpdate;
    }

    protected void OnServerUpdate(int x){
        GetComponent<Text>().text = "" + x;
    }

}
