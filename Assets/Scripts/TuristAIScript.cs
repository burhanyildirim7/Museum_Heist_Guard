using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class TuristAIScript : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;


    [SerializeField] private List<GameObject> _gidilecekSezlonglar = new List<GameObject>();

    private TuristAIHareketKontrol _aiHareketKontrol;
    private AISpawnController _aiSpawnController;

    private Transform _point;

    private int _dolanSezlongNumber;

    private int _kabinNumber;

    private float _timer;

    private bool _heykeleGit;

    private bool _donuyor;


    private void Awake()
    {

        _aiHareketKontrol = GameObject.FindGameObjectWithTag("TuristAIHareketKontrol").GetComponent<TuristAIHareketKontrol>();
        _aiSpawnController = GameObject.FindGameObjectWithTag("AISpawnController").GetComponent<AISpawnController>();
    }

    void Start()
    {
        SezlongEkle();
        SezlongDoldur();

        _timer = 0;

        _point = _aiHareketKontrol._girisNoktalari[0].transform;
    }


    void FixedUpdate()
    {
        if (GameController.instance.isContinue == true)
        {
            if (_agent.enabled == true)
            {
                SetDestination(_point);
            }
            else
            {

            }

        }


    }


    private void SetDestination(Transform point)
    {
        _agent.SetDestination(point.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _aiHareketKontrol._girisNoktalari[0])
        {
            TurnikeKontrolEt();
        }
        else if (other.gameObject == _aiHareketKontrol._turnikeNoktalari[_kabinNumber])
        {
            _point = _aiHareketKontrol._giseNoktalari[_kabinNumber].transform;
        }
        else if (other.gameObject == _aiHareketKontrol._giseNoktalari[_kabinNumber])
        {
            _point = _gidilecekSezlonglar[_dolanSezlongNumber].transform;
        }
        else
        {

        }
    }


    private void SezlongEkle()
    {
        for (int i = 1; i < _aiHareketKontrol._geziNoktalari.Count; i++)
        {
            if (_aiHareketKontrol._geziNoktalari[i].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.gameObject.activeSelf)
            {

                if (_aiHareketKontrol._geziNoktalari[i].GetComponent<HeykelMusaitlikSorgulama>()._doluMu == false)
                {
                    _gidilecekSezlonglar.Add(_aiHareketKontrol._geziNoktalari[i]);

                }
                else
                {
                    for (int k = 0; k < _gidilecekSezlonglar.Count; k++)
                    {
                        if (_aiHareketKontrol._geziNoktalari[i] == _gidilecekSezlonglar[k])
                        {
                            _gidilecekSezlonglar.RemoveAt(k);
                        }
                        else
                        {

                        }
                    }
                }


            }
            else
            {

            }

        }
    }

    private void SezlongDoldur()
    {

        int k = 0;
        k = Random.Range(0, _gidilecekSezlonglar.Count);
        if (_gidilecekSezlonglar[k].gameObject.transform.parent.gameObject.activeSelf)
        {

            if (_gidilecekSezlonglar[k].GetComponent<HeykelMusaitlikSorgulama>()._doluMu == false)
            {
                _dolanSezlongNumber = k;
                // Debug.Log(_konumNumber);
                _gidilecekSezlonglar[k].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = true;
                _gidilecekSezlonglar[k].GetComponent<HeykelMusaitlikSorgulama>()._dolduranClient = gameObject;
                //_aiSpawnController._uret = false;

            }
            else
            {

            }


        }
        else
        {
            SezlongDoldur();
        }



    }

    private void TurnikeKontrolEt()
    {

        int sayi = Random.Range(0, _aiHareketKontrol._turnikeNoktalari.Count);

        if (_aiHareketKontrol._turnikeNoktalari[sayi].transform.parent.gameObject.activeSelf)
        {
            _kabinNumber = sayi;
            _point = _aiHareketKontrol._turnikeNoktalari[_kabinNumber].transform;
        }
        else
        {
            TurnikeKontrolEt();
        }


    }
}
