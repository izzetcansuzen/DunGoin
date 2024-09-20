using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public GameObject character;

    private Vector3 offset = new Vector3(0, 10, -10);

    private Quaternion initialRotation;
    // Start is called before the first frame update
    void Start()
    {
        // Kameranın başlangıç rotasyonunu ayarlıyoruz
        initialRotation = Quaternion.Euler(30f, 0f, 0f); // Örneğin, yukarıdan aşağıya bakacak şekilde 30 derece açıyla
        transform.rotation = initialRotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = character.transform.position + offset;
    }
}
