using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 5f; // Kecepatan awal kamera
    private float timeElapsed = 0f; // Waktu yang telah berlalu
    private bool speedIncreased = false; // Flag untuk memastikan penambahan hanya sekali

    void Update()
    {
        // Update waktu yang telah berlalu
        timeElapsed += Time.deltaTime;

        // Jika sudah lebih dari 10 detik dan kecepatan belum ditambah, tambahkan 5 ke cameraSpeed
        if (timeElapsed >= 60f && !speedIncreased)
        {
            cameraSpeed += 5f;
            speedIncreased = true; // Set flag agar tidak menambah lagi
        }

        // Gerakkan kamera ke kanan dengan kecepatan cameraSpeed
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
