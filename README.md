# Obstacle Escape

A beginner-friendly 3D obstacle Maze game developed in Unity using C#. The player must navigate through moving and rotating obstacles, avoid hazards, and reach the finish point to progress to the next level.

## Features

- Player movement using keyboard input
- Rotating obstacle hazards
- Timed falling obstacles
- Collision-based interactions
- Level progression system
- Scene restart functionality
- Object color change on collision
- Simple and modular C# scripts

## Gameplay

The player controls a character through an obstacle-filled environment. Touching obstacles can stop movement or restart the level, while reaching the finish area loads the next level.

## Scripts

### PlayerMovement.cs
Controls player movement and collision handling.

### Spinner.cs
Rotates obstacles continuously to create moving hazards.

### Dropper.cs
Creates timed falling Obstacles by enabling gravity after a delay.

### ObjectHit.cs
Changes an object's color when the player collides with it.

### NextLevel.cs
Loads the next scene when the player reaches the level endpoint.

### Restart.cs
Restarts the current level when the player collides with designated objects.

## Technologies Used

- Unity Engine
- C#
- Unity Physics System
- Scene Management

## Controls

| Key | Action |
|------|---------|
| W / S | Move Forward & Backward |
| A / D | Move Left & Right |

## Learning Outcomes

This project helped me understand:

- Player movement systems
- Collision detection
- Scene management
- Rigidbody physics
- Object interactions
- Game loop fundamentals
- Unity scripting with C#

## Future Improvements

- Score system
- Checkpoints
- UI menus
- Sound effects
- Particle effects
- Multiple difficulty levels

## Author

Chowmyan R

Aspiring Game Programmer specializing in Unity (C#), gameplay systems, and interactive game development.
