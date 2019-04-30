using System.Collections.Generic;

namespace Parcels.Models
{
  public class Item
  {
    private string _description;
    private int _weight;
    private int _height;
    private int _width;
    private int _length;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description, int weight, int height, int width, int length)
    {
      _description = description;
      _weight = weight;
      _height = height;
      _width = width;
      _length = length;
      _instances.Add(this);
    }

    public int GetCost()
    {
      if (_weight + _length <= 100)
      {
        return 200;
      }
      else
      {
        return 400;
      }
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

  }
}
