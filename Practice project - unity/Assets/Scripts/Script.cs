using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public string startMessage;
    public string updateMessage;

    public string[] messages;
    public string message1;
    public string message2;
    public string message3;

    public int messageChoice;

    // Start is called before the first frame update
    void Start()

    {
        //debug.LogError(startMessage);

        messageChoice = Random.Range(1, 4);

        /*
        if (messageChoice == 1)
        {
            Debug.Log(messages[0]);
        }
        else if (messageChoice == 2)

        {
            Debug.Log(messages[1]);
        }
        else if (messageChoice == 3)

        {
            Debug.Log(messages[2]);
        }

        else
        {
            Debug.Log("Invalid Message Choice");
        }
    }   
   */
        if (messageChoice <= messages.Length  && messageChoice >= 1)
        {
            Debug.Log(messages[messageChoice]);
        }
        else
        {
            Debug.Log("invalid message choice");
        }
    }
// Update is called once per frame
void Update()



    {
        
    }
}
