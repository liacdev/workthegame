using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkTheGame : MonoBehaviour
{

    [SerializeField] TMP_Text textComponent;
    [SerializeField] TMP_Text textComponent2;
    [SerializeField] State startingState;


    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        textComponent2.text = state.GetFinePrint();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
       
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
       
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            state = nextStates[3];
        }
        
        textComponent.text = state.GetStateStory();
        textComponent2.text = state.GetFinePrint();

    }
    

}
