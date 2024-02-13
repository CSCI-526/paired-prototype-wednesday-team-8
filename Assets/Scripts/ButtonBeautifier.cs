using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class ButtonBeautifier : MonoBehaviour
{
    public Color normalColor = Color.white;
    public Color highlightColor = Color.yellow;
    public float animationSpeed = 1.5f;
    private Button button;
    private TextMeshProUGUI buttonText;

    void Start()
    {
        button = GetComponent<Button>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();

        // Set initial button styles
        BeautifyButton();
        StartCoroutine(AnimateButton());
    }

    void BeautifyButton()
    {
        // Apply styles to the button
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = normalColor;
        colorBlock.highlightedColor = highlightColor;
        button.colors = colorBlock;

        // Set button text style if TextMeshPro component is found
        if (buttonText != null)
        {
            buttonText.color = normalColor; // Set your desired text color
            buttonText.fontStyle = FontStyles.Bold; // Apply bold style
        }
    }

    IEnumerator AnimateButton()
    {
        Vector3 startScale = transform.localScale;
        Vector3 endScale = startScale * 1.1f; // Scale up by 10%

        while (true)
        {
            // Scale up
            float timer = 0.0f;
            while (timer <= 1.0f)
            {
                transform.localScale = Vector3.Lerp(startScale, endScale, timer);
                timer += Time.deltaTime * animationSpeed;
                yield return null;
            }

            // Scale down
            timer = 0.0f;
            while (timer <= 1.0f)
            {
                transform.localScale = Vector3.Lerp(endScale, startScale, timer);
                timer += Time.deltaTime * animationSpeed;
                yield return null;
            }
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
