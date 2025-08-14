using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPlatform : MonoBehaviour
{
    [SerializeField]
    public GameObject[] platforms;
    public string color;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "CAPRICHOSO" && color == "azul")
        {
            Debug.Log("colidiu");
            TurnOnOffPlatform();
        }
        if(col.gameObject.tag == "GARANTIDO" && color == "vermelho")
            TurnOnOffPlatform();
        if(col.gameObject.tag == "BOIOLA" && color == "colorido")
            TurnOnOffPlatform();
    }
     void TurnOnOffPlatform()
    {
        foreach (GameObject platform in platforms)
        {
            if (platform.activeSelf)
        {
            platform.SetActive(false);
        }
        else
        {
            platform.SetActive(true);
        }
        }
        
    }

}
