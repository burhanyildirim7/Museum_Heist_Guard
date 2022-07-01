using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CalinacakObje : MonoBehaviour
{
    [SerializeField] private GameObject _maviCerceve;
    [SerializeField] private GameObject _objeAcmaAlani;
    [SerializeField] private GameObject _parentObjesi;
    [SerializeField] private GameObject _engellemeCollider;
    [SerializeField] private GameObject _toplamaCollider;
    [SerializeField] private GameObject _bedelOdemeCollider;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _bariyer;

    public bool _tablo;

    public bool _donecekHeykelMi;


    public Vector3 _ilkLokalPosition;
    public Vector3 _ilkLokalRotation;

    public bool _calindi;



    void Start()
    {
        _ilkLokalPosition = transform.localPosition;
        _toplamaCollider.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.transform.parent == null)
            {
                //KucagaAl(GameObject.FindGameObjectWithTag("PlayerStackNoktasi").gameObject);
                //Debug.Log("ESERDE GIRDI");
            }
            else
            {

            }
        }
        else
        {

        }
    }

    public void KucagaAl(GameObject _gameObject)
    {
        _calindi = true;

        if (!_tablo)
        {
            _engellemeCollider.SetActive(false);

        }
        else
        {

        }

        gameObject.transform.parent = _gameObject.transform;
        gameObject.transform.DOLocalJump(Vector3.zero, 5, 1, 0.5f);

        if (_donecekHeykelMi)
        {
            gameObject.transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f);
        }
        else
        {
            gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
        }

        if (_gameObject == GameObject.FindGameObjectWithTag("PlayerStackNoktasi").gameObject)
        {
            _maviCerceve.SetActive(true);
            PlayerController._elindeEserVar = true;

            if (PlayerPrefs.GetInt("KurtarmaSenaryosu") < 1)
            {

                StartCoroutine(GameObject.FindGameObjectWithTag("OnBoardingController").GetComponent<OnBoardingController>().KurtarmaOnBoarding(_maviCerceve));
                PlayerPrefs.SetInt("KurtarmaSenaryosu", 1);
            }
            else
            {

            }
        }
        else
        {

        }

        //_toplamaCollider.SetActive(true);
    }

    public void YerineKoy()
    {
        _calindi = false;
        gameObject.transform.parent = _parentObjesi.transform;
        gameObject.transform.DOLocalJump(_ilkLokalPosition, 5, 1, 0.5f);
        gameObject.transform.DOLocalRotate(_ilkLokalRotation, 0.5f);

        if (!_tablo)
        {
            _engellemeCollider.SetActive(true);
        }
        else
        {

        }

        _maviCerceve.SetActive(false);
        PlayerController._elindeEserVar = false;

        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
        //_toplamaCollider.SetActive(false);
    }

    public void Kacirildi()
    {
        _calindi = false;
        gameObject.SetActive(false);
        gameObject.transform.parent = _parentObjesi.transform;
        gameObject.transform.DOLocalJump(_ilkLokalPosition, 5, 1, 0.5f);
        gameObject.transform.DOLocalRotate(_ilkLokalRotation, 0.5f);

        if (!_tablo)
        {
            _engellemeCollider.SetActive(true);
        }
        else
        {

        }

        _objeAcmaAlani.GetComponent<ObjeAcmaScript>().KacirilanObjeYerlestir();
        _objeAcmaAlani.SetActive(true);
        _bedelOdemeCollider.SetActive(true);
        _canvas.SetActive(true);
        _bariyer.SetActive(false);
        _objeAcmaAlani.GetComponent<MeshRenderer>().enabled = true;

        _bedelOdemeCollider.GetComponent<BedelOdemeler>().FiyatGuncelle();

        _maviCerceve.SetActive(false);
        //_toplamaCollider.SetActive(false);
    }

    public IEnumerator HirsizYakalandi()
    {

        gameObject.transform.DOLocalJump(new Vector3(0, -2f, 3), 5, 1, 0.5f);

        yield return new WaitForSeconds(1f);
        gameObject.transform.parent = null;

        //yield return new WaitForSeconds(2f);


        //KucagaAl(GameObject.FindGameObjectWithTag("PlayerStackNoktasi").gameObject);
    }


}
