# Battleship Console Game (C#)

## Overview

This project is a console-based implementation of the classic **Battleship game**, built using **C# and .NET**.
The game focuses on object-oriented design, modular structure, and clean separation of responsibilities.

---

## Project Structure

The project is organized into several folders to maintain clarity and scalability:

```
BattleshipGame/
│
├── Program.cs
│
├── Controllers/
│   └── GameController.cs
│
├── Models/
│   ├── Player.cs
│   ├── Board.cs
│   ├── Cell.cs
│   ├── Ship.cs
│   └── Position.cs
│
├── Interfaces/
│   ├── IGameController.cs
│   ├── IPlayer.cs
│   ├── IBoard.cs
│   ├── ICell.cs
│   └── IShip.cs
│
├── Enums/
│   ├── CellState.cs
│   ├── ShipType.cs
│   ├── GameStatus.cs
│   └── Orientation.cs
```

---

## Architecture Overview

The project follows a **layered and modular design**:

### 1. Controllers

Handles the main game logic and flow.

* **GameController**

  * Manages turns
  * Processes attacks
  * Tracks game status and winner
  * Coordinates interactions between players, boards, and ships

---

### 2. Models

Represents the core data structures of the game.

* **Player** → represents a game player
* **Board** → represents the grid (10x10)
* **Cell** → represents each position on the board
* **Ship** → represents ships with size and hit tracking
* **Position** → represents coordinates (X, Y)

---

### 3. Interfaces

Defines contracts to support flexibility and future scalability.

* **IGameController**
* **IPlayer**
* **IBoard**
* **ICell**
* **IShip**

These interfaces allow the system to be extended in the future (e.g., AI players or different board implementations).

---

### 4. Enums

Defines fixed states used across the game.

* **CellState** → Empty, Occupied, Hit, Miss
* **ShipType** → Carrier, Battleship, Cruiser, Destroyer, Patrol Boat
* **GameStatus** → Setup, In Progress, Finished
* **Orientation** → Horizontal, Vertical

---

## Object Relationships

The system follows a clear hierarchy:

* GameController manages Players
* Player is associated with Board and Ships
* Board contains Cells
* Cell may contain a Ship
* Ship tracks its positions and hit status

---

## Design Principles

* **Separation of Concerns**
  Each class has a clear responsibility.

* **Encapsulation**
  Game state is controlled through the GameController.

* **Extensibility**
  Interfaces are used to allow future enhancements (e.g., AI or multiplayer modes).

