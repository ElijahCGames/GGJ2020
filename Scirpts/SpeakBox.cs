using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakBox : MonoBehaviour
{

    [TextArea]
    public string dialouge;
    [SerializeField]
    public GameObject textBox;
    [SerializeField]
    private Canvas vanvas;
    [SerializeField]
    private float talkTime;

    private void OnTriggerEnter(Collider other)
    {
        GameObject ourTextBox = Instantiate(textBox,vanvas.transform);
        ourTextBox.GetComponent<TextControl>().runText(dialouge,talkTime);
        Destroy(gameObject);
    }

}
