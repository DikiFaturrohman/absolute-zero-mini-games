using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed = 0.1f; // Atur nilai ini agar lebih kecil untuk gerakan lebih lambat
    public Renderer backgroundRenderer;

    void Update()
    {
        float offset = backgroundSpeed * Time.deltaTime;
        backgroundRenderer.material.mainTextureOffset += new Vector2(offset, 0f);
    }
}
