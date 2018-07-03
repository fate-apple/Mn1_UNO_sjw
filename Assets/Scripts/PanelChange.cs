using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelChange : MonoBehaviour {
    public Animator mainAnimator;
    public GameObject character;
    public Transform canvas;
    private Transform[] panels;
    private Transform[] currentPanel;
    private int currentPanelCout = 0;
    private void Awake()
    {
        mainAnimator=mainAnimator.GetComponent<Animator>();
    }
	// Use this for initialization
	void Start () {
        panels = new Transform[canvas.childCount];
        currentPanel = new Transform[1024];
        for (int i=0;i<canvas.childCount-1;i++)
        {
            if (i != 0)
            {
                panels[i] = canvas.GetChild(i);           
                panels[i].transform.position = new Vector3(0, 0, 9000);
            }
            else 
            {
                panels[i] = canvas.GetChild(i);
                currentPanel[0] = panels[i];
                currentPanelCout++;
            }
        }
	} 

	private void Open(string panelName)
    {
        currentPanelCout++;
        canvas.Find(panelName).transform.position = new Vector3(0, 0, 0);
        currentPanel[currentPanelCout] =canvas.Find(panelName);
        character.SetActive(false);
        mainAnimator.SetTrigger("Open");
    }
    public void Close()
    {
        currentPanel[currentPanelCout].gameObject.transform.position = new Vector3(0, 0, 9000);
        currentPanelCout--;
        character.SetActive(true);
        mainAnimator.SetTrigger("Back");
    }
    public void OpenInformation()
    {
        StartCoroutine(OpenPanel("Information"));
    }   
    public void OpenRank()
    {
        StartCoroutine(OpenPanel("Rank"));
    }
    public void OpenCoin()
    {
        StartCoroutine(OpenPanel("Coin"));
    }
    public void OpenDiamond()
    {
        StartCoroutine(OpenPanel("Diamond"));
    }
    public void OpenfirstBuy()
    {
        StartCoroutine(OpenPanel("1STBUY"));
    }
    public void OpenShop()
    {
        StartCoroutine(OpenPanel("Shop"));
    }
    public void OpenFriends()
    {
        StartCoroutine(LoadScence("Friends"));
    }
    public void OpenBag()
    {
        StartCoroutine(OpenPanel("Bag"));
    }
    public void OpenAchievement()
    {
        StartCoroutine(OpenPanel("Achievement"));
    }
    public void OpenSettings()
    {
        StartCoroutine(OpenPanel("Settings"));
    }
    public void OpenSpecialOffer()
    {
        StartCoroutine(OpenPanel("Special_offer_1"));
    }
    public void OpenQuickPlay()
    {
        Open("Quick_play");
    }
    public void OpenRoom_Mode()
    {
        Open("Room_Mode");
    }
    public void OpenRules()
    {
        Open("Rules");
    }
    public void Open2V2()
    {
        Open("2V2");
    }
    public void OpenGoWild()
    {
        Open("GoWild");
    }
    public void OpenPersonalise()
    {
        Open("Information/personalise");
    }
    public void OpenPersonshare()
    {
        Open("Information/share");
    }
    public void OpenFirstBuy()
    {
        Open("FirstBuy");
    }
    IEnumerator OpenPanel(string name)
    {
        yield return new WaitForSeconds(0.15f);
        Open(name);
    }
    IEnumerator LoadScence(string name)
    {
        yield return new WaitForSeconds(0.05f);
        SceneManager.LoadScene(name);
    }
}
