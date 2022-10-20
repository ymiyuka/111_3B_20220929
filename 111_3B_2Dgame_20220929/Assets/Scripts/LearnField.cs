using UnityEngine;

namespace YO
{
    /// <summary>
    /// 學習欄位 Learn Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // 欄位 Field：儲存資料
        // 語法
        // 修飾詞 資料類型 欄位名稱；
        // 修飾詞：設定資料權限
        // 私人：private，僅在此類別內能夠存取
        private int lv;

        // 等於 指定符號：將等於右邊的結果指定給左邊
        // 公開：public，所有類別都能夠存取，顯示
        public int enemy = 5;
        //整數 int 
        public int hp = 100;
        //浮點數 float
        public float speed = 3.5f;
        //字串 string
        public string nameplayer = "沃德";
        public string content = "哈囉";
        //布林值
        public bool isPass = true;
        public bool isDead = false;
    }
}