using UnityEngine;

public class Metronome : MonoBehaviour
{
    public float bpm = 120.0f;
    public int beatsPerMeasure = 4;

    private float nextTick = 0.0f;
    private float timePerTick;
    private int tickCounter = 0;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("�� ��'��� ���� ���������� AudioSource!");
            enabled = false; // �������� ������, ��� �������� �������
            return;
        }

        if (audioSource.clip == null)
        {
            Debug.LogWarning("�� ���������� AudioSource �� ���������� �������.");
        }

        timePerTick = 60.0f / bpm;
        nextTick = (float)AudioSettings.dspTime + timePerTick; // ������ ���� ������
    }

    void Update()
    {
        if ((float)AudioSettings.dspTime >= nextTick)
        {
            PlayTick();
            nextTick += timePerTick;
            tickCounter++;

            if (tickCounter >= beatsPerMeasure)
            {
                tickCounter = 0;
                // ��� ����� ������ ����� ��� ������� ������ �����
            }
        }
    }

    void PlayTick()
    {
        if (audioSource.clip != null)
        {
            audioSource.PlayScheduled(AudioSettings.dspTime);
        }
        else
        {
            Debug.LogWarning("���� �������� ��� ����������.");
        }
    }
}