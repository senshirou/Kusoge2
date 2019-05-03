using UnityEngine;

public class RollballPlayerTransform : MonoBehaviour {
    public float speed = 1.0f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 movement = Vector3.zero;

        //右矢印キーで、右方向に動かす
        if (Input.GetKey(KeyCode.RightArrow)) {
            movement.x = 1;
        }

        //左方向に動かしている部分
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //左に動かすにはどうすればいいか、考えてみましょう
        }

        //上矢印キーで、上右方向に動かす
        if (Input.GetKey(KeyCode.UpArrow)) {
            movement.z = 1;
        }

        ////下方向に動かしている部分
        //if (Input.GetKey(KeyCode.???????)) {
        //    //後ろに動かすにはどうすればいいか、考えてみましょう
        //}

        transform.Translate(movement * Time.deltaTime * speed);
    }



    //void OnTriggerEnter(Collider other) {
    //    //Debug.Log("Trigger enter");
    //    //Debug.Log(other.gameObject.tag);
    //    if (other.gameObject.CompareTag("PPickup")) {
    //        other.gameObject.SetActive(false);
    //    }
    //}


}


