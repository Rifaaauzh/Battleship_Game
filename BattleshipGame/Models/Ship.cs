using System.Collections;
using Battleship.Enum;
using Battleship.Interfaces;

namespace Battleship.Models;

public class Ship : IShip
{
    public ShipType ShipType { get; set;}
    public int Size { get; set; }
    public int Hits { get; set; }
    public Orientation Orientation { get; }

    public Ship(ShipType shipType, Orientation orientation)
    {
        ShipType = shipType;
        Hits = 0;
        Orientation = orientation;

        switch (shipType)
        {
            case ShipType.Carrier:
             Size = 5;
             break;
            case ShipType.Battleship:
             Size = 4;
             break;
            case ShipType.Cruiser:
             Size = 3;
             break;
            case ShipType.Destroyer:
             Size = 1;
             break;
            case ShipType.PatrolBoat:
             Size = 2;
             break;
        }
    }
    
}