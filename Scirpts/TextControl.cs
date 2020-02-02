using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    private AudioSource source;
    [SerializeField]
    private List<AudioClip> humboClips;

    // Start is called before the first frame update

    public void runText(string text,float length)
    {
        source = gameObject.GetComponent<AudioSource>();
        source.clip = humboClips[Random.Range(0, humboClips.Count)];
        source.Play();
        StartCoroutine(DestoryOnTime(length));
        StartCoroutine(SpeakText(text, gameObject.transform.GetChild(0).gameObject.GetComponent<Text>()));
    }

    private IEnumerator DestoryOnTime(float length)
    {
        yield return new WaitForSeconds(length);
        Destroy(gameObject);
    }

    private IEnumerator SpeakText(string dialouge,Text textString)
    {
        for (int i = 0; i < dialouge.Length; i++)
        {
            textString.text = dialouge.Substring(0, i);
            yield return null;
            yield return null;
        }
        textString.text = dialouge;
        yield return null;
    }
}
