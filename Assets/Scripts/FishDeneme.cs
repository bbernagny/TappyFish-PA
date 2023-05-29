using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDeneme : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    private float targetAngle;
    public float rotationSpeed = 5f;
    public float maxAngle = 20f;
    public float minAngle = -60f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, speed);
            targetAngle = maxAngle; // Yukarı hareket ettiğinde hedef açıyı maxAçı yap
        }

        if (_rb.velocity.y < 0)
        {
            targetAngle = minAngle; // Aşağı düşerken hedef açıyı minAçı yap
        }

        // Mevcut rotasyonu hedef rotasyona doğru yumuşak bir şekilde güncelle
        float currentAngle = Mathf.LerpAngle(transform.rotation.eulerAngles.z, targetAngle, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
}
