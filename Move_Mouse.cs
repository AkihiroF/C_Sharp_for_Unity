using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Mouse : MonoBehaviour
{
    CharacterController _charachterController;
    public float speed_Move;
    float x_Move;
    float z_Move;
    public float gravity;
    public float jump;
    public float super_speed;
    public float speed_Current;
    public AudioSource audio;
    Vector3 move_Direction;
    
    public bool hentai = true;


    void Start()
    {
        _charachterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        if (hentai)
        {
            Move();
        }
            
        
    }
    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (_charachterController.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                audio.Play();
                move_Direction.y += jump;
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                _charachterController.height = 1f;
            }
            else
            {
                _charachterController.height = 2f;
                
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed_Current = super_speed;
        }
        else
        {
            speed_Current = speed_Move;
        }
        move_Direction.y -= gravity;
        _charachterController.Move(move_Direction * speed_Current * Time.deltaTime);
    }
}
