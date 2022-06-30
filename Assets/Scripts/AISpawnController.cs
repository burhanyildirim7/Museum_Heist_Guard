using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawnController : MonoBehaviour
{

    [SerializeField] private List<GameObject> _spawnClientList = new List<GameObject>();
    [SerializeField] private List<GameObject> _spawnPolisList = new List<GameObject>();

    [SerializeField] private Transform _spawnNoktasi;

    [SerializeField] private float _spawnHizi;

    [SerializeField] private TuristAIHareketKontrol _aiHareketKontrol;

    [SerializeField] private GameObject _clientParent;

    private float _timer;
    //private float _polisTimer;

    public bool _uret;

    private GameObject _hirsizObject;

    // public static int _giseSayisi;

    void Start()
    {
        _timer = 0;

        if (PlayerPrefs.GetInt("GiseSayisi") == 1)
        {
            _spawnHizi = 4;
        }
        else if (PlayerPrefs.GetInt("GiseSayisi") == 2)
        {
            _spawnHizi = 3;
        }
        else if (PlayerPrefs.GetInt("GiseSayisi") == 3)
        {
            _spawnHizi = 2;
        }
        else
        {
            _spawnHizi = 5;
        }
    }


    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _spawnHizi)
        {

            SezlongKontrolEt();
            HirsizKontrolEt();
            //YuzmeAlaniKontrolEt();

            _timer = 0;


        }
        else
        {

        }
    }

    public void SpawnHizGuncelle()
    {
        if (PlayerPrefs.GetInt("GiseSayisi") == 1)
        {
            _spawnHizi = 4;
        }
        else if (PlayerPrefs.GetInt("GiseSayisi") == 2)
        {
            _spawnHizi = 3;
        }
        else if (PlayerPrefs.GetInt("GiseSayisi") == 3)
        {
            _spawnHizi = 2;
        }
        else
        {
            _spawnHizi = 5;
        }
    }

    private void SpawnFunc()
    {
        int deger = Random.Range(0, _spawnClientList.Count);
        GameObject client = Instantiate(_spawnClientList[deger], _spawnNoktasi.position, Quaternion.identity);
        client.transform.parent = _clientParent.transform;

    }

    private void PolisSpawnFunc()
    {
        int deger = Random.Range(0, _spawnPolisList.Count);
        GameObject client = Instantiate(_spawnPolisList[deger], _spawnNoktasi.position, Quaternion.identity);
        client.GetComponent<PolisAIScript>().HirsizAyarla(_hirsizObject.transform);
        _hirsizObject.GetComponent<TuristAIScript>()._alacakPolis = client;
        //client.transform.parent = _clientParent.transform;

    }

    private void SezlongKontrolEt()
    {

        for (int i = 0; i < _aiHareketKontrol._geziNoktalari.Count; i++)
        {
            if (_aiHareketKontrol._geziNoktalari[i].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.gameObject.activeSelf)
            {

                if (_aiHareketKontrol._geziNoktalari[i].GetComponent<HeykelMusaitlikSorgulama>()._doluMu == false)
                {
                    _timer = 0;
                    // Debug.Log(_konumNumber);
                    SpawnFunc();


                    break;
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


    private void HirsizKontrolEt()
    {

        for (int i = 0; i < _clientParent.transform.childCount; i++)
        {

            if (_clientParent.transform.GetChild(i).gameObject.GetComponent<TuristAIScript>()._busted)
            {
                _timer = 0;
                // Debug.Log(_konumNumber);
                _clientParent.transform.GetChild(i).gameObject.GetComponent<TuristAIScript>()._busted = false;
                _hirsizObject = _clientParent.transform.GetChild(i).gameObject;
                PolisSpawnFunc();





                break;
            }
            else
            {

            }




        }




    }


}
