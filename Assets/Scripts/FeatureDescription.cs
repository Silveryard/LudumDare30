using System;
using System.Net.Mime;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FeatureDescription : MonoBehaviour{

    public Text Title;
    public Text Costs;
    public Text Satisfaction;
    public Text Description;

    public void Close(){
        gameObject.SetActive(false);
    }

    public void Show(String title, String costs, String satisfaction, String description){
        Title.text = title;
        Costs.text = costs;
        Satisfaction.text = satisfaction;
        Description.text = description;
    }
	
}
