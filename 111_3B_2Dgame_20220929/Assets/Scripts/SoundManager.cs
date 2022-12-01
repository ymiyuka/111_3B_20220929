using UnityEngine;

namespace yo
{
    /// <summary>
    /// 音效管理氣
    /// </summary>
    /// 套用程式時執行 : 要球員建(類型(元件)) - 第一次套用腳本給物件時會添加元件
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
        /// 播放音效
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
