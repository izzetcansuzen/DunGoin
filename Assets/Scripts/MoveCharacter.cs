using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private float characterSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        //Oyuncu yürüme tuşlarına basınca girilen değeri al
        float verticalSpeed = Input.GetAxis("Vertical");
        float horizontalSpeed = Input.GetAxis("Horizontal");

        //Oyuncu tıklamasına göre karakteri yönlendir
        transform.Translate(Vector3.forward * verticalSpeed * characterSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalSpeed * characterSpeed * Time.deltaTime);
    }
}
