using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class UpdateLoop : MonoBehaviour{

    public Text HighScoreText;

    public float WaitingTime = 10;
    private Coroutine c;
    private bool _running;

    public void StartLoop(){
        _running = true;
        c = StartCoroutine(Loop());
    }
    private IEnumerator Loop(){
        while (_running){
            GetIncome();
            PayServerCosts();
            CheckGameOver();
            if (!_running) break;
            GenerateNewUser();
            CalcSatisfaction();
            yield return new WaitForSeconds(WaitingTime);
        }
    }
    
    private void GetIncome(){
        int income = 0;

        foreach (Feature feature in Network.Features){
            income += feature.income;
        }

        Economy.Income = income;
        Economy.Money += income;
    }
    private void PayServerCosts(){
        GameObject[] continents = GameObject.FindGameObjectsWithTag("Continent");

        foreach (GameObject go in continents){
            Continent continent = go.GetComponent<Continent>();

            Economy.Money -= continent.Servers*Server.costs;
        }
    }
    private void CheckGameOver(){
        if (Economy.Money <= 0 || ((int)Network.Satisfaction) <= 0){
            _running = false;
            Time.timeScale = 1;

            string url = "http://silveryard.bplaced.net/LudumDare30/GetHighScore.php";

            WWWForm form = new WWWForm();
            WWW www = new WWW(url, form);

            StartCoroutine(WaitForRequest(www));

            GetComponent<Animator>().SetTrigger("GameOver");
        }
    }
    private void GenerateNewUser(){
        List<GameObject> continentObjects = GameObject.FindGameObjectsWithTag("Continent").ToList();
        List<Continent> continents = new List<Continent>();

        foreach (GameObject obj in continentObjects){
            continents.Add(obj.GetComponent<Continent>());
        }

        List<int> randomModifiers = new List<int>();
        for (int i = 0; i < continents.Count; i++){
            randomModifiers.Add((int)(continents[i].Population * 1.5f));
        }

        for (int i = 0; i < continents.Count; i++){
            randomModifiers[i] *= (int)(continents[i].Users/2000f) + 1;
        }

        for (int i = 0; i < continents.Count; i++){
            continents[i].Users += Random.Range(0, (int)(randomModifiers[i] * ((float)(Network.Satisfaction - 20) / 100)));

            if (continents[i].Users > continents[i].Servers*Server.Capacity)
                continents[i].Users = continents[i].Servers*Server.Capacity;

            if (continents[i].Users < 0)
                continents[i].Users = 0;
        }
    }
    private void CalcSatisfaction(){
        List<GameObject> continentObjects = GameObject.FindGameObjectsWithTag("Continent").ToList();
        List<Continent> continents = new List<Continent>();

        foreach (GameObject obj in continentObjects){
            continents.Add(obj.GetComponent<Continent>());
        }

        float satisfactionModifier = 0.0f;

        int popularity = 0;
        foreach (Continent continent in continents){
            popularity += continent.Users;
        }

        satisfactionModifier -= popularity/100000f;

        foreach (Feature feature in Network.Features){
            satisfactionModifier += feature.SatisfactionModifier;
        }

        float newSatisfaction = Network.Satisfaction + Network.Satisfaction*satisfactionModifier;
        if (newSatisfaction > 100.0f)
            newSatisfaction = 100.0f;

        Network.Satisfaction =  newSatisfaction;
    }

    private IEnumerator WaitForRequest(WWW www){
        yield return www;

        if (www.error == null)
            HighScoreText.text = www.text.Replace("<br>", System.Environment.NewLine);
        else
            HighScoreText.text = www.error;
    }
}
