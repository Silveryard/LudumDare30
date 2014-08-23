using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IncomeUpdater : MonoBehaviour {

    protected void Awake(){
        Economy.OnIncomeChange += OnIncomeChange;
    }

    protected void OnIncomeChange(int x){
        GetComponent<Text>().text = "" + x;
    }

}
