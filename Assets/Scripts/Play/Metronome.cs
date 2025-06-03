using UnityEngine;

public class Metronome : MonoBehaviour
{
    public float bpm = 120.0f;
    public int beatsPerMeasure = 4;

    public Exc exc;
    public int nExc = 0;
    int exTick = 0;

    private float nextTick = 0.0f;
    private float timePerTick;
    private int tickCounter = 0;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("На об'єкті немає компонента AudioSource!");
            enabled = false; // Вимикаємо скрипт, щоб уникнути помилок
            return;
        }

        if (audioSource.clip == null)
        {
            Debug.LogWarning("До компонента AudioSource не призначено аудіокліп.");
        }

        timePerTick = 60.0f / bpm;
        nextTick = (float)AudioSettings.dspTime + timePerTick; // Перший удар одразу
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
                // Тут можна додати логіку для початку нового такту
                
            }

            if (nExc == 1)
            {
                if (exTick == exc.MaxEx1) exTick = 0;
                exTick++;
                exc.ex1?.Invoke(this, new ExEvent { Tick = exTick });
            }
            else if (nExc == 2)
            {
                if (exTick == exc.MaxEx2) exTick = 0;
                exTick++;
                exc.ex2?.Invoke(this, new ExEvent { Tick = exTick });
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
            Debug.LogWarning("Немає аудіокліпу для відтворення.");
        }
    }
}