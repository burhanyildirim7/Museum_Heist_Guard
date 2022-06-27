using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance; // Singleton yapisi icin gerekli ornek

    public GameObject TapToStartPanel, GamePanel, _upgradePanel;
    public Text gamePlayScoreText, tapToStartScoreText;

    [Header("GEREKLI OBJELER")]
    [SerializeField] private GameObject _drinkAlani;
    [SerializeField] private GameObject _iceCreamAlani;
    [SerializeField] private GameObject _stuffAlani;

    [Header("UPGRADE EKRANI")]
    [Header("Player")]
    [SerializeField] private Text _playerSpeedPriceText;
    [SerializeField] private Slider _playerSpeedSlider;
    [SerializeField] private Button _playerSpeedButton;
    [SerializeField] private Text _playerCapacityPriceText;
    [SerializeField] private Slider _playerCapacitySlider;
    [SerializeField] private Button _playerCapacityButton;
    [Header("Garson")]
    [SerializeField] private Text _garsonAcmaPriceText;
    [SerializeField] private Slider _garsonAcmaSlider;
    [SerializeField] private Button _garsonAcmaButton;
    [Header("Sef")]
    [SerializeField] private Text _sefAcmaPriceText;
    [SerializeField] private Slider _sefAcmaSlider;
    [SerializeField] private Button _sefAcmaButton;
    [Header("Worker")]
    [SerializeField] private Text _workerAcmaPriceText;
    [SerializeField] private Slider _workerAcmaSlider;
    [SerializeField] private Button _workerAcmaButton;
    [Header("Worker Yukseltmeler")]
    [SerializeField] private Text _workerSpeedPriceText;
    [SerializeField] private Slider _workerSpeedSlider;
    [SerializeField] private Button _workerSpeedButton;
    [SerializeField] private Text _workerCapacityPriceText;
    [SerializeField] private Slider _workerCapacitySlider;
    [SerializeField] private Button _workerCapacityButton;


    private bool _upgradeScreenAcik;

    // singleton yapisi burada kuruluyor.
    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }

    private void Start()
    {
        StartUI();

        _upgradeScreenAcik = false;
    }

    // Oyun ilk acildiginda calisacak olan ui fonksiyonu. 
    public void StartUI()
    {
        ActivateTapToStartScreen();
    }

    private void FixedUpdate()
    {
        if (_upgradeScreenAcik)
        {
            UpgradeScreenOpen();
        }
        else
        {

        }
    }

    /// <summary>
    /// Level numarasini ui kisminda degistirmek icin fonksiyon. Parametre olarak level numarasi aliyor.
    /// </summary>
    /// <param name="levelNo">UI ekranina yazilmak istenen Level numaras?</param>


    // TAPTOSTART TUSUNA BASILDISINDA  --- GIRIS EKRANINDA VE LEVEL BASLARINDA
    public void TapToStartButtonClick()
    {

        GameController.instance.isContinue = true;
        //PlayerController.instance.SetArmForGaming();
        TapToStartPanel.SetActive(false);
        GamePanel.SetActive(true);
        //SetLevelText(LevelController.instance.totalLevelNo);
        SetGamePlayScoreText();

        if (PlayerPrefs.GetInt("AcilisSenaryosu") < 1)
        {
            StartCoroutine(GameObject.FindGameObjectWithTag("OnBoardingController").GetComponent<OnBoardingController>().StartOnBoarding());
            PlayerPrefs.SetInt("AcilisSenaryosu", 1);
        }
        else
        {

        }

    }

    // RESTART TUSUNA BASILDISINDA  --- LOOSE EKRANINDA
    public void RestartButtonClick()
    {
        GamePanel.SetActive(false);
        //LoosePanel.SetActive(false);
        TapToStartPanel.SetActive(true);
        LevelController.instance.RestartLevelEvents();
        SetTapToStartScoreText();
    }


    // NEXT LEVEL TUSUNA BASILDIGINDA... WIN EKRANINDAKI BUTON
    public void NextLevelButtonClick()
    {
        SetTapToStartScoreText();
        TapToStartPanel.SetActive(true);
        //WinPanel.SetActive(false);
        GamePanel.SetActive(false);
        LevelController.instance.NextLevelEvents();
        //StartCoroutine(StartScreenCoinEffect());
    }


    /// <summary>
    /// Bu fonksiyon gameplay ekranindaki score textini gunceller.
    /// </summary>
    public void SetGamePlayScoreText()
    {
        gamePlayScoreText.text = PlayerPrefs.GetInt("Money").ToString();
    }


    /// <summary>
    /// Bu fonksiyon totalScore un yazilmasi gereken textleri gunceller.
    /// </summary>
    public void SetTapToStartScoreText()
    {
        tapToStartScoreText.text = PlayerPrefs.GetInt("Money").ToString();
    }

    /// <summary>
    /// Bu fonksiyon winscreen de ge?erli level scoreunun yazildigi texti gunceller.
    /// </summary>
    public void WinScreenScore()
    {
        //winScreenScoreText.text = GameController.instance.score.ToString();
    }

    /// <summary>
    /// Bu fonksiyon totalElmas sayilarinin yazildigi textleri gunceller.
    /// </summary>
    public void SetTotalElmasText()
    {
        //totalElmasText.text = PlayerPrefs.GetInt("totalElmas").ToString();
    }

    /// <summary>
    /// Bu fonksiyon winscreen ekranini acar.
    /// </summary>
    public void ActivateWinScreen()
    {
        GamePanel.SetActive(false);
        //StartCoroutine(WinScreenDelay());
    }

    /// <summary>
    /// Bu fonksiyon loose secreeni acar. 
    /// </summary>
    public void ActivateLooseScreen()
    {
        GamePanel.SetActive(false);
        //LoosePanel.SetActive(true);
    }


    /// <summary>
    /// Bu fonksiyon gamescreeni acar.
    /// </summary>
    public void ActivateGameScreen()
    {
        GamePanel.SetActive(true);
        TapToStartPanel.SetActive(false);
        SetGamePlayScoreText();
    }

    /// <summary>
    /// Bu fonksiyon taptostartscreen i acar.
    /// </summary>
    public void ActivateTapToStartScreen()
    {
        TapToStartPanel.SetActive(true);
        //WinPanel.SetActive(false);
        //LoosePanel.SetActive(false);
        GamePanel.SetActive(false);
        tapToStartScoreText.text = PlayerPrefs.GetInt("Money").ToString();
    }

    public void UpgradeCanvasAc()
    {
        //GamePanel.SetActive(false);
        _upgradePanel.SetActive(true);
        _upgradeScreenAcik = true;

        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
    }

    public void UpgradeCanvasKapat()
    {
        _upgradePanel.SetActive(false);
        _upgradeScreenAcik = false;

        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
        //GamePanel.SetActive(true);

    }


    //------------------UPGRADE EKRANI----------------------------------------------------

    private void UpgradeScreenOpen()
    {

        //-------PLAYER SPEED--------

        if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 0)
        {
            _playerSpeedPriceText.text = "$500";
            _playerSpeedSlider.value = 1;

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _playerSpeedButton.interactable = false;
            }
            else
            {
                _playerSpeedButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 1)
        {
            _playerSpeedPriceText.text = "$1000";
            _playerSpeedSlider.value = 2;

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _playerSpeedButton.interactable = false;
            }
            else
            {
                _playerSpeedButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 2)
        {
            _playerSpeedPriceText.text = "MAX LEVEL";
            _playerSpeedSlider.value = 3;


            _playerSpeedButton.interactable = false;

        }
        else
        {

        }

        //-------PLAYER CAPACITY--------

        if (PlayerPrefs.GetInt("PlayerCapacityLevel") == 0)
        {
            _playerCapacityPriceText.text = "$500";
            _playerCapacitySlider.value = 1;

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _playerCapacityButton.interactable = false;
            }
            else
            {
                _playerCapacityButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("PlayerCapacityLevel") == 1)
        {
            _playerCapacityPriceText.text = "$1000";
            _playerCapacitySlider.value = 2;

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _playerCapacityButton.interactable = false;
            }
            else
            {
                _playerCapacityButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("PlayerCapacityLevel") == 2)
        {
            _playerCapacityPriceText.text = "MAX LEVEL";
            _playerCapacitySlider.value = 3;


            _playerCapacityButton.interactable = false;

        }
        else
        {

        }


        //-------GARSON SATIN AL--------

        if (PlayerPrefs.GetInt("GarsonSayisi") == 0)
        {
            if (_drinkAlani.activeSelf)
            {
                _garsonAcmaPriceText.text = "$1000";
                _garsonAcmaSlider.value = 0;

                if (PlayerPrefs.GetInt("Money") < 1000)
                {
                    _garsonAcmaButton.interactable = false;
                }
                else
                {
                    _garsonAcmaButton.interactable = true;
                }
            }
            else
            {
                _garsonAcmaPriceText.text = "BUY BEACH PUB";
                _garsonAcmaSlider.value = 0;
                _garsonAcmaButton.interactable = false;
            }

        }
        else if (PlayerPrefs.GetInt("GarsonSayisi") == 1)
        {
            _garsonAcmaPriceText.text = "EXPAND 2. AREA";
            _garsonAcmaSlider.value = 1;
            _garsonAcmaButton.interactable = false;

        }
        else
        {

        }

        //-------SEF SATIN AL--------

        if (PlayerPrefs.GetInt("SefSayisi") == 0)
        {
            if (_iceCreamAlani.activeSelf)
            {
                _sefAcmaPriceText.text = "$1000";
                _sefAcmaSlider.value = 0;

                if (PlayerPrefs.GetInt("Money") < 1000)
                {
                    _sefAcmaButton.interactable = false;
                }
                else
                {
                    _sefAcmaButton.interactable = true;
                }
            }
            else
            {
                _sefAcmaPriceText.text = "BUY ICE CREAM MAKER";
                _sefAcmaSlider.value = 0;
                _sefAcmaButton.interactable = false;
            }

        }
        else if (PlayerPrefs.GetInt("SefSayisi") == 1)
        {
            _sefAcmaPriceText.text = "EXPAND 2. AREA";
            _sefAcmaSlider.value = 1;
            _sefAcmaButton.interactable = false;

        }
        else
        {

        }

        //-------WORKER SATIN AL--------

        if (PlayerPrefs.GetInt("WorkerSayisi") == 0)
        {

            _workerAcmaPriceText.text = "$500";
            _workerAcmaSlider.value = 0;

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _workerAcmaButton.interactable = false;
            }
            else
            {
                _workerAcmaButton.interactable = true;
            }


        }
        else if (PlayerPrefs.GetInt("WorkerSayisi") == 1)
        {
            _workerAcmaPriceText.text = "$1000";
            _workerAcmaSlider.value = 1;

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerAcmaButton.interactable = false;
            }
            else
            {
                _workerAcmaButton.interactable = true;
            }

        }
        else if (PlayerPrefs.GetInt("WorkerSayisi") == 2)
        {
            _workerAcmaPriceText.text = "EXPAND 2. AREA";
            _workerAcmaSlider.value = 2;
            _workerAcmaButton.interactable = false;

        }
        else
        {

        }


        //-------WORKER SPEED--------

        if (PlayerPrefs.GetInt("WorkerSpeedLevel") == 0)
        {
            _workerSpeedPriceText.text = "$1000";
            _workerSpeedSlider.value = 1;

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerSpeedButton.interactable = false;
            }
            else
            {
                _workerSpeedButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("WorkerSpeedLevel") == 1)
        {
            _workerSpeedPriceText.text = "$2000";
            _workerSpeedSlider.value = 2;

            if (PlayerPrefs.GetInt("Money") < 2000)
            {
                _workerSpeedButton.interactable = false;
            }
            else
            {
                _workerSpeedButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("WorkerSpeedLevel") == 2)
        {
            _workerSpeedPriceText.text = "MAX LEVEL";
            _workerSpeedSlider.value = 3;


            _workerSpeedButton.interactable = false;

        }
        else
        {

        }

        //-------WORKER CAPACITY--------

        if (PlayerPrefs.GetInt("WorkerCapacityLevel") == 0)
        {
            _workerCapacityPriceText.text = "$1000";
            _workerCapacitySlider.value = 1;

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerCapacityButton.interactable = false;
            }
            else
            {
                _workerCapacityButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("WorkerCapacityLevel") == 1)
        {
            _workerCapacityPriceText.text = "$2000";
            _workerCapacitySlider.value = 2;

            if (PlayerPrefs.GetInt("Money") < 2000)
            {
                _workerCapacityButton.interactable = false;
            }
            else
            {
                _workerCapacityButton.interactable = true;
            }
        }
        else if (PlayerPrefs.GetInt("WorkerCapacityLevel") == 2)
        {
            _workerCapacityPriceText.text = "MAX LEVEL";
            _workerCapacitySlider.value = 3;


            _workerCapacityButton.interactable = false;

        }
        else
        {

        }
    }

    public void PlayerSpeedButton()
    {
        if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _playerSpeedButton.interactable = false;
            }
            else
            {
                _playerSpeedButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("PlayerSpeedLevel", 1);
                GameObject.FindGameObjectWithTag("Player").GetComponent<JoystickController>().PlayerSpeedGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 1)
        {


            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _playerSpeedButton.interactable = false;
            }
            else
            {
                _playerSpeedButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("PlayerSpeedLevel", 2);
                GameObject.FindGameObjectWithTag("Player").GetComponent<JoystickController>().PlayerSpeedGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else
        {

        }
    }


    public void PlayerCapacityButton()
    {
        if (PlayerPrefs.GetInt("PlayerCapacityLevel") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _playerCapacityButton.interactable = false;
            }
            else
            {
                _playerCapacityButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("PlayerCapacityLevel", 1);
                GameObject.FindGameObjectWithTag("Player").GetComponent<SirtCantasiScript>().PlayerCapacityGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("PlayerCapacityLevel") == 1)
        {


            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _playerCapacityButton.interactable = false;
            }
            else
            {
                _playerCapacityButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("PlayerCapacityLevel", 2);
                GameObject.FindGameObjectWithTag("Player").GetComponent<SirtCantasiScript>().PlayerCapacityGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else
        {

        }
    }

    public void GarsonSatinAlButton()
    {
        if (PlayerPrefs.GetInt("GarsonSayisi") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _garsonAcmaButton.interactable = false;
            }
            else
            {
                _garsonAcmaButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("GarsonSayisi", 1);
                _drinkAlani.GetComponent<garsonAcmaScripti>().GarsonAc();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("GarsonSayisi") == 1)
        {



            _garsonAcmaButton.interactable = false;


        }
        else
        {

        }
    }

    public void SefSatinAlButton()
    {
        if (PlayerPrefs.GetInt("SefSayisi") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _sefAcmaButton.interactable = false;
            }
            else
            {
                _sefAcmaButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("SefSayisi", 1);
                _iceCreamAlani.GetComponent<garsonAcmaScripti>().GarsonAc();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("SefSayisi") == 1)
        {



            _sefAcmaButton.interactable = false;


        }
        else
        {

        }
    }

    public void WorkerSatinAlButton()
    {
        if (PlayerPrefs.GetInt("WorkerSayisi") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 500)
            {
                _workerAcmaButton.interactable = false;
            }
            else
            {
                _workerAcmaButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerSayisi", 1);
                _stuffAlani.GetComponent<garsonAcmaScripti>().GarsonAc();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("WorkerSayisi") == 1)
        {

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerAcmaButton.interactable = false;
            }
            else
            {
                _workerAcmaButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerSayisi", 2);
                _stuffAlani.GetComponent<garsonAcmaScripti>().GarsonAc();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("WorkerSayisi") == 2)
        {



            _workerAcmaButton.interactable = false;


        }
        else
        {

        }
    }

    public void WorkerSpeedButton()
    {
        if (PlayerPrefs.GetInt("WorkerSpeedLevel") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerSpeedButton.interactable = false;
            }
            else
            {
                _workerSpeedButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerSpeedLevel", 1);
                GameObject.FindGameObjectWithTag("Garson").GetComponent<GarsonScript>().GarsonSpeedGuncelle();
                GameObject.FindGameObjectWithTag("Sef").GetComponent<SefScript>().SefSpeedGuncelle();
                GameObject.FindGameObjectWithTag("Worker").GetComponent<WorkerScript>().WorkerSpeedGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("WorkerSpeedLevel") == 1)
        {


            if (PlayerPrefs.GetInt("Money") < 2000)
            {
                _workerSpeedButton.interactable = false;
            }
            else
            {
                _workerSpeedButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerSpeedLevel", 2);
                GameObject.FindGameObjectWithTag("Garson").GetComponent<GarsonScript>().GarsonSpeedGuncelle();
                GameObject.FindGameObjectWithTag("Sef").GetComponent<SefScript>().SefSpeedGuncelle();
                GameObject.FindGameObjectWithTag("Worker").GetComponent<WorkerScript>().WorkerSpeedGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else
        {

        }
    }


    public void WorkerCapacityButton()
    {
        if (PlayerPrefs.GetInt("WorkerCapacityLevel") == 0)
        {

            if (PlayerPrefs.GetInt("Money") < 1000)
            {
                _workerCapacityButton.interactable = false;
            }
            else
            {
                _workerCapacityButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerCapacityLevel", 1);
                GameObject.FindGameObjectWithTag("Garson").GetComponent<GarsonScript>().GarsonCapacityGuncelle();
                GameObject.FindGameObjectWithTag("Sef").GetComponent<SefScript>().SefCapacityGuncelle();
                GameObject.FindGameObjectWithTag("Worker").GetComponent<WorkerScript>().WorkerCapacityGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else if (PlayerPrefs.GetInt("WorkerCapacityLevel") == 1)
        {


            if (PlayerPrefs.GetInt("Money") < 2000)
            {
                _workerCapacityButton.interactable = false;
            }
            else
            {
                _workerCapacityButton.interactable = true;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
                SetGamePlayScoreText();
                PlayerPrefs.SetInt("WorkerCapacityLevel", 2);
                GameObject.FindGameObjectWithTag("Garson").GetComponent<GarsonScript>().GarsonCapacityGuncelle();
                GameObject.FindGameObjectWithTag("Sef").GetComponent<SefScript>().SefCapacityGuncelle();
                GameObject.FindGameObjectWithTag("Worker").GetComponent<WorkerScript>().WorkerCapacityGuncelle();
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            }
        }
        else
        {

        }
    }

}
