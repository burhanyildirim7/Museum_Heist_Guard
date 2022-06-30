using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjeAcmaScript : MonoBehaviour
{
    [SerializeField] private Text bedelText;
    [SerializeField] private List<GameObject> _acilacakObjeler = new List<GameObject>();
    [SerializeField] private List<GameObject> _kapanacakObjeler = new List<GameObject>();
    [SerializeField] private AcilisAnimasyonScript _acilisAnimasyonScript;
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


    void Start()
    {

        if (_bolge1Bolum2 && PlayerPrefs.GetInt("Bolge1Bolum2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();


        }
        else if (_bolge1Bolum3 && PlayerPrefs.GetInt("Bolge1Bolum3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Bolum4 && PlayerPrefs.GetInt("Bolge1Bolum4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Tablo1 && PlayerPrefs.GetInt("Bolge1Tablo1AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Tablo2 && PlayerPrefs.GetInt("Bolge1Tablo2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Tablo3 && PlayerPrefs.GetInt("Bolge1Tablo3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Heykel1 && PlayerPrefs.GetInt("Bolge1Heykel1AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Heykel2 && PlayerPrefs.GetInt("Bolge1Heykel2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Heykel3 && PlayerPrefs.GetInt("Bolge1Heykel3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge1Heykel4 && PlayerPrefs.GetInt("Bolge1Heykel4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel1 && PlayerPrefs.GetInt("Bolge2Heykel1AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel2 && PlayerPrefs.GetInt("Bolge2Heykel2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel3 && PlayerPrefs.GetInt("Bolge2Heykel3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel4 && PlayerPrefs.GetInt("Bolge2Heykel4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel5 && PlayerPrefs.GetInt("Bolge2Heykel5AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge2Heykel6 && PlayerPrefs.GetInt("Bolge2Heykel6AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel1 && PlayerPrefs.GetInt("Bolge3Heykel1AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel2 && PlayerPrefs.GetInt("Bolge3Heykel2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel3 && PlayerPrefs.GetInt("Bolge3Heykel3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel4 && PlayerPrefs.GetInt("Bolge3Heykel4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel5 && PlayerPrefs.GetInt("Bolge3Heykel5AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel6 && PlayerPrefs.GetInt("Bolge3Heykel6AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge3Heykel7 && PlayerPrefs.GetInt("Bolge3Heykel7AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel1 && PlayerPrefs.GetInt("Bolge4Heykel1AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel2 && PlayerPrefs.GetInt("Bolge4Heykel2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel3 && PlayerPrefs.GetInt("Bolge4Heykel3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel4 && PlayerPrefs.GetInt("Bolge4Heykel4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel5 && PlayerPrefs.GetInt("Bolge4Heykel5AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel6 && PlayerPrefs.GetInt("Bolge4Heykel6AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel7 && PlayerPrefs.GetInt("Bolge4Heykel7AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel8 && PlayerPrefs.GetInt("Bolge4Heykel8AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_bolge4Heykel9 && PlayerPrefs.GetInt("Bolge4Heykel9AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_expandBolge2 && PlayerPrefs.GetInt("ExpandBolge2AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_expandBolge3 && PlayerPrefs.GetInt("ExpandBolge3AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (_expandBolge4 && PlayerPrefs.GetInt("ExpandBolge4AcikMi") == 1)
        {

            ObjeleriKapat();
            ObjeleriAc();

        }
        else
        {

        }
    }

    public void KacirilanObjeYerlestir()
    {
        if (_bolge1Bolum2 && PlayerPrefs.GetInt("Bolge1Bolum2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Bolum2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();


        }
        else if (_bolge1Bolum3 && PlayerPrefs.GetInt("Bolge1Bolum3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Bolum3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Bolum4 && PlayerPrefs.GetInt("Bolge1Bolum4AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Bolum4AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Tablo1 && PlayerPrefs.GetInt("Bolge1Tablo1AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Tablo1AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Tablo2 && PlayerPrefs.GetInt("Bolge1Tablo2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Tablo2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Tablo3 && PlayerPrefs.GetInt("Bolge1Tablo3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Tablo3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Heykel1 && PlayerPrefs.GetInt("Bolge1Heykel1AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Heykel1AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Heykel2 && PlayerPrefs.GetInt("Bolge1Heykel2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Heykel2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Heykel3 && PlayerPrefs.GetInt("Bolge1Heykel3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Heykel3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge1Heykel4 && PlayerPrefs.GetInt("Bolge1Heykel4AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge1Heykel4AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel1 && PlayerPrefs.GetInt("Bolge2Heykel1AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel1AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel2 && PlayerPrefs.GetInt("Bolge2Heykel2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel3 && PlayerPrefs.GetInt("Bolge2Heykel3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel4 && PlayerPrefs.GetInt("Bolge2Heykel4AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel4AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel5 && PlayerPrefs.GetInt("Bolge2Heykel5AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel5AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge2Heykel6 && PlayerPrefs.GetInt("Bolge2Heykel6AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge2Heykel6AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel1 && PlayerPrefs.GetInt("Bolge3Heykel1AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel1AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel2 && PlayerPrefs.GetInt("Bolge3Heykel2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel3 && PlayerPrefs.GetInt("Bolge3Heykel3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel4 && PlayerPrefs.GetInt("Bolge3Heykel4AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel4AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel5 && PlayerPrefs.GetInt("Bolge3Heykel5AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel5AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel6 && PlayerPrefs.GetInt("Bolge3Heykel6AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel6AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge3Heykel7 && PlayerPrefs.GetInt("Bolge3Heykel7AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge3Heykel7AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel1 && PlayerPrefs.GetInt("Bolge4Heykel1AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel1AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel2 && PlayerPrefs.GetInt("Bolge4Heykel2AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel2AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel3 && PlayerPrefs.GetInt("Bolge4Heykel3AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel3AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel4 && PlayerPrefs.GetInt("Bolge4Heykel4AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel4AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel5 && PlayerPrefs.GetInt("Bolge4Heykel5AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel5AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel6 && PlayerPrefs.GetInt("Bolge4Heykel6AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel6AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel7 && PlayerPrefs.GetInt("Bolge4Heykel7AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel7AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel8 && PlayerPrefs.GetInt("Bolge4Heykel8AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel8AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else if (_bolge4Heykel9 && PlayerPrefs.GetInt("Bolge4Heykel9AcikMi") == 1)
        {
            PlayerPrefs.SetInt("Bolge4Heykel9AcikMi", 0);
            //ObjeleriKapat();
            //ObjeleriAc();

        }
        else
        {

        }
    }

    private void ObjeleriAc()
    {
        if (_acilacakObjeler.Count > 0)
        {
            for (int i = 0; i < _acilacakObjeler.Count; i++)
            {
                _acilacakObjeler[i].SetActive(true);
            }
        }
        else
        {

        }
    }

    private void ObjeleriKapat()
    {
        if (_kapanacakObjeler.Count > 0)
        {
            for (int i = 0; i < _kapanacakObjeler.Count; i++)
            {
                _kapanacakObjeler[i].SetActive(false);
            }
        }
        else
        {

        }

        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }



    public void ObjeAcmaKontrolEt()
    {


        if (bedelText.text == "$0" && _bolge1Bolum2 && PlayerPrefs.GetInt("Bolge1Bolum2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Bolum2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            PlayerPrefs.SetInt("GiseSayisi", PlayerPrefs.GetInt("GiseSayisi") + 1);
            GameObject.FindGameObjectWithTag("AISpawnController").GetComponent<AISpawnController>().SpawnHizGuncelle();


        }
        else if (bedelText.text == "$0" && _bolge1Bolum3 && PlayerPrefs.GetInt("Bolge1Bolum3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Bolum3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            PlayerPrefs.SetInt("GiseSayisi", PlayerPrefs.GetInt("GiseSayisi") + 1);
            GameObject.FindGameObjectWithTag("AISpawnController").GetComponent<AISpawnController>().SpawnHizGuncelle();

        }
        else if (bedelText.text == "$0" && _bolge1Bolum4 && PlayerPrefs.GetInt("Bolge1Bolum4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Bolum4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            PlayerPrefs.SetInt("GiseSayisi", PlayerPrefs.GetInt("GiseSayisi") + 1);
            GameObject.FindGameObjectWithTag("AISpawnController").GetComponent<AISpawnController>().SpawnHizGuncelle();

        }
        else if (bedelText.text == "$0" && _bolge1Tablo1 && PlayerPrefs.GetInt("Bolge1Tablo1AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Tablo1AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (bedelText.text == "$0" && _bolge1Tablo2 && PlayerPrefs.GetInt("Bolge1Tablo2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Tablo2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (bedelText.text == "$0" && _bolge1Tablo3 && PlayerPrefs.GetInt("Bolge1Tablo3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Tablo3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (bedelText.text == "$0" && _bolge1Heykel1 && PlayerPrefs.GetInt("Bolge1Heykel1AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Heykel1AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge1Heykel2 && PlayerPrefs.GetInt("Bolge1Heykel2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Heykel2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge1Heykel3 && PlayerPrefs.GetInt("Bolge1Heykel3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Heykel3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge1Heykel4 && PlayerPrefs.GetInt("Bolge1Heykel4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge1Heykel4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel1 && PlayerPrefs.GetInt("Bolge2Heykel1AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel1AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel2 && PlayerPrefs.GetInt("Bolge2Heykel2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel3 && PlayerPrefs.GetInt("Bolge2Heykel3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel4 && PlayerPrefs.GetInt("Bolge2Heykel4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel5 && PlayerPrefs.GetInt("Bolge2Heykel5AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel5AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge2Heykel6 && PlayerPrefs.GetInt("Bolge2Heykel6AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge2Heykel6AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel1 && PlayerPrefs.GetInt("Bolge3Heykel1AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel1AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel2 && PlayerPrefs.GetInt("Bolge3Heykel2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel3 && PlayerPrefs.GetInt("Bolge3Heykel3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel4 && PlayerPrefs.GetInt("Bolge3Heykel4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel5 && PlayerPrefs.GetInt("Bolge3Heykel5AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel5AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel6 && PlayerPrefs.GetInt("Bolge3Heykel6AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel6AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge3Heykel7 && PlayerPrefs.GetInt("Bolge3Heykel7AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge3Heykel7AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel1 && PlayerPrefs.GetInt("Bolge4Heykel1AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel1AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel2 && PlayerPrefs.GetInt("Bolge4Heykel2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel3 && PlayerPrefs.GetInt("Bolge4Heykel3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel4 && PlayerPrefs.GetInt("Bolge4Heykel4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel5 && PlayerPrefs.GetInt("Bolge4Heykel5AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel5AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel6 && PlayerPrefs.GetInt("Bolge4Heykel6AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel6AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel7 && PlayerPrefs.GetInt("Bolge4Heykel7AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel7AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel8 && PlayerPrefs.GetInt("Bolge4Heykel8AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel8AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _bolge4Heykel9 && PlayerPrefs.GetInt("Bolge4Heykel9AcikMi") == 0)
        {
            PlayerPrefs.SetInt("Bolge4Heykel9AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();
            _acilisAnimasyonScript.AcilisAnim();

        }
        else if (bedelText.text == "$0" && _expandBolge2 && PlayerPrefs.GetInt("ExpandBolge2AcikMi") == 0)
        {
            PlayerPrefs.SetInt("ExpandBolge2AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (bedelText.text == "$0" && _expandBolge3 && PlayerPrefs.GetInt("ExpandBolge3AcikMi") == 0)
        {
            PlayerPrefs.SetInt("ExpandBolge3AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else if (bedelText.text == "$0" && _expandBolge4 && PlayerPrefs.GetInt("ExpandBolge4AcikMi") == 0)
        {
            PlayerPrefs.SetInt("ExpandBolge4AcikMi", 1);
            ObjeleriKapat();
            ObjeleriAc();

        }
        else
        {

        }

    }

}
