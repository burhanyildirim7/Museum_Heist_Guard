using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardingController : MonoBehaviour
{

    [SerializeField] private GameObject _onBoardingOku;
    [SerializeField] private GameObject _hediyeParaKonum;
    [SerializeField] private GameObject _ilkHeykelKonum;
    [SerializeField] private GameObject _kelepceDolabi;
    [SerializeField] private GameObject _drinkKonum;
    [SerializeField] private GameObject _iceCreamKonum;
    [SerializeField] private GameObject _trashKonum;
    [SerializeField] private GameObject _canSimidiKonum;
    [SerializeField] private GameObject _sezlongKonum;
    [SerializeField] private GameObject _upgradeAlaniKonum;

    private CameraMovement _cameraMovement;


    void Start()
    {
        _cameraMovement = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>();
        _onBoardingOku.SetActive(false);

        //StartCoroutine(StartOnBoarding());
    }

    public IEnumerator StartOnBoarding()
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(_hediyeParaKonum);

        _onBoardingOku.transform.position = new Vector3(_hediyeParaKonum.transform.position.x, 3, _hediyeParaKonum.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _cameraMovement.KamerayiYonlendir(_ilkHeykelKonum);

        _onBoardingOku.transform.position = new Vector3(_ilkHeykelKonum.transform.position.x, 3, _ilkHeykelKonum.transform.position.z);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator HirsizOnBoarding(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _cameraMovement.KamerayiYonlendir(_kelepceDolabi);

        _onBoardingOku.transform.position = new Vector3(_kelepceDolabi.transform.position.x, 3, _kelepceDolabi.transform.position.z);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator KurtarmaOnBoarding(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator IcecekOnBoarding(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _cameraMovement.KamerayiYonlendir(_drinkKonum);

        _onBoardingOku.transform.position = new Vector3(_drinkKonum.transform.position.x, 5, _drinkKonum.transform.position.z);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator DondurmaOnBoarding(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _cameraMovement.KamerayiYonlendir(_iceCreamKonum);

        _onBoardingOku.transform.position = new Vector3(_iceCreamKonum.transform.position.x, 5, _iceCreamKonum.transform.position.z);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator TrashOnBoarding()
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(_trashKonum);

        _onBoardingOku.transform.position = new Vector3(_trashKonum.transform.position.x, 5, _trashKonum.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator BogulmaOnBoarding(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _cameraMovement.KamerayiYonlendir(_canSimidiKonum);

        _onBoardingOku.transform.position = new Vector3(_canSimidiKonum.transform.position.x, 5, _canSimidiKonum.transform.position.z);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator BogulmaSenaryo(GameObject obje)
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(obje);

        _onBoardingOku.transform.position = new Vector3(obje.transform.position.x, 3, obje.transform.position.z);
        //_onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        //_onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }

    public IEnumerator UpgradeSenaryo()
    {
        GameController.instance._kameraHareketli = true;

        _cameraMovement.KamerayiYonlendir(_upgradeAlaniKonum);

        _onBoardingOku.transform.position = new Vector3(_upgradeAlaniKonum.transform.position.x, 5, _upgradeAlaniKonum.transform.position.z);
        _onBoardingOku.SetActive(true);

        yield return new WaitForSeconds(3f);

        _onBoardingOku.SetActive(false);

        _cameraMovement.KamerayiResetle();

        GameController.instance._kameraHareketli = false;

    }



}
