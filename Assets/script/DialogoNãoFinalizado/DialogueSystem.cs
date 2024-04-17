/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
    DISABLED,
    WAITING,
    TYPING
}

public class DialogueSystem : MonoBehaviour
{
    public DialogData dialogueData;
    int currentText = 0;
    bool finished = false;

    TypeTextAnimation typeText;

    STATE state;
    void Awake()
    {
        typeText = FindObjectOfType< TypeTextAnimation>();
    }

    // Start is called before the first frame update
    void Start()
    {
        state = STATE.DISABLED; 
    }

    // Update is called once per frame
    void Update()
    {
        if (state == STATE.DISABLED) return;

        switch (state)
        {
            case STATE.WAITING:
                Waiting();
                break;
            case STATE.TYPING:
                Typing();
                break;
        }
    }
    public void StartTyping(string text)
    {
        fullText = text;
        StartCoroutine(TypeText());
    }

    public void Next()
    {
        typeText.fullText = dialogueData.talkScript[currentText++].text;
        if (currentText == dialogueData.talkScript.Count) finished = true;

        typeText.StartTyping(typeText.fullText); // Passa o texto como argumento
        state = STATE.TYPING;
    }

    void Waiting()
    {

    }

    void Typing()
    {

    }
}
*/
