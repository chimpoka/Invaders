using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Field field;
    public int width = 10;
    public int height = 10;

    // Создаем синглтон - единственный экземпляр класса
    static private Controller m_instance;
    // Property (по русски - свойство). Полезная штука, советую почитать о ней
    public static Controller Instance
    {
        get
        {
            if (m_instance == null)
            {
                // Создаем объект из префаба
                GameObject controller = Instantiate(Resources.Load("Prefabs/Controller")) as GameObject;
                // Сохраняем экземпляр класса
                m_instance = controller.GetComponent<Controller>();
            }
            return m_instance;
        }
    }

    private void Awake()
    {
        if (m_instance == null)
        {
            // Если m_instance еще не существует, то создаем его и просим не уничтожать при переодах на новые сцены
            m_instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (m_instance != this)
            {
                // Если m_instance есть, срочно удаляем этот объект
                Destroy(gameObject);
            }
        }
    }


    private void Start()
    {
        // Вызываем статический метод класса Field
        field = Field.Create(width, height);
    }
}
