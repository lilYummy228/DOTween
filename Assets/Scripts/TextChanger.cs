using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : Transformer<string>
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText($"{Transformation} changed", Duration));
        sequence.Append(_text.DOText($" {Transformation} appended", Duration).SetRelative());
        sequence.Append(_text.DOText($"{Transformation} hacked", Duration, true, ScrambleMode.All));
        sequence.SetLoops(Repeats, LoopType);
    }
}
