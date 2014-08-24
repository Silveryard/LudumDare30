using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FeatureButtons : MonoBehaviour{

    public Button PlaceServer;
    public GameObject FeatureList;
    public GameObject FeatureDescription;

    public Slider AdSlider;

    public Button ButtonToggleAds;
    public Button ButtonToggleChat;
    public Button ButtonToggleMobileClient;
    public Button ButtonTogglePrivacySettings;
    public Button ButtonToggleUserStatistics;
    public Button ButtonTogglePhotoUpload;
    public Button ButtonToggleGroups;
    public Button ButtonToggleServerCapacity;
    public Button ButtonToggleFlashGames;
    public Button ButtonToggleFindFriends;
    public Button ButtonToggleTagging;

    public Button ButtonAds;
    public Button ButtonChat;
    public Button ButtonMobileClient;
    public Button ButtonPrivacySettings;
    public Button ButtonUserStatistics;
    public Button ButtonPhotoUpload;
    public Button ButtonGroups;
    public Button ButtonServerCapacity;
    public Button ButtonFlashGames;
    public Button ButtonFindFriends;
    public Button ButtonTagging;

    private float _oldTimeScale;

    public void BtnManageFeatures(){
        GameObject[] continents = GameObject.FindGameObjectsWithTag("Continent");
        foreach (GameObject continent in continents){
            continent.GetComponent<PolygonCollider2D>().enabled = false;
        }

        GetComponent<Button>().interactable = false;
        PlaceServer.interactable = false;
        FeatureList.SetActive(true);

        _oldTimeScale = Time.timeScale;
        GameObject.Find("TimeSlider").GetComponent<Slider>().value = 0;
    }
    public void BtnExitFeatureList(){
        GameObject[] continents = GameObject.FindGameObjectsWithTag("Continent");
        foreach (GameObject continent in continents){
            continent.GetComponent<PolygonCollider2D>().enabled = true;
        }

        GetComponent<Button>().interactable = true;
        PlaceServer.interactable = true;
        FeatureList.SetActive(false);
        FeatureDescription.SetActive(false);

        GameObject.Find("TimeSlider").GetComponent<Slider>().value = _oldTimeScale;
    }
   
    public void BtnToggleAds(){
        if (Network.Features.Contains(FeatureAds.GetInstance())){
            AdSlider.enabled = false;
            RemoveFeature(ButtonToggleAds, FeatureAds.GetInstance());
        }
        else{
            AdSlider.enabled = true;
            AddFeature(ButtonToggleAds, FeatureAds.GetInstance());
        }
    }
    public void BtnToggleChat(){
        if (Network.Features.Contains(FeatureChat.GetInstance())){
            RemoveFeature(ButtonToggleChat, FeatureChat.GetInstance());
        }
        else{
            AddFeature(ButtonToggleChat, FeatureChat.GetInstance());
        }
    }
    public void BtnToggleMobileClient(){
        if (Network.Features.Contains(FeatureMobileClient.GetInstance()))
            RemoveFeature(ButtonToggleMobileClient, FeatureMobileClient.GetInstance());
        else AddFeature(ButtonToggleMobileClient, FeatureMobileClient.GetInstance());
    }
    public void BtnTogglePrivacySettings(){
        if (Network.Features.Contains(FeaturePrivacySettings.GetInstance()))
            RemoveFeature(ButtonTogglePrivacySettings, FeaturePrivacySettings.GetInstance());
        else AddFeature(ButtonTogglePrivacySettings, FeaturePrivacySettings.GetInstance());
    }
    public void BtnToggleUserStatistics(){
        if (Network.Features.Contains(FeatureUserStatistics.GetInstance()))
            RemoveFeature(ButtonToggleUserStatistics, FeatureUserStatistics.GetInstance());
        else AddFeature(ButtonToggleUserStatistics, FeatureUserStatistics.GetInstance());
    }
    public void BtnTogglePhotoUpload(){
        if (Network.Features.Contains(FeaturePhotoUpload.GetInstance()))
            RemoveFeature(ButtonTogglePhotoUpload, FeaturePhotoUpload.GetInstance());
        else AddFeature(ButtonTogglePhotoUpload, FeaturePhotoUpload.GetInstance());
    }
    public void BtnToggleGroups(){
        if (Network.Features.Contains(FeatureGroups.GetInstance()))
            RemoveFeature(ButtonToggleGroups, FeatureGroups.GetInstance());
        else AddFeature(ButtonToggleGroups, FeatureGroups.GetInstance());
    }
    public void BtnToggleServerCapacity(){
        AddFeature(ButtonToggleServerCapacity, FeatureServerCapacity.GetInstance());
        ButtonToggleServerCapacity.GetComponent<Text>().text = "Add";
    }
    public void BtnToggleFlashGames(){
        if(Network.Features.Contains(FeatureFlashGames.GetInstance())) RemoveFeature(ButtonToggleFlashGames, FeatureFlashGames.GetInstance());
        else AddFeature(ButtonToggleFlashGames, FeatureFlashGames.GetInstance());
    }
    public void BtnToggleFindFriends(){
        if(Network.Features.Contains(FeatureFindFriends.GetInstance())) RemoveFeature(ButtonToggleFindFriends, FeatureFindFriends.GetInstance());
        else AddFeature(ButtonToggleFindFriends, FeatureFindFriends.GetInstance());
    }
    public void BtnToggleTagging(){
        if(Network.Features.Contains(FeatureTagging.GetInstance()))RemoveFeature(ButtonToggleTagging, FeatureTagging.GetInstance());
        else AddFeature(ButtonToggleTagging, FeatureTagging.GetInstance());
    }

    public void BtnAds(){
        ShowDescription("Ads", "0 / 0 to -500", "0 to -20", "Let´s place some nice Ads on your website. Your users might not love it but you need the money. Just don´t exaggerate.");
    }
    public void BtnChat() {
        ShowDescription("Chat", FeatureChat.GetInstance().initialCost + " / " + FeatureChat.GetInstance().income * -1, "" +FeatureChat.GetInstance().SatisfactionModifier * 1000, "Email is nice but instant messaging is nicer and cooler. Managing this service might cost a bit but your users will love it!");
    }
    public void BtnMobileClient(){
        ShowDescription("Mobile App", FeatureMobileClient.GetInstance().initialCost + " / " + FeatureMobileClient.GetInstance().income * -1, "" + FeatureMobileClient.GetInstance().SatisfactionModifier * 1000, "Being social at home is only half the live. Develop a nice battery consuming app so they can be connected with their friends everytime anywhere.");
    }
    public void BtnPrivacySettings(){
        ShowDescription("Privacy Settings", FeaturePrivacySettings.GetInstance().initialCost + " / " + FeaturePrivacySettings.GetInstance().income * -1, "" + FeaturePrivacySettings.GetInstance().SatisfactionModifier * 1000, "Some like when everyone knows everthing about you some don´t. Give them the ability to hide specific information from strangers. Or your familiy.");
    }
    public void BtnUserStatistics(){
        ShowDescription("User Statistics", FeatureUserStatistics.GetInstance().initialCost + " / " + FeatureUserStatistics.GetInstance().income * -1, ""+FeatureUserStatistics.GetInstance().SatisfactionModifier * 1000, "Need money? Send us information about your users. Absolutely harmless. Greetings, Capitalism");
    }
    public void BtnPhotoUpload(){
        ShowDescription("Photo Upload", FeaturePhotoUpload.GetInstance().initialCost + " / " + FeaturePhotoUpload.GetInstance().income * -1, ""+FeaturePhotoUpload.GetInstance().SatisfactionModifier * 1000, "What is cooler: Writing about this absolutely epic trip or posting photos about it? Just pay some webspace pictures are bigger than letters");
    }
    public void BtnGroups(){
        ShowDescription("Groups", FeatureGroups.GetInstance().initialCost + " / " + FeatureGroups.GetInstance().income * -1, ""+FeatureGroups.GetInstance().SatisfactionModifier * 1000, "Wanna do a birthday party? Just add a group and everybody will be able to join. Project X is near");
    }
    public void BtnServerCapacity(){
        ShowDescription("Server Capacity", FeatureServerCapacity.GetInstance().initialCost + " / " + FeatureServerCapacity.GetInstance().income * -1, "" + FeatureServerCapacity.GetInstance().SatisfactionModifier * 1000, "Your servers are lame! Buy some new hardware and increase your capacity by 500 users. Can be purchased multiple times");
    }
    public void BtnFlashGames(){
        ShowDescription("Flash Games", FeatureFlashGames.GetInstance().initialCost + " / " + FeatureFlashGames.GetInstance().income * -1, "" + FeatureFlashGames.GetInstance().SatisfactionModifier * 1000, "Developing them might cost a few bucks but you added for every piece of shit a micro transaction. Weird... Your users love it");
    }
    public void BtnFindFriends(){
        ShowDescription("Find Friends", FeatureFindFriends.GetInstance().initialCost + " / " + FeatureFindFriends.GetInstance().income * -1, "" + FeatureFindFriends.GetInstance().SatisfactionModifier * 1000, "You will be able to find friends automaticaly. From email-list, addressbook, house number, name of your aunt...");
    }
    public void BtnTagging(){
        ShowDescription("Tagging", FeatureTagging.GetInstance().initialCost + " / " + FeatureTagging.GetInstance().income * -1, "" + FeatureTagging.GetInstance().SatisfactionModifier * 1000, "Tag your friends on every picture you made with them. Or tag 100 friends on every picture you take by yourself ");
    }

    private void AddFeature(Button button, Feature feature){
        if (Economy.Money < feature.initialCost) return;

        Economy.Money -= feature.initialCost;
        button.GetComponentInChildren<Text>().text = "Remove";
        Network.Features.Add(feature);
        feature.Equip();

        Economy.RecalcIncome();
    }
    private void RemoveFeature(Button button, Feature feature){
        Economy.Money += feature.initialCost;
        button.GetComponentInChildren<Text>().text = "Add";
        Network.Features.Remove(feature);
        feature.Unequip();

        Economy.RecalcIncome();
    }

    public void ShowDescription(String title, String costs, String satisfaction, String description){
        FeatureDescription.SetActive(true);
        FeatureDescription.GetComponent<FeatureDescription>().Show(title, costs, satisfaction, description);
    }

}
