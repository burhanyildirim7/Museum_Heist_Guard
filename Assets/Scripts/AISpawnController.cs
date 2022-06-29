using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawnController : MonoBehaviour
{

    [SerializeField] private List<GameObject> _spawnClientList = new List<GameObject>();

    [SerializeField] private Transform _spawnNoktasi;

    [SerializeField] private float _spawnHizi;

    [SerializeField] private TuristAIHareketKontrol _aiHareketKontrol;

    private float _timer;

    public bool _uret;

    void Start()
    {
        _timer = 0;
    }


    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _spawnHizi)
        {

            SezlongKontrolEt();
            //YuzmeAlaniKontrolEt();

            _timer = 0;


        }
        else
        {

        }
    }

    private void SpawnFunc()
    {
        int deger = Random.Range(0, _spawnClientList.Count);
        Instantiate(_spawnClientList[deger], _spawnNoktasi.position, Quaternion.identity);

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


}
