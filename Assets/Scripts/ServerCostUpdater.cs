using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ServerCostUpdater : MonoBehaviour {

    protected void Awake(){
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Continent")){
            Continent continent = go.GetComponent<Continent>();
            continent.OnServerChange += ServerCostsUpdated;
        }
    }

    protected void ServerCostsUpdated(int x){
        int counter = 0;

        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Continent")){
            Continent continent = go.GetComponent<Continent>();
            counter += continent.Servers;
        }

        GetComponent<Text>().text = "" + (counter*Server.costs);
    }

}
