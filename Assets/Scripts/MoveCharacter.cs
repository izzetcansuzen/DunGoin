using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Animator animator;
    private float characterSpeed = 5f;
    private float characterJumpSpeed = 10f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Oyuncu yürüme tuşlarına basınca girilen değeri al
        float verticalSpeed = Input.GetAxis("Vertical");
        float horizontalSpeed = Input.GetAxis("Horizontal");
        float jumpSpeed = Input.GetAxis("Jump");

        //Oyuncu tıklamasına göre karakteri yönlendir
        transform.Translate(Vector3.forward * verticalSpeed * characterSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalSpeed * characterSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * jumpSpeed * characterJumpSpeed * Time.deltaTime);

        //Karakter aşağıda ki hareketlerden birini yapıyor mu?
        bool isWalkingVertical = verticalSpeed != 0;
        bool isWalkingHorizontal = horizontalSpeed != 0;

        //Karakter hareket ediyosa setBool ile parametre bilgilerini güncelle
        animator.SetBool("isForward", isWalkingVertical);
        animator.SetBool("isRight", isWalkingHorizontal);

        // Hangi hızda hareket ettiğini hesapla (dikey ve yatay hızların büyüklüğü) 5 katı olan kod
        //float movementSpeed = Mathf.Sqrt((verticalSpeed * verticalSpeed) + (horizontalSpeed * horizontalSpeed)) * characterSpeed;

        // Hangi hızda hareket ettiğini hesapla (dikey ve yatay hızların büyüklüğü)
        float movementSpeed = Mathf.Sqrt(verticalSpeed * verticalSpeed + horizontalSpeed * horizontalSpeed);

        // Animasyon hızını karakterin hareket hızına göre ayarla
        animator.speed = movementSpeed > 0 ? movementSpeed : 1f;  // Hareket varsa hız, yoksa normal hızda oynat
    }
}
