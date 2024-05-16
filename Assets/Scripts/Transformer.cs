using DG.Tweening;
using UnityEngine;

public class Transformer<T> : MonoBehaviour
{
    [SerializeField] private T _tranformation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    public T Transformation => _tranformation;
    public float Duration => _duration;
    public int Repeats => _repeats;
    public LoopType LoopType => _loopType;
}
