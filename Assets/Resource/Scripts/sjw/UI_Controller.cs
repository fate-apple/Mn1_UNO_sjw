using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour {

    // Use this for initialization
    static public GameObject curPannel;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    static public void SetActive(GameObject go, bool state)
    {
        if (go == null)
        {
            return;
        }
        if (go.activeSelf != state)
        {
            go.SetActive(state);
        }
    }

    public void Test()
    {
        Debug.Log("hit test");
    }

    public void On_Click_Character()
    {
        Debug.Log("click character(rawImage)");
        Messenger<Character.Character_Interactions>.Broadcast(GameEvent.CHARACTER_INTERACTIONS, Character.Character_Interactions.FEMALE_MOVE_1);
    }

    public void On_Click_Back()
    {
        // Messenger.Broadcast(GameEvent.PANEL_BACK);
        SetActive(curPannel, false);
    }

    public void On_Click_Open(string OpenPanelName)
    {
        Messenger<string>.Broadcast(GameEvent.PANEL_OPEN,OpenPanelName);
    }
}
