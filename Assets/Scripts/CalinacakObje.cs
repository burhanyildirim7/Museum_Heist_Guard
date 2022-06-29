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

    public bool _tablo;


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
        gameObject.transform.DOLocalJump(Vector3.zero, 5, 1, 1f);

        if (_tablo)
        {
            gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
        }
        else
        {
            gameObject.transform.DOLocalRotate(new Vector3(0, 90, 0), 1f);
        }


        _maviCerceve.SetActive(true);
        //_toplamaCollider.SetActive(true);
    }

    public void YerineKoy()
    {
        _calindi = false;
        gameObject.transform.parent = _parentObjesi.transform;
        gameObject.transform.DOLocalJump(_ilkLokalPosition, 5, 1, 1f);
        gameObject.transform.DOLocalRotate(_ilkLokalRotation, 1f);

        if (!_tablo)
        {
            _engellemeCollider.SetActive(true);
        }
        else
        {

        }

        _maviCerceve.SetActive(false);
        //_toplamaCollider.SetActive(false);
    }

    public void Kacirildi()
    {
        _calindi = false;
        gameObject.SetActive(false);
        gameObject.transform.parent = _parentObjesi.transform;
        gameObject.transform.DOLocalJump(_ilkLokalPosition, 5, 1, 1f);
        gameObject.transform.DOLocalRotate(_ilkLokalRotation, 1f);

        if (!_tablo)
        {
            _engellemeCollider.SetActive(true);
        }
        else
        {

        }

        _maviCerceve.SetActive(false);
        //_toplamaCollider.SetActive(false);
    }

    public IEnumerator HirsizYakalandi()
    {
        yield return new WaitForSeconds(5f);


        gameObject.transform.DOLocalJump(new Vector3(0, -2, 3), 5, 1, 1f);

        yield return new WaitForSeconds(1f);
        gameObject.transform.parent = null;

        //yield return new WaitForSeconds(2f);


        //KucagaAl(GameObject.FindGameObjectWithTag("PlayerStackNoktasi").gameObject);
    }


}
