using UnityEngine;

namespace yo
{
    /// <summary>
    /// ���ĺ޲z��
    /// </summary>
    /// �M�ε{���ɰ��� : �n�y����(����(����)) - �Ĥ@���M�θ}��������ɷ|�K�[����
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        
        private AudioSource aud;

        private void Awake()
        {
            instance = this;

            aud = GetComponent<AudioSource>();   
        }

        /// <summary>
        /// ���񭵮�
        /// </summary>
        /// <param name="sound"></param>
        /// <param name="rangeVolume"></param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}
