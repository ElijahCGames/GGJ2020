using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableStruct : MonoBehaviour
{
    public Dictionary<string, bool> Powers = new Dictionary<string, bool>()
    {
        {"Jump",false},
        {"Wall",false},
        {"DJ",false},
        {"Health", false} 
    };

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void PowerOn(string powerName)
    {
        Powers[powerName] = true;
    }

    public void PowerDown(string powerName)
    {
        Powers[powerName] = false;
    }

    public bool GetPower(string powerName)
    {
        return Powers[powerName];
    }

}
