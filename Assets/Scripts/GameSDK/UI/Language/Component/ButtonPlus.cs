using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonPlus : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        PlayClickSound();
    }

    private void PlayClickSound()
    {
        AudioManager.Instance.PlayBtn();
    }
}
