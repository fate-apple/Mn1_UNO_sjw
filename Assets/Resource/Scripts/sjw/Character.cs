using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    // Use this for initialization
    public enum Character_Interactions:int {FEMALE_STAND_1=0,FEMALE_MOVE_1 }
    public Dictionary<Character_Interactions, string> Character_Animaons = new Dictionary<Character_Interactions, string>();
    private void Awake()
    {
        Messenger<Character_Interactions>.AddListener(GameEvent.CHARACTER_INTERACTIONS,On_Character_Interactions);
    }
    private void Start()
    {
        Character_InteractionsMatchAnimation_Init();
    }

    private void Character_InteractionsMatchAnimation_Init()
    {
        Character_Animaons.Add(Character_Interactions.FEMALE_MOVE_1, "Female_move_1");
    }
    private void OnDestroy()
    {
        Messenger<Character_Interactions>.RemoveListener(GameEvent.CHARACTER_INTERACTIONS, On_Character_Interactions);
    }

    private void On_Character_Interactions(Character_Interactions Character_Interaction)
    {
        string animationMatched = null;
        switch (Character_Interaction)
        {
            case Character_Interactions.FEMALE_MOVE_1:
                Character_Animaons.TryGetValue(Character_Interactions.FEMALE_MOVE_1,out  animationMatched);
                gameObject.GetComponent<Animation>().Play(animationMatched);
                break;

        }
    }
}
