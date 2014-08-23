using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserUpdater : MonoBehaviour{

    public Continent Continent;

    protected void Awake(){
        Continent.OnUsersChange += OnUserChange;
    }

    protected void OnUserChange(int x){
        GetComponent<Text>().text = "" + x;
    }

}