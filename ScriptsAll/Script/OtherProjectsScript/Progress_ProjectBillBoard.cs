using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class Progress : MonoBehaviour,IDragHandler,IPointerDownHandler
{
    [SerializeField]
    private VideoPlayer VideoPlayer;

    private Image progress;

    private void Awake()
    {
        progress = GetComponent<Image>();
    }
    
	private void Update ()
    {
        if (VideoPlayer.frameCount > 0)
            progress.fillAmount = (float)VideoPlayer.frame / (float)VideoPlayer.frameCount;
	}

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform,eventData.position,null,out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
        }
    }
    private void SkipToPercent(float pct)
    {
        var frame = VideoPlayer.frameCount * pct;
        VideoPlayer.frame = (long)frame;
    }
}
