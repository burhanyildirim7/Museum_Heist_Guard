using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BedelOdemeler : MonoBehaviour
{
    [SerializeField] private ObjeAcmaScript _objeAcmaScript;
    [SerializeField] private Text _bedelText;
    [SerializeField] private bool _bolge1Bolum2;
    [SerializeField] private bool _bolge1Bolum3;
    [SerializeField] private bool _bolge1Bolum4;
    [SerializeField] private bool _bolge1Tablo1;
    [SerializeField] private bool _bolge1Tablo2;
    [SerializeField] private bool _bolge1Tablo3;
    [SerializeField] private bool _bolge1Heykel1;
    [SerializeField] private bool _bolge1Heykel2;
    [SerializeField] private bool _bolge1Heykel3;
    [SerializeField] private bool _bolge1Heykel4;
    [SerializeField] private bool _bolge2Heykel1;
    [SerializeField] private bool _bolge2Heykel2;
    [SerializeField] private bool _bolge2Heykel3;
    [SerializeField] private bool _bolge2Heykel4;
    [SerializeField] private bool _bolge2Heykel5;
    [SerializeField] private bool _bolge2Heykel6;
    [SerializeField] private bool _bolge3Heykel1;
    [SerializeField] private bool _bolge3Heykel2;
    [SerializeField] private bool _bolge3Heykel3;
    [SerializeField] private bool _bolge3Heykel4;
    [SerializeField] private bool _bolge3Heykel5;
    [SerializeField] private bool _bolge3Heykel6;
    [SerializeField] private bool _bolge3Heykel7;
    [SerializeField] private bool _bolge4Heykel1;
    [SerializeField] private bool _bolge4Heykel2;
    [SerializeField] private bool _bolge4Heykel3;
    [SerializeField] private bool _bolge4Heykel4;
    [SerializeField] private bool _bolge4Heykel5;
    [SerializeField] private bool _bolge4Heykel6;
    [SerializeField] private bool _bolge4Heykel7;
    [SerializeField] private bool _bolge4Heykel8;
    [SerializeField] private bool _bolge4Heykel9;
    [SerializeField] private bool _expandBolge2;
    [SerializeField] private bool _expandBolge3;
    [SerializeField] private bool _expandBolge4;
    //[SerializeField] private bool _expandAlani;

    public int _odenecekBedel;

    private Vector3 _boyut;

    private void Start()
    {
        _boyut = _bedelText.transform.parent.gameObject.transform.parent.gameObject.transform.localScale;

        if (_bolge1Bolum2)
        {
            if (PlayerPrefs.GetInt("Bolge1Bolum2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Bolum2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Bolum2", _odenecekBedel);
            }

        }
        else if (_bolge1Bolum3)
        {
            if (PlayerPrefs.GetInt("Bolge1Bolum3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Bolum3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Bolum3", _odenecekBedel);
            }

        }
        else if (_bolge1Bolum4)
        {
            if (PlayerPrefs.GetInt("Bolge1Bolum4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Bolum4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Bolum4", _odenecekBedel);
            }

        }
        else if (_bolge1Tablo1)
        {
            if (PlayerPrefs.GetInt("Bolge1Tablo1") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Tablo1");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Tablo1", _odenecekBedel);
            }

        }
        else if (_bolge1Tablo2)
        {
            if (PlayerPrefs.GetInt("Bolge1Tablo2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Tablo2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Tablo2", _odenecekBedel);
            }

        }
        else if (_bolge1Tablo3)
        {
            if (PlayerPrefs.GetInt("Bolge1Tablo3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Tablo3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Tablo3", _odenecekBedel);
            }

        }
        else if (_bolge1Heykel1)
        {
            if (PlayerPrefs.GetInt("Bolge1Heykel1") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Heykel1");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Heykel1", _odenecekBedel);
            }

        }
        else if (_bolge1Heykel2)
        {
            if (PlayerPrefs.GetInt("Bolge1Heykel2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Heykel2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Heykel2", _odenecekBedel);
            }

        }
        else if (_bolge1Heykel3)
        {
            if (PlayerPrefs.GetInt("Bolge1Heykel3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Heykel3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Heykel3", _odenecekBedel);
            }

        }
        else if (_bolge1Heykel4)
        {
            if (PlayerPrefs.GetInt("Bolge1Heykel4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge1Heykel4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge1Heykel4", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel1)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel1") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel1");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel1", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel2)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel2", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel3)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel3", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel4)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel4", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel5)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel5") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel5");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel5", _odenecekBedel);
            }

        }
        else if (_bolge2Heykel6)
        {
            if (PlayerPrefs.GetInt("Bolge2Heykel6") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge2Heykel6");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge2Heykel6", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel1)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel1") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel1");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel1", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel2)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel2", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel3)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel3", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel4)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel4", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel5)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel5") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel5");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel5", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel6)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel6") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel6");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel6", _odenecekBedel);
            }

        }
        else if (_bolge3Heykel7)
        {
            if (PlayerPrefs.GetInt("Bolge3Heykel7") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge3Heykel7");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge3Heykel7", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel1)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel1") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel1");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel1", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel2)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel2", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel3)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel3", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel4)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel4", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel5)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel5") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel5");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel5", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel6)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel6") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel6");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel6", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel7)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel7") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel7");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel7", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel8)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel8") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel8");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel8", _odenecekBedel);
            }

        }
        else if (_bolge4Heykel9)
        {
            if (PlayerPrefs.GetInt("Bolge4Heykel9") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("Bolge4Heykel9");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("Bolge4Heykel9", _odenecekBedel);
            }

        }
        else if (_expandBolge2)
        {
            if (PlayerPrefs.GetInt("ExpandBolge2") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("ExpandBolge2");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("ExpandBolge2", _odenecekBedel);
            }

        }
        else if (_expandBolge3)
        {
            if (PlayerPrefs.GetInt("ExpandBolge3") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("ExpandBolge3");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("ExpandBolge3", _odenecekBedel);
            }

        }
        else if (_expandBolge4)
        {
            if (PlayerPrefs.GetInt("ExpandBolge4") > 0)
            {
                _odenecekBedel = PlayerPrefs.GetInt("ExpandBolge4");
                _bedelText.text = "$" + _odenecekBedel.ToString();
            }
            else
            {
                PlayerPrefs.SetInt("ExpandBolge4", _odenecekBedel);
            }

        }
        else
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BedelOdemeMoney")
        {
            BedelOdeUlen();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            _bedelText.transform.parent.gameObject.transform.parent.gameObject.transform.DOScale(new Vector3(_boyut.x * 1.2f, _boyut.y * 1.2f, _boyut.z * 1.2f), 0.1f).OnComplete(() => BoyutGuncelle());

        }
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _bedelText.transform.parent.gameObject.transform.parent.gameObject.transform.DOScale(new Vector3(_boyut.x / 1.2f, _boyut.y / 1.2f, _boyut.z / 1.2f), 0.1f).OnComplete(() => BoyutGuncelle());

        }
        else
        {

        }
    }

    private void BoyutGuncelle()
    {
        _boyut = _bedelText.transform.parent.gameObject.transform.parent.gameObject.transform.localScale;
    }
    public void BedelOdeUlen()
    {
        _odenecekBedel -= 10;
        _bedelText.transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.2f).OnComplete(() => _bedelText.transform.DOScale(new Vector3(1f, 1f, 1f), 0.2f));
        _bedelText.text = "$" + _odenecekBedel.ToString();
        _objeAcmaScript.ObjeAcmaKontrolEt();

        if (_bolge1Bolum2)
        {
            PlayerPrefs.SetInt("Bolge1Bolum2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Bolum3)
        {
            PlayerPrefs.SetInt("Bolge1Bolum3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Bolum4)
        {
            PlayerPrefs.SetInt("Bolge1Bolum4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Tablo1)
        {
            PlayerPrefs.SetInt("Bolge1Tablo1", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Tablo2)
        {
            PlayerPrefs.SetInt("Bolge1Tablo2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Tablo3)
        {
            PlayerPrefs.SetInt("Bolge1Tablo3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Heykel1)
        {
            PlayerPrefs.SetInt("Bolge1Heykel1", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Heykel2)
        {
            PlayerPrefs.SetInt("Bolge1Heykel2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Heykel3)
        {
            PlayerPrefs.SetInt("Bolge1Heykel3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge1Heykel4)
        {
            PlayerPrefs.SetInt("Bolge1Heykel4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel1", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel2)
        {
            PlayerPrefs.SetInt("Bolge2Heykel2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel3)
        {
            PlayerPrefs.SetInt("Bolge2Heykel3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel4)
        {
            PlayerPrefs.SetInt("Bolge2Heykel4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel5)
        {
            PlayerPrefs.SetInt("Bolge2Heykel5", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge2Heykel6)
        {
            PlayerPrefs.SetInt("Bolge2Heykel6", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel1", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel2)
        {
            PlayerPrefs.SetInt("Bolge3Heykel2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel3)
        {
            PlayerPrefs.SetInt("Bolge3Heykel3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel4)
        {
            PlayerPrefs.SetInt("Bolge3Heykel4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel5)
        {
            PlayerPrefs.SetInt("Bolge3Heykel5", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel6)
        {
            PlayerPrefs.SetInt("Bolge3Heykel6", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge3Heykel7)
        {
            PlayerPrefs.SetInt("Bolge3Heykel7", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel1", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel2)
        {
            PlayerPrefs.SetInt("Bolge4Heykel2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel3)
        {
            PlayerPrefs.SetInt("Bolge4Heykel3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel4)
        {
            PlayerPrefs.SetInt("Bolge4Heykel4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel5)
        {
            PlayerPrefs.SetInt("Bolge4Heykel5", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel6)
        {
            PlayerPrefs.SetInt("Bolge4Heykel6", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel7)
        {
            PlayerPrefs.SetInt("Bolge4Heykel7", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel8)
        {
            PlayerPrefs.SetInt("Bolge4Heykel8", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_bolge4Heykel9)
        {
            PlayerPrefs.SetInt("Bolge4Heykel9", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_expandBolge2)
        {
            PlayerPrefs.SetInt("ExpandBolge2", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_expandBolge3)
        {
            PlayerPrefs.SetInt("ExpandBolge3", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else if (_expandBolge4)
        {
            PlayerPrefs.SetInt("ExpandBolge4", _odenecekBedel);
            _bedelText.text = "$" + _odenecekBedel.ToString();
        }
        else
        {

        }


    }
}
