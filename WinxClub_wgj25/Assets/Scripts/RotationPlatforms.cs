using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatforms : MonoBehaviour
{
    [SerializeField]
    public GameObject caprichoso, garantido;

    [SerializeField]
    public GameObject platformUpObject, platformMiddleObject, platformDownObject;
    [SerializeField]
    public Vector3 pointUpObject, pointMiddleObject, pointDownObject;


    // Start is called before the first frame update
    void Start()
    {
        //this scripts are here on Start just for test them.
        //example: call this function when turn on/off platforms by red/blue buttons
        //TurnOnOffPlatform(platformUpObject);
        //example: call this functions to flip platforms by clicking yellow button
        //RotatePlatforms(platformUpObject, pointUpObject, platformMiddleObject, pointMiddleObject, platformDownObject, pointDownObject);
    }

    void OnTriggerEnter(Collider col)
    {
        string boi;
        boi = col.gameObject.tag;
        if (boi == "Caprichoso" || boi == "Garantido")
        {

            Debug.Log("girar cenario");
            RotatePlatforms(platformUpObject, pointUpObject, platformMiddleObject, pointMiddleObject, platformDownObject, pointDownObject);

            
                
                if (garantido.GetComponent<Transform>().position.y < 0)
                {
                    garantido.GetComponent<Transform>().position = new Vector3(garantido.GetComponent<Transform>().position.x, 3f, garantido.GetComponent<Transform>().position.z);
                }
                else
                {
                    garantido.GetComponent<Transform>().position = new Vector3(garantido.GetComponent<Transform>().position.x, -2.0f, garantido.GetComponent<Transform>().position.z);

                }

    
                if (caprichoso.GetComponent<Transform>().position.y < 0)
                {
                    caprichoso.GetComponent<Transform>().position = new Vector3(caprichoso.GetComponent<Transform>().position.x, 3f, caprichoso.GetComponent<Transform>().position.z);;
                }
                else
                {
                    caprichoso.GetComponent<Transform>().position = new Vector3(caprichoso.GetComponent<Transform>().position.x, -2.0f, caprichoso.GetComponent<Transform>().position.z);

                }
           

        }
    }

    void RotatePlatforms(GameObject platformUp, Vector3 pointUp, GameObject platformMiddle, Vector3 pointMiddle, GameObject platformDown, Vector3 pointDown)
    {
        platformUp.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);
        platformUp.GetComponent<Transform>().position = pointDown;

        platformMiddle.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);

        platformDown.GetComponent<Transform>().position = pointUp;
        platformDown.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);

        if (garantido.GetComponent<Transform>().position.x < 0)
        {
            float novoX = garantido.GetComponent<Transform>().position.x + 2 * Mathf.Abs(garantido.GetComponent<Transform>().position.x);
            Debug.Log("novo Valor de " + novoX);
            garantido.GetComponent<Transform>().position = new Vector3(novoX, garantido.GetComponent<Transform>().position.y, garantido.GetComponent<Transform>().position.z);
        }
        else
        {
          float novoX = garantido.GetComponent<Transform>().position.x - 2 * Mathf.Abs(garantido.GetComponent<Transform>().position.x);
            Debug.Log("novo Valor de " + novoX);
            garantido.GetComponent<Transform>().position = new Vector3(novoX, garantido.GetComponent<Transform>().position.y, garantido.GetComponent<Transform>().position.z);   
        }

        if (caprichoso.GetComponent<Transform>().position.x < 0)
        {
            float novoX = caprichoso.GetComponent<Transform>().position.x + 2 * Mathf.Abs(caprichoso.GetComponent<Transform>().position.x);
            Debug.Log("novo Valor de " + novoX);
            caprichoso.GetComponent<Transform>().position = new Vector3(novoX, caprichoso.GetComponent<Transform>().position.y, caprichoso.GetComponent<Transform>().position.z);
        }
        else
        {
           float novoX = caprichoso.GetComponent<Transform>().position.x - 2 * Mathf.Abs(caprichoso.GetComponent<Transform>().position.x);
            Debug.Log("novo Valor de " + novoX);
            caprichoso.GetComponent<Transform>().position = new Vector3(novoX, caprichoso.GetComponent<Transform>().position.y, caprichoso.GetComponent<Transform>().position.z); 
        }


    }

}
