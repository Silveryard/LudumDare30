using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour{

    public static Command OnClickCommand;

    private SpriteRenderer _renderer;

    protected void Awake(){
        _renderer = GetComponent<SpriteRenderer>();
    }

    protected void OnMouseEnter(){
        _renderer.color = new Color(1, 1, 1, 0.5f);
    }

    protected void OnMouseExit() {
        _renderer.color = new Color(1, 1, 1, 1);
    }

    protected void OnMouseDown(){
        OnClickCommand.Do(GetComponent<Continent>());
    }
	
}
