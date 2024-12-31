using UnityEngine;
using DG.Tweening;

public enum MochiMonsterState
{
    Idle,
    Moving,
    Attack,
    Hurt
}

public class MochiMonster : MonoBehaviour
{
    [SerializeField]
    private Transform body;

    private Sequence idleSequence;
    private Sequence movingSequence;
    private Sequence attackSequence;
    private Sequence hurtSequence;

    private MochiMonsterState m_State;
    public MochiMonsterState state
    {
        get
        {
            return m_State;
        }
        set
        {
            m_State = value;

            if (m_State == MochiMonsterState.Idle)
            {
                idleSequence.Play();
            }
            else if (m_State == MochiMonsterState.Moving)
            {
            }
            else if (m_State == MochiMonsterState.Attack)
            {
            }
            else if (m_State == MochiMonsterState.Hurt)
            {
            }
        }
    }

    void Start()
    {
        CreateIdleSequence();

        m_State = MochiMonsterState.Idle;
    }

    void Update()
    {

    }

    private void CreateIdleSequence()
    {
        idleSequence = DOTween.Sequence();
        idleSequence.Append(body.DOScaleY(0.8f, 0.7f))
                    .Append(body.DOScaleY(1f, 0.5f));

        idleSequence.SetLoops(-1);
    }

    private void CreateAttackSequence()
    {
    }
}
