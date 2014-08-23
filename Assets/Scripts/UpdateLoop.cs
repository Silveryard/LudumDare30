using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class UpdateLoop : MonoBehaviour{

    public float WaitingTime = 10;
    private Coroutine c;

    public void StartLoop(){
        c = StartCoroutine(Loop());
    }
    private IEnumerator Loop(){
        while (true){
            GetIncome();
            PayServerCosts();
            CheckGameOver();
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
        if (Economy.Money <= 0 || Network.Satisfaction <= 0){
            Time.timeScale = 1;
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

}
