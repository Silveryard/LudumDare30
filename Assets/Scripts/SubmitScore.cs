using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitScore : MonoBehaviour{

    public Text HighScoreText;
    public InputField UserInput;
    public Text Users;
    public Text SubitText;

    public void SubmitHighScore(){
        string url = "http://silveryard.bplaced.net/LudumDare30/AddHighScore.php";
        string url2 = "http://silveryard.bplaced.net/LudumDare30/GetHighScore.php";

        WWWForm form= new WWWForm();
        form.AddField("User", UserInput.value);
        form.AddField("Score", Users.text);
        WWW www = new WWW(url, form);

        WWWForm form2 = new WWWForm();
        WWW www2 = new WWW(url2, form2);

        StartCoroutine(WaitForRequest(www, www2));
    }

    private IEnumerator WaitForRequest(WWW www, WWW www2){
        yield return www;

        if (www.error == null){
            Debug.Log(www.text);
        }
        else{
            Debug.Log(www.error);
        }

        yield return null;
        SubitText.text = "Refreshing...";
        yield return null;
        yield return www2;

        if (www2.error == null)
            HighScoreText.text = www2.text.Replace("<br>", System.Environment.NewLine);
        else
            HighScoreText.text = www2.error;

        SubitText.text = "Thank you";
    }
	
}
