using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.UI;

public class PolisAIScript : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;



    [SerializeField] private Animator _animator;


    private TuristAIHareketKontrol _aiHareketKontrol;

    public Transform _point;

    private Transform _gidilecekHirsiz;

    public GameObject _coolEfekt;

    private void Awake()
    {
        _aiHareketKontrol = GameObject.FindGameObjectWithTag("TuristAIHareketKontrol").GetComponent<TuristAIHareketKontrol>();


    }

    void Start()
    {
        _point = _aiHareketKontrol._polisGirisNoktalari[0].transform;
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


        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _aiHareketKontrol._polisGirisNoktalari[0])
        {
            _point = _aiHareketKontrol._polisGirisNoktalari[1].transform;
        }
        else if (other.gameObject == _aiHareketKontrol._polisGirisNoktalari[1])
        {
            _point = _gidilecekHirsiz;
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
            Destroy(gameObject, 3f);
        }
        else
        {

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == _aiHareketKontrol._cikisNoktalari[0])
        {
            _point = _aiHareketKontrol._cikisNoktalari[1].transform;
        }
        else if (other.gameObject == _aiHareketKontrol._cikisNoktalari[1])
        {
            _point = _aiHareketKontrol._cikisNoktalari[2].transform;
        }
        else
        {

        }
    }


    public void SetDestination(Transform point)
    {
        _agent.SetDestination(point.position);
    }

    public void HirsizAyarla(Transform point)
    {
        _gidilecekHirsiz = point;
    }

}
