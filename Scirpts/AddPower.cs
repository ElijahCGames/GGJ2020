using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour
{
    [SerializeField]
    private string powerName;
    [SerializeField]
    private VariableStruct powerChanger;
    private void OnTriggerEnter(Collider other)
    {
        powerChanger.PowerOn(powerName);
        Destroy(gameObject);
    }
}
