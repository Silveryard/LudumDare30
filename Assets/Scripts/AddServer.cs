using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AddServer : Command{
    public void Do(Continent continent){
        continent.Servers++;

        Clickable.OnClickCommand = null;
    }
}
