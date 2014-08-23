using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstServer : Command{

    public void Do(Continent continent){
        continent.Servers++;
        //continent.Users += 100;

        GameObject obj = GameObject.Find("Place your first server");
        obj.SetActive(false);

        obj = GameObject.FindWithTag("MainCamera");
        obj.GetComponent<UpdateLoop>().StartLoop();

        obj = GameObject.Find("PlaceServer");
        obj.GetComponent<Button>().interactable = true;

        obj = GameObject.Find("ManageFeatures");
        obj.GetComponent<Button>().interactable = true;

        obj = GameObject.Find("TimeScale");
        obj.SetActive(true);

        obj = GameObject.Find("TimeSlider");
        obj.GetComponent<Slider>().interactable = true;
        obj.GetComponent<Slider>().value = 1;

        Clickable.OnClickCommand = null;
    }

}
