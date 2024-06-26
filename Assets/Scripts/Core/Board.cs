using UnityEngine;

public class Board : MonoBehaviour
{
  public Transform emptySprite;
  public int height = 30;
  public int width = 10;
  public int header = 8;

  private Transform[,] grid;

  private void Awake()
  {
    this.grid = new Transform[this.width, this.height];
  }

  private void Start()
  {
    this.DrawEmptyCells();
  }

  private void DrawEmptyCells()
  {
    if (this.emptySprite)
    {
      for (int y = 0; y < this.height - this.header; y++)
      {
        for (int x = 0; x < this.width; x++)
        {
          Transform clone;
          clone = Instantiate(this.emptySprite, new Vector3(x, y, 0), Quaternion.identity);
          clone.name = "Board Space (x = " + x.ToString() + ", y = " + y.ToString() + ")";
          clone.transform.parent = this.transform;
        }
      }
    }
    else
    {
      Debug.Log("WARNING! Please assign the emptySprite object");
    }
  }
}
