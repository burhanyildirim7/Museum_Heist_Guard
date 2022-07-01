using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.UI;

public class TuristAIScript : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    [SerializeField] private GameObject _normalKarakter;
    [SerializeField] private GameObject _hirsizKarakter;


    [SerializeField] private List<GameObject> _gidilecekSezlonglar = new List<GameObject>();

    [SerializeField] private Animator _animator;
    [SerializeField] private Animator _hirsizAnimator;

    [SerializeField] private GameObject _elindeTutmaNoktasi;

    [Header("Slider")]
    [SerializeField] private Slider _slider;

    public GameObject _alacakPolis;

    [SerializeField] private List<GameObject> _efektler = new List<GameObject>();

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
    public bool _busted;

    private bool _kelepceleniyor;

    private bool _hirsizimBen;

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
        _slider.value = 0;

        _point = _aiHareketKontrol._girisNoktalari[0].transform;

        _normalKarakter.SetActive(true);
        _hirsizKarakter.SetActive(false);

        _animator.SetBool("Run", true);

        _efektler[0].SetActive(false);
        _efektler[1].SetActive(false);
        _efektler[2].SetActive(false);
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
            if (_hirsizimBen)
            {
                AIKapat();
                Destroy(gameObject, 2f);
            }
            else
            {
                Destroy(gameObject);
            }

        }
        else
        {

        }



        if (other.gameObject.tag == "Player")
        {
            if (PlayerController._elindeEserVar == false)
            {
                if (_kaciriyor)
                {
                    if (other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiIceCreamObjeleri.Count > 0)
                    {
                        _kaciriyor = false;
                        _kelepceleniyor = true;
                        other.gameObject.GetComponent<JoystickController>()._kelepceliyor = true;
                        //_busted = true;
                        _agent.enabled = false;

                        _hirsizAnimator.SetBool("Walk", false);
                        _hirsizAnimator.SetBool("BustedIdle", true);

                        other.gameObject.GetComponent<PlayerController>()._kelepceliyorMu = true;

                        other.gameObject.GetComponent<PlayerController>()._efektler[1].SetActive(false);
                        other.gameObject.GetComponent<PlayerController>()._efektler[0].SetActive(true);

                        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

                        _timer = 0;
                        _slider.value = 0;
                        // _image.SetActive(true);
                    }
                }
            }
            else
            {

            }

        }
        else
        {

        }

        if (other.gameObject.tag == "Polis")
        {
            if (other.gameObject == _alacakPolis)
            {
                other.gameObject.GetComponent<PolisAIScript>()._coolEfekt.SetActive(true);
                _hirsizAnimator.SetBool("PolisBekle", false);
                _hirsizAnimator.SetBool("BustedWalk", true);
                other.gameObject.GetComponent<PolisAIScript>()._point = _aiHareketKontrol._cikisNoktalari[0].transform;
                _point = other.gameObject.transform;
                _agent.enabled = true;
                _agent.speed = 5;
                _busted = false;
                _hirsizimBen = false;
            }
            else
            {

            }

        }
        else
        {

        }


    }

    private void AIKapat()
    {
        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().Kacirildi();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (_kelepceleniyor)
            {
                if (other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiIceCreamObjeleri.Count > 0)
                {
                    _timer += Time.deltaTime;
                    _slider.value += Time.deltaTime;

                    if (_timer > 2f)
                    {
                        other.gameObject.GetComponent<PlayerController>()._kelepceliyorMu = false;
                        StartCoroutine(Yakalandi());
                        other.gameObject.GetComponent<SirtCantasiScript>().IceCreamCek();
                        _hirsizAnimator.SetBool("BustedIdle", false);
                        _hirsizAnimator.SetBool("PolisBekle", true);
                        other.gameObject.GetComponent<JoystickController>()._kelepceliyor = false;
                        other.gameObject.GetComponent<PlayerController>()._efektler[0].SetActive(false);
                        other.gameObject.GetComponent<PlayerController>()._efektler[1].SetActive(true);
                        _kelepceleniyor = false;
                        _timer = 0;
                        _slider.value = 0;

                        //MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
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
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            _timer = 0;
            _slider.value = 0;

        }
        else
        {

        }

    }

    private IEnumerator HeykeliIzliyor()
    {

        _efektler[1].SetActive(false);
        _efektler[2].SetActive(false);
        _efektler[0].SetActive(true);

        yield return new WaitForSeconds(15f);

        int ihtimal = Random.Range(0, 10);

        if (ihtimal == 0)
        {
            if (_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>()._tablo)
            {
                _heykeleBak = false;

                _animator.SetBool("Run", true);

                _point = _aiHareketKontrol._cikisNoktalari[0].transform;

                _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;

                _efektler[0].SetActive(false);
                _efektler[1].SetActive(false);
                _efektler[2].SetActive(false);
            }
            else
            {
                if (_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>()._calindi)
                {
                    _heykeleBak = false;

                    _animator.SetBool("Run", true);

                    _point = _aiHareketKontrol._cikisNoktalari[0].transform;

                    _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;

                    _efektler[0].SetActive(false);
                    _efektler[1].SetActive(false);
                    _efektler[2].SetActive(false);
                }
                else
                {
                    _hirsizimBen = true;
                    StartCoroutine(HirsizlikYap());
                }
            }


        }
        else
        {
            _heykeleBak = false;

            _animator.SetBool("Run", true);

            _point = _aiHareketKontrol._cikisNoktalari[0].transform;

            _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;

            _efektler[0].SetActive(false);
            _efektler[1].SetActive(false);
            _efektler[2].SetActive(false);
        }

    }

    private IEnumerator HirsizlikYap()
    {

        _efektler[0].SetActive(false);
        _efektler[2].SetActive(false);
        _efektler[1].SetActive(true);

        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>()._calindi = true;

        yield return new WaitForSeconds(1f);

        _normalKarakter.SetActive(false);
        _hirsizKarakter.SetActive(true);

        yield return new WaitForSeconds(5f);

        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().KucagaAl(_elindeTutmaNoktasi);
        _hirsizAnimator.SetBool("BustedIdle", true);


        if (PlayerPrefs.GetInt("HirsizSenaryosu") < 1)
        {

            StartCoroutine(GameObject.FindGameObjectWithTag("OnBoardingController").GetComponent<OnBoardingController>().HirsizOnBoarding(gameObject));
            PlayerPrefs.SetInt("HirsizSenaryosu", 1);
        }
        else
        {

        }

        yield return new WaitForSeconds(1f);

        _agent.speed = 2;

        _heykeleBak = false;
        _hirsizAnimator.SetBool("BustedIdle", false);
        _hirsizAnimator.SetBool("Walk", true);

        _point = _aiHareketKontrol._cikisNoktalari[0].transform;

        _kaciriyor = true;

        _gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._doluMu = false;

        //StartCoroutine(_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().HirsizYakalandi());

    }

    private IEnumerator Yakalandi()
    {
        StartCoroutine(_gidilecekSezlonglar[_dolanSezlongNumber].GetComponent<HeykelMusaitlikSorgulama>()._kontrolEdilecekHeykel.GetComponent<CalinacakObje>().HirsizYakalandi());

        _busted = true;

        _efektler[0].SetActive(false);
        _efektler[1].SetActive(false);
        _efektler[2].SetActive(true);


        yield return new WaitForSeconds(1f);

        /*
        _hirsizAnimator.SetBool("BustedIdle", false);
        _hirsizAnimator.SetBool("BustedWalk", true);
        //_busted = false;
        _agent.enabled = true;
        _agent.speed = 5;
        */


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
