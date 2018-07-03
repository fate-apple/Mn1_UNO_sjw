using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HorizontalScreen : MonoBehaviour {

	// Use this for initialization
	private void Awake()
    {
        Screen.orientation=ScreenOrientation.Landscape;
    }
    public void Reload()
    {
        SceneManager.LoadScene("Main");
    }
	
	
}
