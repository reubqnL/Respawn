# RespawnGame - Developer Notes

## Project Overview
* **Tech Stack:** C# (.NET 10.0), Raylib-cs (via NuGet)
* **IDE:** JetBrains Rider
* **Repository:** `https://github.com/reubqnL/Respawn.git`
* **Architecture:** Standalone code-driven setup without heavy game engine overhead.

---

## Directory Structure

```text
RespawnGame/
├── Program.cs             # Game entry point & main loop
├── RespawnGame.csproj     # C# project settings & package dependencies
├── RespawnGame.slnx       # Solution file
├── DEV_NOTES.md           # Project documentation
├── Core/                  # Game state, level managers, and global systems
├── Entities/              # Game objects (Player, Enemies, Projectiles)
└── Assets/                # Sprites (.png), audio (.wav), fonts (.ttf)