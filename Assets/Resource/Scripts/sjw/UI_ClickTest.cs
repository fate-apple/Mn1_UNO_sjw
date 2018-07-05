using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_ClickTest : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler, IPointerExitHandler
{

    // Use this for initialization
    public float alphaThrehold = 0.1f;
    [SerializeField] private GameObject _ParticleSystemPrefab = null;
    private GameObject _ParticleSystemInstance = null;

    void Start () {
        Image image = gameObject.GetComponent<Image>();
        if (image != null) image.alphaHitTestMinimumThreshold = alphaThrehold;
        else Debug.Log(gameObject + " don't have image component");
	}
	
	// Update is called once per frame
	void Update () {
        TracePointer();
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("hit : " + gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale = 1.1f* gameObject.transform.localScale;
        if (_ParticleSystemPrefab!=null&& _ParticleSystemInstance == null) _ParticleSystemInstance = Instantiate(_ParticleSystemPrefab) as GameObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.localScale = Vector3.one;
        Destroy(_ParticleSystemInstance);
        _ParticleSystemInstance = null;
    }

    void TracePointer()
    {
        if(_ParticleSystemInstance!=null)
        {   
            Vector3 input_position = Input.mousePosition;
            if( Camera.current!=null)_ParticleSystemInstance.transform.position =  Camera.current.ScreenToWorldPoint(input_position)+ Vector3.forward;
        }
    }

}
