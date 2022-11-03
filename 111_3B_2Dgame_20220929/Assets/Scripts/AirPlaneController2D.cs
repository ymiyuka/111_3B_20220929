
using UnityEngine;

namespace yo
{
    /// <summary>
    /// 2D 飛機控制器
    /// </summary>
    public class AirPlaneController2D : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField]
        private float speedVertical = 3.7f;
        [SerializeField]
        private float speedHonrizontal = 3.7f;
        [Header("圖片")]
        [SerializeField] private Sprite pictureUp;
        [SerializeField] private Sprite pictureMiddle;
        [SerializeField] private Sprite pictureDown;

        [SerializeField, Header("圖片渲染元件")]
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHonrizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v, 0);

            if (v > 0)
            {
                spr.sprite = pictureUp;
            }
            if (v == 0)
            {
                spr.sprite = pictureMiddle;
            }
            if (v < 0)
            {
                spr.sprite = pictureDown;
            }
        }
    }
}
