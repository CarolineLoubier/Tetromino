using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    [SerializeField] private int _width, _height;
    [SerializeField] Tile _tilePrefab;
    [SerializeField]private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = "Tile " + x + " " + y;

                _tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _cam.transform.position = new Vector3((float)_width/2 -0.5f, (float)_height/2 -0.5f, -15);
    }
}
