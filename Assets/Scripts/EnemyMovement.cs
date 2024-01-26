using UnityEngine;
    public class ObjectMovement : MonoBehaviour
    {
        public float currentX; // aloituskoordinaatti
        [SerializeField]
        public float maxX;
         // Maksimikoordinaatti
        [SerializeField]
        public float speed; // Liikkumisnopeus

        private bool movingRight = true; // Liikkumissuunta

        // Update is called once per frame
        void Update()
        {
            // Liikutetaan oliota vaakasuunnassa
            if (movingRight)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }

            // Tarkistetaan, onko olio saavuttanut jomman kumman koordinaatin
            if (transform.position.x >= maxX)
            {
                movingRight = false;
            }
            else if (transform.position.x <= currentX)
            {
                movingRight = true;
            }
        }
    }
