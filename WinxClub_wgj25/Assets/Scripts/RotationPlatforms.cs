using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatforms : MonoBehaviour
{
    [SerializeField]
    public bool turnOn;
    [SerializeField]
    public GameObject platformUpObject, platformMiddleObject, platformDownObject;
    [SerializeField]
    public Vector3 pointUpObject, pointMiddleObject, pointDownObject;
    public float duration = 1;

    // Start is called before the first frame update
    void Start()
    {
        turnOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!turnOn)
        {
            RotatePlatforms(platformUpObject, pointUpObject, platformMiddleObject, pointMiddleObject, platformDownObject, pointDownObject);
        }
    }


    void TurnOnPlatform(GameObject platform, string color)
    {
        platform.SetActive(true);
    }


    void TurnOffPlatform(GameObject platform, string color)
    {
        platform.SetActive(false);
    }

    void RotatePlatforms(GameObject platformUp, Vector3 pointUp, GameObject platformMiddle, Vector3 pointMiddle, GameObject platformDown, Vector3 pointDown)
    {
        platformUp.GetComponent<Transform>().rotation = Quaternion.Euler(0, 180, 0);
        platformMiddle.GetComponent<Transform>().rotation = Quaternion.Euler(0, 180, 0);
        platformDown.GetComponent<Transform>().rotation = Quaternion.Euler(0, 180, 0);

        StartCoroutine(MovePlatform(platformDown, pointUp));
    }

    IEnumerator MovePlatform(GameObject platformDown, Vector3 targetPosition)
    {
        float timeElapsed = 0;
        Vector3 startPosition = platformDown.GetComponent<Transform>().position;

        while (timeElapsed < duration)
        {
            platformDown.transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        platformDown.GetComponent<Transform>().position = targetPosition;
        StopCoroutine("MovePlatform");
    }
    
}
