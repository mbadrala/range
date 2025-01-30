using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Button : MonoBehaviour
{
    [SerializeField]
    private RectTransform body;

    public void OnEnter()
    {
        body.DOScale(1.1f, 0.3f);
    }

    public void OnExit()
    {
        body.DOScale(1f, 0.3f);
    }

    public void OnDown()
    {
        body.DOScale(0.9f, 0.1f);
    }

    public void OnUp()
    {
        body.DOScale(1.1f, 0.3f);
    }

    public void OnClick()
    {
        body.DOScale(0f, 0.2f).OnComplete(() =>
        {
            Destroy(gameObject);
        });
    }
}
