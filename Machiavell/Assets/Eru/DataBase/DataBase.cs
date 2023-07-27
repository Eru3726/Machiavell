using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataBase", menuName = "DataBase/CreateDataBase")]
public class DataBase : ScriptableObject
{
    public List<Enemy> enemys = new List<Enemy>();
    public List<Item> items = new List<Item>();
    public List<Exp> exp = new List<Exp>();
    public List<Weapon> weapons = new List<Weapon>();
}
