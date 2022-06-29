using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaviAlanScript : MonoBehaviour
{
    [SerializeField] private GameObject _eser;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("PlayerStackNoktasi").transform.childCount > 0)
            {
                if (GameObject.FindGameObjectWithTag("PlayerStackNoktasi").transform.GetChild(0).gameObject == _eser)
                {
                    GameObject.FindGameObjectWithTag("PlayerStackNoktasi").transform.GetChild(0).gameObject.GetComponent<CalinacakObje>().YerineKoy();
                }
                else
                {

                }

            }
            else
            {

            }

        }
        else
        {

        }
    }
}
