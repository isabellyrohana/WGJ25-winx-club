using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatforms : MonoBehaviour
{
  
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
   
    void RotatePlatforms(GameObject platformUp, Vector3 pointUp, GameObject platformMiddle, Vector3 pointMiddle, GameObject platformDown, Vector3 pointDown)
    {
        platformUp.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);
        platformUp.GetComponent<Transform>().position = pointDown;

        platformMiddle.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);

        platformDown.GetComponent<Transform>().position = pointUp;
        platformDown.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -180);
    }

}
