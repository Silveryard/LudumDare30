using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalUserUpdater : MonoBehaviour {


    protected void Awake(){
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Continent")){
            obj.GetComponent<Continent>().OnUsersChange += OnUserUpdate;
        }
    }

    protected void OnUserUpdate(int x){
        int users = 0;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Continent")){
            users += obj.GetComponent<Continent>().Users;
        }

        GetComponent<Text>().text = "" + users;
    }

}
