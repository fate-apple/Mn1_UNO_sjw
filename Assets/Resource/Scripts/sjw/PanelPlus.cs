using UnityEngine;

using System.Collections;

using UnityEngine.UI;



[AddComponentMenu("UI/PanelPlus")]
[DisallowMultipleComponent]
//[RequireComponent(typeof(Panel))]

public class PanelPlus : MonoBehaviour {

    // Use this for initialization
    private void Awake()
    {
      //  Messenger.AddListener(GameEvent.PANEL_BACK,On_Panel_Back);
        Messenger<string>.AddListener(GameEvent.PANEL_OPEN, On_Panel_Open);
        gameObject.SetActive(false);
    }

    void Start () {
		
	}
    
   
    // Update is called once per frame
    void Update () {
		
	}
    private void OnDestroy()
    {
       // Messenger.AddListener(GameEvent.PANEL_BACK, On_Panel_Back);
        Messenger<string>.AddListener(GameEvent.PANEL_OPEN, On_Panel_Open);
    }

    
    //private void On_Panel_Back()
    //{
    //    UI_Controller.SetActive(UI_Controller.curPannel, false);
    //}

    private void On_Panel_Open(string OpenPanelName)
    {
        if (gameObject.name == OpenPanelName)
        {
            UI_Controller.SetActive(gameObject, true);
            UI_Controller.curPannel = gameObject;
        }
    }
}
