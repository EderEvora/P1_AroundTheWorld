using UnityEngine;

public class FlipLighting : MonoBehaviour
{
    public Light mainLight;
    public Color normalColor = Color.white;
    public Color flippedColor = new Color(1f, 0.5f, 0.2f);
    public float normalIntensity = 1f;
    public float flippedIntensity = 1.5f;
    bool flipped = false;

    void Update()
    {
        float d = Vector3.Dot(transform.up, Vector3.up);

        if (!flipped && d < -0.7f)
        {
            flipped = true;
            mainLight.color = flippedColor;
            mainLight.intensity = flippedIntensity;
        }
        else if (flipped && d > 0.7f)
        {
            flipped = false;
            mainLight.color = normalColor;
            mainLight.intensity = normalIntensity;
        }
    }
}