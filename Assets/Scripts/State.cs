using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [TextArea(18, 14)] [SerializeField] string storyText;
    [TextArea(4, 14)] [SerializeField] string finePrint;

    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public string GetFinePrint()
    {
        return finePrint;
    }


    public State[] GetNextStates(){
        return nextStates;
    }

}
