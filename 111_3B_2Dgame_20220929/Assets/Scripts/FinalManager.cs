using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace yo
{
    /// <summary>
    /// 結束管理氣
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTiele;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTiele = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
        }
    }
}
