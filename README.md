# Snake Game

## Description
A simple console-based Snake game implemented in C# using basic programming concepts. The goal of the game is to control a snake to collect apples, avoid collisions with walls, and prevent the snake from biting itself. Each apple collected increases the snake's length and score.

## Features
- Dynamic grid display with border and game elements.
- Apple spawning at random positions within the grid.
- Snake movement controlled via arrow keys.
- Collision detection with walls, snake's body, and apples.
- Incremental speed increase every 3 apples collected.
![image](https://github.com/user-attachments/assets/c28419ca-95ab-49e4-ad8b-6e1558872c53)

## How to Play
1. Launch the game by running the executable.
2. Use the following keys to control the snake:
   - **Up Arrow**: Move up
   - **Down Arrow**: Move down
   - **Left Arrow**: Move left
   - **Right Arrow**: Move right
3. Collect apples (denoted by `a`) to grow the snake and increase your score.
4. Avoid hitting the walls (`#`) or the snake's own body (`■`).
5. The game ends when the snake collides with a wall or itself.

## Game Rules
- The initial snake length is 1.
- Each apple increases the snake's length by 1.
- For every 3 apples collected, the game speed increases by reducing the frame delay by 100ms (minimum delay is 100ms).
- Maximum frame delay is 500ms.

## Installation and Setup
1. Clone the repository:
   ```bash
   git clone <repository_url>
   ```
2. Open the project in Visual Studio.
3. Build and run the project.

## Project Structure
- **SnakeGame.cs**: Main logic for grid rendering and game mechanics.
- **Coord.cs**: Handles coordinate logic for the snake and apple.
- **Enums**: Defines movement directions.

## Key Classes and Methods
- **Coord**: Represents a coordinate in the grid.
- **Equals**: Compares two coordinates.
- **ApplyMoveDirection**: Updates the coordinate based on the movement direction.
- **Game Loop**: Controls the game rendering and user input.
- **Collision Detection**: Ensures the snake doesn't collide with itself or the grid boundaries.

## Future Improvements
- Add a start menu with options to choose difficulty levels.
- Implement high-score tracking.
- Add sound effects for gameplay events.
- Create a graphical user interface (GUI) for enhanced visuals.

## Requirements
- .NET SDK 6.0 or later
- Visual Studio 2022 or any compatible IDE

## License
This project is licensed under the MIT License. Feel free to modify and distribute.

## Author
Sumana Madhireddy

## Credits
This project was inspired by a tutorial on The Coders Cat. Thanks to [The Coders Cat] for the guidance and resources.
