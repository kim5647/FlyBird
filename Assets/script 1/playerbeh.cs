using TMPro;
using UnityEngine;

public class playerbeh : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject fon;
    public GameObject Best;
    public TMP_Text Text1;
    Rigidbody2D player_rb;
    mapgen G;
    int resalt;
    private void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
        player_rb.velocity = new Vector2(6, 0);
        G = GameObject.FindGameObjectWithTag("mapgen").GetComponent<mapgen>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            player_rb.velocity = new Vector2(6, 8);
        }
        //player_rb.velocity = new Vector2(20,0);

        if (Input.touchCount > 0) // Проверяем, была ли нажата левая кнопка мыши (в данном примере)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero);

                if (hit.collider != null)
                {
                    // Если есть Collider под точкой клика, проверяем его тег
                    if (hit.collider.CompareTag("Desroy"))
                    {

                        Destroy(hit.collider.gameObject);

                    }
                }
            }


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish") || collision.CompareTag("Desroy"))
        {
            int currentResalt = PlayerPrefs.GetInt("resalt", 0); // Получаем сохраненное значение "resalt" из PlayerPrefs

            if (G.i > currentResalt) // Если текущий результат лучше сохраненного
            {
                resalt = G.i;
                PlayerPrefs.SetInt("resalt", resalt); // Устанавливаем новое значение "resalt" в PlayerPrefs
                PlayerPrefs.Save();
            }

            gameObject.SetActive(false);
            menu1.SetActive(false);
            menu2.SetActive(true);
            menu3.SetActive(true);
            fon.SetActive(true);
            Best.SetActive(true);

            Text1.text = "Best result: " + PlayerPrefs.GetInt("resalt", 0); // Обновляем текст с лучшим результатом
        }

    }

}
