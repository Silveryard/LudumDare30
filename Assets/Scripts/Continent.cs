using UnityEngine;
using System.Collections;

public class Continent : MonoBehaviour{

    public delegate void IntegerDelegate(int x);

    public event IntegerDelegate OnUsersChange;
    public event IntegerDelegate OnServerChange;

    public int Population = 0;

    private int _servers;
    private int _users;

    public int Users{
        get { return _users; }
        set{
            _users = value;
            if (OnUsersChange != null)
                OnUsersChange(value);
        }
    }

    public int Servers{
        get { return _servers; }
        set{
            _servers = value;
            if (OnServerChange != null)
                OnServerChange(value);
        }
    }

}
