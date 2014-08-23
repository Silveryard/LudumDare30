using UnityEngine;
using System.Collections;

public class BtnPlaceServer : MonoBehaviour {

    public void PlaceServer(){
        Clickable.OnClickCommand = new AddServer();
    }
	
}
