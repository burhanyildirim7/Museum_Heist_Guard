using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public float _speed;
    public FloatingJoystick _floatingJoystick;
    public Rigidbody _rigidbody;

    public float _velocityX;
    public float _velocityZ;

    [SerializeField] private PlayerController _playerController;

    [SerializeField] private Animator _animator;

    public bool _kelepceliyor;

    private void Start()
    {
        //PlayerSpeedGuncelle();
    }


    public void FixedUpdate()
    {
        if (GameController.instance.isContinue == true && GameController.instance._kameraHareketli == false)
        {

            if (_kelepceliyor == false)
            {
                Vector3 direction = Vector3.forward * _floatingJoystick.Vertical + Vector3.right * _floatingJoystick.Horizontal;
                // transform.Translate(direction * Time.deltaTime * _speed);
                _rigidbody.velocity = new Vector3(_floatingJoystick.Horizontal * _speed, _rigidbody.velocity.y, _floatingJoystick.Vertical * _speed);

                if (_floatingJoystick.Horizontal != 0 || _floatingJoystick.Vertical != 0)
                {
                    transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
                }
            }
            else
            {
                _rigidbody.velocity = Vector3.zero;
            }


            /*
            if (_floatingJoystick.Horizontal == 0 && _floatingJoystick.Vertical == 0)
            {
                _rigidbody.velocity = Vector3.zero;

            }
            */
            _velocityX = _rigidbody.velocity.x;
            _velocityZ = _rigidbody.velocity.z;



            if (_rigidbody.velocity.x != 0 || _rigidbody.velocity.z != 0)
            {
                if (_playerController._kelepceliyorMu)
                {
                    _animator.SetBool("CarryWalk", false);
                    _animator.SetBool("CarryIdle", false);
                    _animator.SetBool("Run", false);
                    _animator.SetBool("Kelepcele", true);
                }
                else
                {
                    if (PlayerController._elindeEserVar == true)
                    {
                        _animator.SetBool("Kelepcele", false);
                        _animator.SetBool("Run", false);
                        _animator.SetBool("CarryIdle", false);
                        _animator.SetBool("CarryWalk", true);
                    }
                    else
                    {
                        _animator.SetBool("Kelepcele", false);
                        _animator.SetBool("CarryWalk", false);
                        _animator.SetBool("CarryIdle", false);
                        _animator.SetBool("Run", true);

                    }
                }



            }
            else
            {
                if (_playerController._kelepceliyorMu)
                {
                    _animator.SetBool("CarryWalk", false);
                    _animator.SetBool("CarryIdle", false);
                    _animator.SetBool("Run", false);
                    _animator.SetBool("Kelepcele", true);
                }
                else
                {
                    if (PlayerController._elindeEserVar == true)
                    {
                        _animator.SetBool("Kelepcele", false);
                        _animator.SetBool("Run", false);
                        _animator.SetBool("CarryWalk", false);
                        _animator.SetBool("CarryIdle", true);
                    }
                    else
                    {
                        _animator.SetBool("Kelepcele", false);
                        _animator.SetBool("CarryWalk", false);
                        _animator.SetBool("CarryIdle", false);
                        _animator.SetBool("Run", false);

                    }
                }


            }


            //transform.Rotate(0, _floatingJoystick.Horizontal * 1f, 0);
        }
        else
        {
            _rigidbody.velocity = Vector3.zero;
        }



    }

    public void PlayerSpeedGuncelle()
    {
        if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 0)
        {
            _speed = 4;
        }
        else if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 1)
        {
            _speed = 4.5f;
        }
        else if (PlayerPrefs.GetInt("PlayerSpeedLevel") == 2)
        {
            _speed = 5;
        }
        else
        {

        }
    }



}
