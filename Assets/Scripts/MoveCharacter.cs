using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private float characterSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        //Kullanıcının yürüme tuşuna basma miktarını alır
        float verticalSpeed = Input.GetAxis("Vertical");
        
        //Kullanıcıya tıklama miktarına göre ileri gitmesini sağlar
        transform.Translate(Vector3.forward * verticalSpeed * characterSpeed * Time.deltaTime);
    }
}
