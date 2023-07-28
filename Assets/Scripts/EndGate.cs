using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndGate : MonoBehaviour
{
    public GameObject messageText;

    private void OnTriggerEnter(Collider other)
    {
        messageText.SetActive(true);
        messageText.GetComponent<TMP_Text>().text = "You Win!";
    }
}
