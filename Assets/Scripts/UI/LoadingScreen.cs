using System.Collections;
using UnityEngine;
using TMPro;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI loadingText;

    void Start()
    {
        StartCoroutine(BlinkText());
    }

    IEnumerator BlinkText()
    {
        float duration = 0.6f;
        float elapsedTime = 0f;
        Color startColor = Color.white;
        Color endColor = new Color(1f, 1f, 1f, 0f);

        while (true)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            float alpha = Mathf.PingPong(t, 1f);
            loadingText.color = new Color(1f, 1f, 1f, alpha);

            yield return null;
        }
    }
}
