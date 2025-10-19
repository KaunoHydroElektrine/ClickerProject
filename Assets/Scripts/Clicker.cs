using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening; neveikia
public class Clicker : MonoBehaviour
{
    private int clicks = 0;

    private void OnMouseDown()
    {
        clicks++;
        UIManager.Instance.UpdateClicks(clicks);
      //  transform.DOScale(Vector3.one * 1.5f, 0.3f).SetLoops(2, LoopType.Yoyo);
    }
}
