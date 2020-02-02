using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSpeak : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public TextAsset cutsceneText;
    [SerializeField]
    public GameObject textBox;
    [SerializeField]
    private Canvas vanvas;
    [SerializeField]
    private float talkTime;

    private string[] dialouge;
    private int readIndex = 0;

    private void Start()
    {
        dialouge = cutsceneText.ToString().Split('\n');
    }

    public void GetSpeak()
    {
        if (readIndex <= dialouge.Length)
        {
            GameObject ourTextBox = Instantiate(textBox, vanvas.transform);
            ourTextBox.GetComponent<TextControl>().runText(dialouge[readIndex], talkTime);
            readIndex++;
        }
    }
}
