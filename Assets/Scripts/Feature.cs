using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Feature{

    int initialCost { get; }
    int income { get; }
    float SatisfactionModifier { get; }
    
    void Equip();
    void Unequip();
}
