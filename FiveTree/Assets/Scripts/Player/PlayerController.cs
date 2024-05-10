using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPool;
public class PlayerController : MonoBehaviour
{
    //组件获取
    private Rigidbody2D _rigidbody2D;

    private PlayerAttribute playerAttribute;


   
    private void Awake()
    {
        playerAttribute = GetComponent<PlayerAttribute>();
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();  
    }
    private void Update()
    {

        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        Vector2 position = transform.position;
        if (xMove != 0 && yMove != 0)
        {
            position.x = position.x + playerAttribute.playerMoveSpeed * 0.7f * xMove * Time.deltaTime;
            position.y = position.y + playerAttribute.playerMoveSpeed * 0.7f * yMove * Time.deltaTime;

        }
        else
        {
            if (xMove != 0)
            {
                position.x = position.x + playerAttribute.playerMoveSpeed * xMove * Time.deltaTime;//Time.deltaTime在小技巧中有讲,speed在最开始赋值，或者外部赋值
            }
            if (yMove != 0)
            {
                position.y = position.y + playerAttribute.playerMoveSpeed * yMove * Time.deltaTime;
            }
        }
   
        transform.position = position;

    }


    public void PlayerNormalAttack()
    {

    }
}
