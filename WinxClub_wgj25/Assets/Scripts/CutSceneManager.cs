using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    [SerializeField]
    Sprite[] cenas;
    [SerializeField]
    GameObject cenaInPlay, NextButton;
    [SerializeField]
    public GameObject[] Ballons;

    int index =1;
    // Start is called before the first frame update
    void Start()
    {
        
        NextButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CallGame() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Gameplay"); 
    }

    public void ProximaCena()
    {
        if (index < 3)
        {
            switch (index)
            {
                case 0:
                    {
                        //cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        //Ballons[0].SetActive(true);
                        break;
                    }
                case 1:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        Ballons[0].SetActive(false);
                        Ballons[1].SetActive(true);
                        break;
                    }
                case 2:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        Ballons[1].SetActive(false);
                        Ballons[2].SetActive(true);
                         NextButton.SetActive(false);
                        StartCoroutine(CallGame());
                       
                        break;
                    }
                case 3:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        break;
                    }
                case 4:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        Ballons[4].SetActive(true);
                        break;
                    }
                case 5:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        Ballons[5].SetActive(false);
                        Ballons[6].SetActive(true);
                        break;
                    }
                case 6:
                    {
                        cenaInPlay.GetComponent<Image>().sprite = cenas[index];
                        Ballons[6].SetActive(false);
                        Ballons[7].SetActive(true);
                        break;
                    }

            }
        }
        index++;
    }
}
