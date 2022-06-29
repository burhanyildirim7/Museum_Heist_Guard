using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class TuristAIScript : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    [SerializeField] private GameObject _normalKarakter;
    [SerializeField] private GameObject _hirsizKarakter;


    [SerializeField] private List<GameObject> _gidilecekSezlonglar = new List<GameObject>();

    [SerializeField] private Animator _animator;
    [SerializeField] private Animator _hirsizAnimator;

    [SerializeField] private GameObject _elindeTutmaNoktasi;

    private TuristAIHareketKontrol _aiHareketKontrol;
    private AISpawnController _aiSpawnController;

    private Transform _point;

    private int _dolanSezlongNumber;

    private int _kabinNumber;

    private float _timer;

    private bool _heykeleGit;

    private bool _donuyor;

    private bool _heykeleBak;

    private bool _kaciriyor;
    private bool _busted;

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

        _normalKarakter.SetActive(true);
        _hirsizKarakter.SetActive(false);

        _animator.SetBool("Run", true);
    }


    void FixedUpdate()
    {
        if (GameController.instance.isContinue == true)
        {
            //_timer += Time.deltaTime;

            if (_agent.enabled == true)
            {
                SetDestination(_point);
            }
            else
            {

            }

            if (_heykeleBak)
            {

                Vector3 lTargetDir = _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.transform.position - transform.position;
                lTargetDir.y = 0.0f;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * 0.1f);

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
        else if (other.gameObject == _gidilecekSezlonglar[_dolanSezlongNumber])
        {
            if (_heykeleBak == false)
            {
                _heykeleBak = true;

                _animator.SetBool("Run", false);

                StartCoroutine(HeykeliIzliyor());
            }
            else
            {

            }

        }
        else if (other.gameObject == _aiHareketKontrol._cikisNoktalari[0])
        {
            _point = _aiHareketKontrol._cikisNoktalari[1].transform;
        }
        else if (other.gameObject == _aiHareketKontrol._cikisNoktalari[1])
        {
            _point = _aiHareketKontrol._cikisNoktalari[2].transform;
        }
        else if (other.gameObject == _aiHareketKontrol._cikisNoktalari[2])
        {
            Destroy(gameObject);
        }
        else
        {

        }

        if (other.gameObject.tag == "Player")
        {
            if (_kaciriyor)
            {
                StartCoroutine(Yakalandi());
            }
            else
            {

            }
        }
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {

    }

    private IEnumerator HeykeliIzliyor()
    {
        yield return new WaitForSeconds(15f);

        int ihtimal = Random.Range(0, 5);

        if (ihtimal == 0)
        {
            if (_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>()._calindi)
            {
                _heykeleBak = false;

                _animator.SetBool("Run", true);

                _point = _aiHareketKontrol._cikisNoktalari[0].transform;

                _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;
            }
            else
            {
                StartCoroutine(HirsizlikYap());
            }

        }
        else
        {
            _heykeleBak = false;

            _animator.SetBool("Run", true);

            _point = _aiHareketKontrol._cikisNoktalari[0].transform;

            _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;
        }

    }

    private IEnumerator HirsizlikYap()
    {
        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>()._calindi = true;

        yield return new WaitForSeconds(1f);

        _normalKarakter.SetActive(false);
        _hirsizKarakter.SetActive(true);

        yield return new WaitForSeconds(5f);

        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().KucagaAl(_elindeTutmaNoktasi);
        _hirsizAnimator.SetBool("BustedIdle", true);


        yield return new WaitForSeconds(5f);

        _agent.speed = 3;

        _heykeleBak = false;
        _hirsizAnimator.SetBool("BustedIdle", false);
        _hirsizAnimator.SetBool("Walk", true);

        _point = _aiHareketKontrol._cikisNoktalari[0].transform;

        _kaciriyor = true;

        //StartCoroutine(_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().HirsizYakalandi());

    }

    private IEnumerator Yakalandi()
    {
        _kaciriyor = false;
        //_busted = true;
        _agent.enabled = false;
        StartCoroutine(_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().HirsizYakalandi());
        _hirsizAnimator.SetBool("Walk", false);
        _hirsizAnimator.SetBool("BustedIdle", true);

        yield return new WaitForSeconds(6f);

        _hirsizAnimator.SetBool("BustedIdle", false);
        _hirsizAnimator.SetBool("BustedWalk", true);
        //_busted = false;
        _agent.enabled = true;
        _agent.speed = 5;



        //StartCoroutine(_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().HirsizYakalandi());

    }


    private void SezlongEkle()
    {
        for (int i = 0; i < _aiHareketKontrol._geziNoktalari.Count; i++)
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
