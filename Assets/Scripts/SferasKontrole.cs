using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SferasKontrole : MonoBehaviour
{
    public Text WinText;
    // Start is called before the first frame update
    void Start()
    {
        WinText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kapsula"))
        {
            other.gameObject.SetActive(false);
            WinText.text = "Tu uzvarēji!";
        }
    }
}
