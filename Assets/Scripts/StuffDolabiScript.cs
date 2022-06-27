using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StuffDolabiScript : MonoBehaviour
{
    [Header("Uretilecek Stuff Objesi")]
    [SerializeField] private GameObject _stuff;
    [Header("Spawn Point")]
    [SerializeField] private GameObject _spawnPoint;
    [Header("Stuff Toplama Hizi")]
    [SerializeField] private float _spawnHizi;
    [Header("Slider")]
    [SerializeField] private Slider _slider;
    [Header("Sinir Text")]
    [SerializeField] private Text _sinirText;
    [Header("Image")]
    [SerializeField] private GameObject _image;

    private float _timer;
    private float _garsonTimer;

    private int _üretilenStuff;

    private float _velocityX;
    private float _velocityZ;

    void Start()
    {
        _üretilenStuff = 0;
        _sinirText.gameObject.SetActive(false);
        _image.SetActive(false);
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _timer = 0;
            _slider.value = 0;
            _image.SetActive(true);
            _sinirText.gameObject.SetActive(true);
            _sinirText.text = other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiStuffObjeleri.Count.ToString() + " / " + other.gameObject.GetComponent<SirtCantasiScript>()._stuffStackSiniri.ToString();
        }
        else if (other.gameObject.tag == "Worker")
        {
            _garsonTimer = 0;
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
            _image.SetActive(false);
            _sinirText.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Worker")
        {
            _garsonTimer = 0;
        }
        else
        {

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            _velocityX = GameObject.FindGameObjectWithTag("Player").GetComponent<JoystickController>()._velocityX;
            _velocityZ = GameObject.FindGameObjectWithTag("Player").GetComponent<JoystickController>()._velocityZ;

            if (_velocityX == 0 || _velocityZ == 0)
            {
                if (other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiIceCreamObjeleri.Count == 0 && other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiDrinkObjeleri.Count == 0)
                {
                    if (other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiStuffObjeleri.Count < other.gameObject.GetComponent<SirtCantasiScript>()._stuffStackSiniri)
                    {
                        _timer += Time.deltaTime;
                        _slider.value += Time.deltaTime;

                        if (_timer > _spawnHizi)
                        {
                            GameObject stuff = Instantiate(_stuff, _spawnPoint.transform.position, Quaternion.identity);
                            other.gameObject.GetComponent<SirtCantasiScript>().StuffTopla(stuff);
                            _timer = 0;
                            _slider.value = 0;
                            _sinirText.text = other.gameObject.GetComponent<SirtCantasiScript>()._cantadakiStuffObjeleri.Count.ToString() + " / " + other.gameObject.GetComponent<SirtCantasiScript>()._stuffStackSiniri.ToString();
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
                    if (PlayerPrefs.GetInt("TrashSenaryosu") < 1)
                    {
                        StartCoroutine(GameObject.FindGameObjectWithTag("OnBoardingController").GetComponent<OnBoardingController>().TrashOnBoarding());
                        PlayerPrefs.SetInt("TrashSenaryosu", 1);
                    }
                    else
                    {

                    }
                }

            }
            else
            {

            }
        }
        else if (other.gameObject.tag == "Worker")
        {

            if (other.gameObject.GetComponent<WorkerScript>()._cantadakiStuffObjeleri.Count < other.gameObject.GetComponent<WorkerScript>()._stuffStackSiniri)
            {
                _garsonTimer += Time.deltaTime;


                if (_garsonTimer > 1)
                {
                    GameObject stuff = Instantiate(_stuff, _spawnPoint.transform.position, Quaternion.identity);
                    other.gameObject.GetComponent<WorkerScript>().StuffTopla(stuff);
                    _garsonTimer = 0;


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
}
