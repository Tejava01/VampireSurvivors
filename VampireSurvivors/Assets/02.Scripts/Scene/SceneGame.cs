using UnityEngine;

public class SceneGame : MonoBehaviour
{
    [Header("Monster Prefab")]
    public GameObject GoblinPrefab;
    public GameObject SlimePrefab;
    public GameObject SnakePrefab;

    private GameObject _goblin;
    private GameObject _slime;
    private GameObject _snake;

    void Start()
    {
        GameObject monsters = new GameObject() { name = "@Monsters" };

        _goblin = GameObject.Instantiate(GoblinPrefab);
        _goblin.transform.parent = monsters.transform;
        _goblin.name = GoblinPrefab.name;
        _slime = GameObject.Instantiate(SlimePrefab);
        _slime.transform.parent = monsters.transform;
        _slime.name = SlimePrefab.name;
        _snake = GameObject.Instantiate(SnakePrefab);
        _snake.transform.parent = monsters.transform;
        _snake.name = SnakePrefab.name;
    }

    void Update()
    {
        
    }
}
