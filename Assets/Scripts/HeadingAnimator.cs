using UnityEngine;
using TMPro;

public class HeadingAnimator : MonoBehaviour
{
    public TextMeshProUGUI headingText;
    public float pulseSpeed = 2f;
    public Color startColor = Color.blue;
    public Color endColor = Color.red;

    private void Update()
    {
        // Create a pulsing scale effect
        float scale = Mathf.Sin(Time.time * pulseSpeed) * 0.1f + 1f;
        headingText.transform.localScale = new Vector3(scale, scale, scale);

        // Smoothly transition between two colors
        headingText.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time, 1));
    }
}
