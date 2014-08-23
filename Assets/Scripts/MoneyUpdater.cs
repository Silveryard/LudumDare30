using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyUpdater : MonoBehaviour {

    protected void Awake(){
        Economy.OnMoneyChange += OnMoneyChange;
    }

    protected void OnMoneyChange(int x){
        GetComponent<Text>().text = "" + x;
    }
	
}
