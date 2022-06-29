using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedektorKontrolNoktasi : MonoBehaviour
{

    [SerializeField] private moneyGrubuKontrolu _moneyGrubuKontrol;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "client")
        {
            _moneyGrubuKontrol.paraEklensinMi = true;
        }
        else
        {

        }
    }

}
