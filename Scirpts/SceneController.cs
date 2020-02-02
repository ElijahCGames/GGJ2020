using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string sceneToGoTo;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        ChangeScene(sceneToGoTo);
    }

    public void ChangeScene(string sceneToGoTo)
    {
        SceneManager.LoadScene(sceneToGoTo);
    }
}
