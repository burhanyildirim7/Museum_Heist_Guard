using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HediyePara : MonoBehaviour
{
    [SerializeField] private GameObject _paraObject;
    void Start()
    {
        if (PlayerPrefs.GetInt("HediyeParaVerildi") < 1)
        {
            _paraObject.SetActive(true);
            //StartCoroutine(GameObject.FindGameObjectWithTag("OnBoardingController").GetComponent<OnBoardingController>().StartOnBoarding());
            //PlayerPrefs.SetInt("UpgradeSenaryosu", 1);
        }
        else
        {
            _paraObject.SetActive(false);
        }
    }


}
